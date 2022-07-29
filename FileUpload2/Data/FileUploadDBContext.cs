using Microsoft.EntityFrameworkCore;


namespace FileUpload2.Data
{
    public class FileUploadDBContext: DbContext
    {
        public FileUploadDBContext(DbContextOptions<FileUploadDBContext> options) : base(options)
        {

        }
        public DbSet<UploadFileInfo> UploadFileInfos { get; set; } = null!;
    }
}
