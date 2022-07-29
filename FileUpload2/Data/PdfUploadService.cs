


using Microsoft.EntityFrameworkCore;

namespace FileUpload2.Data
{
    public class PdfUploadService
    {
        private readonly IDbContextFactory<FileUploadDBContext> _contextFactory;
        public PdfUploadService(IDbContextFactory<FileUploadDBContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }
        public async Task UploadFiles(IList<UploadFileInfo> fileInfos)
        {
            using(var _context = _contextFactory.CreateDbContext())
            {
                foreach (var file in fileInfos)
                {
                    if (file.FileId == 0)
                    {
                        _context.UploadFileInfos.Add(file);
                    }
                }
                await _context.SaveChangesAsync();
            }
        }
        public async Task<IList<UploadFileInfo>> GetUploadFiles()
        {
            using (var _context = _contextFactory.CreateDbContext())
            {
                var uploadFiles = await _context.UploadFileInfos.ToListAsync();
                return uploadFiles;
            }
        }
        public async Task DeleteFiles(int id)
        {
            using (var _context = _contextFactory.CreateDbContext())
            {
                var file = _context.UploadFileInfos.SingleOrDefault(x=>x.FileId == id);
                _context.UploadFileInfos.Remove(file);
                await _context.SaveChangesAsync();
            }
        }

    }
}
