using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TodoApi.Models;
[BsonIgnoreExtraElements]
public class Todo
{
  [BsonId]
  [BsonRepresentation(BsonType.ObjectId)]
  public string? Id { get; set; }
  public string Title { get; set; } = null!;
  public string Note { get; set; } = String.Empty;
  public string Date { get; set; } = null!;

  public Boolean isComplete { get; set; } = false;
}