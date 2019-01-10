using Prism.Mvvm;

namespace BookViewer.Models
{
    public class Page : IPage
    {
        public int ChapterNo { get; }
        public int PageNo { get; }
        public string Text { get; }

        public Page(int chapterNo, int pageNo, string text)
        {
            ChapterNo = chapterNo;
            PageNo = pageNo;
            Text = text;
        }
    }
}