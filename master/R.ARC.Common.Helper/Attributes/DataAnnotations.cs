using System.ComponentModel.DataAnnotations;

namespace R.ARC.Common.Helper.Attributes
{
    public class RarcRequiredAttribute : RequiredAttribute
    {
        public override string FormatErrorMessage(string name)
        {
            return string.Format("{0} - required area!", name);
        }
    }
}
