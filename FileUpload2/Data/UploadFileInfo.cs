using System.ComponentModel.DataAnnotations;

namespace FileUpload2.Data
{
    public class UploadFileInfo
    {
        [Key]
        public int FileId { get; set; }
        public string? FileName { get; set; }
        public byte[]? File { get; set; }
        public string? ContentType { get; set; }
        public string? Base64File { get; set; }

    }
}
