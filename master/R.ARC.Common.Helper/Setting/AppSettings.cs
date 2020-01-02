using System.ComponentModel.DataAnnotations;

namespace R.ARC.Common.Setting
{

    public class AppSettings
    {
        [Required]
        public ApiSettings API { get; set; }
        [Required]
        public SwaggerDefinition Swagger { get; set; }
        [Required]
        public JwtIssuerOptionsDefinition JwtIssuerOptions { get; set; }
        //[Required]
        public ApplicationInsightsDefinition ApplicationInsights { get; set; }
        [Required]
        public DatabaseDefinition Database { get; set; }
        
        public string UploadsPath { get; set; }

    }

    public class ApiSettings
    {
        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        public ApiContact Contact { get; set; }

        public string TermsOfServiceUrl { get; set; }

        public ApiLicense License { get; set; }
    }

    public class ApiContact
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public string Url { get; set; }
    }

    public class ApiLicense
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }

    public class SwaggerDefinition
    {
        [Required]
        public bool Enabled { get; set; }
    }

    public class JwtIssuerOptionsDefinition
    {
        [Required]
        public string Issuer { get; set; }
        [Required]
        public string Audience { get; set; }
    }

    public class ApplicationInsightsDefinition
    {
        public string InstrumentationKey { get; set; }
    }

    public class DatabaseDefinition
    {
        [Required]
        public bool UseInMemoryDatabase { get; set; } = true;
    }
}
