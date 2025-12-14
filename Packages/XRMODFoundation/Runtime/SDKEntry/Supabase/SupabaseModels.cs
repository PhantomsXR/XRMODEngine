using System;
using Postgrest.Attributes;
using Postgrest.Models;

namespace Phantom.XRMOD.SDKEntry.Supabase
{
    [Table("projects")]
    public class Project : BaseModel
    {
        [PrimaryKey("id")]
        public string Id { get; set; }

        [Column("app_key")]
        public string AppKey { get; set; }

        [Column("app_secret")]
        public string AppSecret { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("is_active")]
        public bool IsActive { get; set; }

        [Column("environment")]
        public string Environment { get; set; }
    }

    [Table("experiences")]
    public class Experience : BaseModel
    {
        [PrimaryKey("id")]
        public string Id { get; set; }

        [Column("project_id")]
        public string ProjectId { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("is_active")]
        public bool IsActive { get; set; }
        
        [Column("status")]
        public string Status { get; set; }
    }

    [Table("platforms")]
    public class Platform : BaseModel
    {
        [PrimaryKey("id")]
        public string Id { get; set; }

        [Column("name")]
        public string Name { get; set; }
    }

    [Table("experience_platform_packages")]
    public class ExperiencePlatformPackage : BaseModel
    {
        [PrimaryKey("id")]
        public string Id { get; set; }

        [Column("experience_id")]
        public string ExperienceId { get; set; }

        [Column("platform_id")]
        public string PlatformId { get; set; }

        [Column("bundle_url")]
        public string BundleUrl { get; set; }

        [Column("bundle_json")]
        public string BundleJson { get; set; }

        [Column("version")]
        public string Version { get; set; }

        [Column("file_size")]
        public long FileSize { get; set; }

        [Column("is_active")]
        public bool IsActive { get; set; }

        [Column("environment")]
        public string Environment { get; set; }
    }
}
