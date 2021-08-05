

docker pull postgres


docker run -d -p 5432:5432 --name postgres -e POSTGRES_PASSWORD=postgres postgres
->a77e232ae0b1be9a9cf77954c0fef7d1e2a369c9c18c74ba49aa212b3c49eeae

docker exec -it postgres bash
root@91487859c040:/# psql -U postgres
psql (12.2 (Debian 12.2-2.pgdg100+1))
Type "help" for help.

postgres=# CREATE DATABASE r_arc;
CREATE DATABASE
postgres=# \q
root@91487859c040:/# psql -h localhost -p 5432 -U postgres -W
Password:
psql (12.2 (Debian 12.2-2.pgdg100+1))
Type "help" for help.

postgres=# \l
                                 List of databases
   Name    |  Owner   | Encoding |  Collate   |   Ctype    |   Access privileges
-----------+----------+----------+------------+------------+-----------------------
 postgres  | postgres | UTF8     | en_US.utf8 | en_US.utf8 |
 ==> r_arc     | postgres | UTF8     | en_US.utf8 | en_US.utf8 |
 template0 | postgres | UTF8     | en_US.utf8 | en_US.utf8 | =c/postgres          +
           |          |          |            |            | postgres=CTc/postgres
 template1 | postgres | UTF8     | en_US.utf8 | en_US.utf8 | =c/postgres          +
           |          |          |            |            | postgres=CTc/postgres
(4 rows)

postgres=#