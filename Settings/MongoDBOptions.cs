using System.ComponentModel.DataAnnotations;

namespace TodoApi.Settings
{
  public class MongoDBOptions
  {
    public const string Config = "MongoDB";

    [Required]
    public string DatabaseName { get; set; } = "todoDatabase";

    [Required]
    public string ConnectionString { get; set; } = "mongodb+srv://kubak:1q2w3e@cluster0.adj9u.mongodb.net/test?authSource=admin&replicaSet=atlas-kepv8d-shard-0&readPreference=primary&appname=MongoDB%20Compass&ssl=true";
  }
}