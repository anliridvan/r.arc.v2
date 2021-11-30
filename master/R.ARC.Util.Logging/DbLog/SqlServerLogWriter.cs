using FastMember;
using Npgsql;
using NpgsqlTypes;
using R.ARC.Util.Logging.Contracts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;

namespace R.ARC.Util.Logging.DbLog
{
    /// <summary>
    /// <see cref="ILogWriter"/> implementation for storing log records to SQL Server
    /// </summary>
    public class SqlServerLogWriter : ILogWriter
    {
        private readonly Dictionary<string, string> _columnMappings;
        private readonly string _connectionString;

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlServerLogWriter"/> class
        /// </summary>
        /// <param name="connectionString">Connection string for the logging database</param>
        public SqlServerLogWriter(string connectionString)
        {
            _connectionString = connectionString;
            _columnMappings = new Dictionary<string, string>
            {
                { "EventId", "EventID" },
                { "EventName", "EventName" },
                { "LogLevel", "LogLevel" },
                { "Category", "Category" },
                { "LogTime", "LogTime" },
                { "Scope", "Scope" },
                { "Message", "Message" },
                { "Exception", "Exception" },
                { "UserName", "UserName" },
                { "IpAddress", "IpAddress" },
                { "MacAddress", "MacAddress" },
                { "HostName", "HostName" },
                { "RequestUrl", "RequestUrl" },
                { "RequestBody", "RequestBody" },
                { "AppName", "AppName" }
            };
        }

        /// <summary>
        /// Writes a collection of log records to database at once
        /// </summary>
        /// <param name="logs">List of <see cref="LogRecord"/> objects</param>
        /// <param name="lockObject">Locking object</param>
        /// <param name="flushingInProgress">Indicates if writing process is still in progress; set to false at the end of this method</param>
        public void WriteBulk(List<LogRecord> logs, object lockObject, ref bool flushingInProgress)
        {
            bool lockTaken = false;
            bool exceptionThrown = false;
            NpgsqlConnection connection = new NpgsqlConnection(_connectionString);
            connection.Open();
            NpgsqlTransaction transaction = connection.BeginTransaction();

            try
            {
                var DestinationTableName = "Logging";

                PropertyInfo[] properties = typeof(LogRecord).GetProperties();
                int colCount = properties.Length;

                NpgsqlDbType[] types = new NpgsqlDbType[colCount];
                int[] lengths = new int[colCount];
                string[] fieldNames = new string[colCount];

                using (var cmd = new NpgsqlCommand("SELECT * FROM " + DestinationTableName + " LIMIT 1", connection))
                {
                    using (var rdr = cmd.ExecuteReader())
                    {
                        if (rdr.FieldCount != colCount)
                        {
                            throw new ArgumentOutOfRangeException("dataTable", "Column count in Destination Table does not match column count in source table.");
                        }
                        var columns = rdr.GetColumnSchema();
                        for (int i = 0; i < colCount; i++)
                        {
                            types[i] = (NpgsqlDbType)columns[i].NpgsqlDbType;
                            lengths[i] = columns[i].ColumnSize == null ? 0 : (int)columns[i].ColumnSize;
                            fieldNames[i] = columns[i].ColumnName;
                        }
                    }

                }
                var sB = new StringBuilder(fieldNames[0]);
                for (int p = 1; p < colCount; p++)
                {
                    sB.Append(", " + fieldNames[p]);
                }

                using (var writer = connection.BeginBinaryImport("COPY " + DestinationTableName + " (" + sB.ToString() + ") FROM STDIN (FORMAT BINARY)"))
                {
                    foreach (var t in logs)
                    {
                        writer.StartRow();

                        for (int i = 0; i < colCount; i++)
                        {
                            if (properties[i].GetValue(t) == null)
                            {
                                writer.WriteNull();
                            }
                            else
                            {
                                #region Net Types Mapping On PostgresDB Types

                                switch (types[i])
                                {
                                    case NpgsqlDbType.Bigint:
                                        writer.Write((long)properties[i].GetValue(t), types[i]);
                                        break;
                                    case NpgsqlDbType.Bit:
                                        if (lengths[i] > 1)
                                        {
                                            writer.Write((byte[])properties[i].GetValue(t), types[i]);
                                        }
                                        else
                                        {
                                            writer.Write((byte)properties[i].GetValue(t), types[i]);
                                        }
                                        break;
                                    case NpgsqlDbType.Boolean:
                                        writer.Write((bool)properties[i].GetValue(t), types[i]);
                                        break;
                                    case NpgsqlDbType.Bytea:
                                        writer.Write((byte[])properties[i].GetValue(t), types[i]);
                                        break;
                                    case NpgsqlDbType.Char:
                                        if (properties[i].GetType() == typeof(string))
                                        {
                                            writer.Write((string)properties[i].GetValue(t), types[i]);
                                        }
                                        else if (properties[i].GetType() == typeof(Guid))
                                        {
                                            var value = properties[i].GetValue(t).ToString();
                                            writer.Write(value, types[i]);
                                        }


                                        else if (lengths[i] > 1)
                                        {
                                            writer.Write((char[])properties[i].GetValue(t), types[i]);
                                        }
                                        else
                                        {

                                            var s = ((string)properties[i].GetValue(t).ToString()).ToCharArray();
                                            writer.Write(s[0], types[i]);
                                        }
                                        break;
                                    case NpgsqlDbType.Time:
                                    case NpgsqlDbType.Timestamp:
                                    case NpgsqlDbType.TimestampTz:
                                    case NpgsqlDbType.Date:
                                        writer.Write((DateTime)properties[i].GetValue(t), types[i]);
                                        break;
                                    case NpgsqlDbType.Double:
                                        writer.Write((double)properties[i].GetValue(t), types[i]);
                                        break;
                                    case NpgsqlDbType.Integer:
                                        try
                                        {
                                            if (properties[i].GetType() == typeof(int))
                                            {
                                                writer.Write((int)properties[i].GetValue(t), types[i]);
                                                break;
                                            }
                                            else if (properties[i].GetType() == typeof(string))
                                            {
                                                var swap = Convert.ToInt32(properties[i].GetValue(t));
                                                writer.Write((int)swap, types[i]);
                                                break;
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            string sh = ex.Message;
                                        }

                                        writer.Write((object)properties[i].GetValue(t), types[i]);
                                        break;
                                    case NpgsqlDbType.Interval:
                                        writer.Write((TimeSpan)properties[i].GetValue(t), types[i]);
                                        break;
                                    case NpgsqlDbType.Numeric:
                                    case NpgsqlDbType.Money:
                                        writer.Write((decimal)properties[i].GetValue(t), types[i]);
                                        break;
                                    case NpgsqlDbType.Real:
                                        writer.Write((Single)properties[i].GetValue(t), types[i]);
                                        break;
                                    case NpgsqlDbType.Smallint:

                                        try
                                        {
                                            if (properties[i].GetType() == typeof(byte))
                                            {
                                                var swap = Convert.ToInt16(properties[i].GetValue(t));
                                                writer.Write((short)swap, types[i]);
                                                break;
                                            }
                                            writer.Write((short)properties[i].GetValue(t), types[i]);
                                        }
                                        catch (Exception ex)
                                        {
                                            string ms = ex.Message;
                                        }

                                        break;
                                    case NpgsqlDbType.Varchar:
                                    case NpgsqlDbType.Text:
                                        writer.Write((string)properties[i].GetValue(t), types[i]);
                                        break;
                                    case NpgsqlDbType.Uuid:
                                        writer.Write((Guid)properties[i].GetValue(t), types[i]);
                                        break;
                                    case NpgsqlDbType.Xml:
                                        writer.Write((string)properties[i].GetValue(t), types[i]);
                                        break;
                                }
                                #endregion
                            }
                        }
                    }
                    writer.Complete();
                }
            }
            catch
            {
                if (connection.State == ConnectionState.Open)
                {
                    transaction.Rollback();
                }

                exceptionThrown = true;
            }
            finally
            {
                if (lockTaken)
                {
                    if (!exceptionThrown)
                    {
                        logs.Clear();
                    }
                    else
                    {
                        // Drop the older half of log records to prevent OutOfMemoryException
                        logs.RemoveRange(0, logs.Count / 2);
                    }

                    Monitor.Exit(lockObject);
                }

                transaction.Dispose();
                connection.Close();
                flushingInProgress = false;
            }
        }

        /// <summary>
        /// Writes a single log record to database
        /// </summary>
        /// <param name="log"><see cref="LogRecord"/> instance to be written</param>
        public void WriteLog(LogRecord log)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(_connectionString))
            using (NpgsqlCommand command = new NpgsqlCommand(
                        string.Format(@"CALL public.logrecordinsert('{0}', {1}, '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}');",
                                        log.AppName,
                                        log.EventId,
                                        log.EventName.Replace("'", string.Empty),
                                        log.LogLevel.ToString(),
                                        log.Category.Replace("'", string.Empty),
                                        log.Scope.Replace("'", string.Empty),
                                        log.Message.Replace("'", string.Empty),
                                        log.LogTime,
                                        log.UserName.Replace("'", string.Empty),
                                        log.IpAddress,
                                        log.MacAddress,
                                        log.HostName.Replace("'", string.Empty),
                                        log.RequestUrl.Replace("'", string.Empty),
                                        log.RequestBody.Replace("'", string.Empty),
                                        (log.Exception != null ? log.Exception.ToString().Replace("'",string.Empty) : string.Empty)),
                        connection))
            {
                connection.Open();
                command.ExecuteNonQuery();
            }

            #region Parameterized call
            //// Fak Postgres - Not Supported Parameterized Procedure Calls --> https://www.npgsql.org/doc/basic-usage.html#stored-functions-and-procedures
            //// The only way to call a stored procedure is to write your own CALL my_proc(...)
            ////using (NpgsqlCommand command = new NpgsqlCommand("logrecordinsert", connection))
            ////{
            ////    connection.Open();
            ////    command.CommandType = CommandType.StoredProcedure;
            ////    command.Parameters.AddWithValue("appname", log.AppName);
            ////    command.Parameters.AddWithValue("eventid", log.EventId);
            ////    command.Parameters.AddWithValue("eventname", log.EventName);
            ////    command.Parameters.AddWithValue("loglevel", log.LogLevel.ToString());
            ////    command.Parameters.AddWithValue("category", log.Category);
            ////    command.Parameters.AddWithValue("scope", log.Scope);
            ////    command.Parameters.AddWithValue("message", log.Message);
            ////    command.Parameters.AddWithValue("logtime", log.LogTime);
            ////    command.Parameters.AddWithValue("username", log.UserName);
            ////    command.Parameters.AddWithValue("ipaddress", log.IpAddress);
            ////    command.Parameters.AddWithValue("macaddress", log.MacAddress);
            ////    command.Parameters.AddWithValue("hostname", log.HostName);
            ////    command.Parameters.AddWithValue("requesturl", log.RequestUrl);
            ////    command.Parameters.AddWithValue("requestbody", log.RequestBody);
            ////    command.Parameters.AddWithValue("exception", (log.Exception != null ? log.Exception.ToString() : string.Empty));
            ////    command.ExecuteNonQuery();
            ////}
            #endregion
        }
    }
}
