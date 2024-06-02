namespace Stock.API.Dtos;

public class CommentDto
{
    public int Id { get; set; }
    
    public string Title { get; set; } = string.Empty;
    
    public string Content { get; set; } = string.Empty;
    
    public DateTime CreatedOn { get; set; } = DateTime.Now;
    
    //navigation property
    public int? StockId { get; set; }
    
}