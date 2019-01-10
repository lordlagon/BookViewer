using System.Collections.Generic;

namespace BookViewer.Models
{
    public class Chapter : IChapter
    {
        public int ChapterNo { get; }
        public string Title { get; }
        public IList<IPage> Pages { get; }

        public Chapter(int chapterNo)
        {
            ChapterNo = chapterNo;
            Title = $"Chapter-{chapterNo}";
            Pages = GetNewPages();
        }

        public List<IPage> GetNewPages(){

           List<IPage> Lista =
                new List<IPage>() {
                new Page(1,1,"1 You should see 4 lines of text and truncation at the end. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam mattis quam non enim pellentesque, ut placerat purus finibus. Nulla quis tincidunt ante. Ut mauris lectus, aliquam a sagittis vitae, consequat eget elit. Interdum et malesuada fames ac ante ipsum primis in faucibus. Pellentesque convallis nunc nisi, a imperdiet elit efficitur et. Duis in lectus mollis, interdum ipsum et, tincidunt orci. Fusce ipsum metus, imperdiet non lacus vitae, facilisis feugiat magna. Nulla volutpat nisl tortor, a consectetur felis consectetur non. Curabitur in enim vulputate sem volutpat bibendum id nec lorem. Mauris laoreet lacus ac volutpat tempus."),
                new Page(1,2,"2 You should see 4 lines of text and truncation at the end. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam mattis quam non enim pellentesque, ut placerat purus finibus. Nulla quis tincidunt ante. Ut mauris lectus, aliquam a sagittis vitae, consequat eget elit. Interdum et malesuada fames ac ante ipsum primis in faucibus. Pellentesque convallis nunc nisi, a imperdiet elit efficitur et. Duis in lectus mollis, interdum ipsum et, tincidunt orci. Fusce ipsum metus, imperdiet non lacus vitae, facilisis feugiat magna. Nulla volutpat nisl tortor, a consectetur felis consectetur non. Curabitur in enim vulputate sem volutpat bibendum id nec lorem. Mauris laoreet lacus ac volutpat tempus."),
                new Page(2,1,"3 You should see 4 lines of text and truncation at the end. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam mattis quam non enim pellentesque, ut placerat purus finibus. Nulla quis tincidunt ante. Ut mauris lectus, aliquam a sagittis vitae, consequat eget elit. Interdum et malesuada fames ac ante ipsum primis in faucibus. Pellentesque convallis nunc nisi, a imperdiet elit efficitur et. Duis in lectus mollis, interdum ipsum et, tincidunt orci. Fusce ipsum metus, imperdiet non lacus vitae, facilisis feugiat magna. Nulla volutpat nisl tortor, a consectetur felis consectetur non. Curabitur in enim vulputate sem volutpat bibendum id nec lorem. Mauris laoreet lacus ac volutpat tempus."),
                new Page(2,2,"4 You should see 4 lines of text and truncation at the end. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam mattis quam non enim pellentesque, ut placerat purus finibus. Nulla quis tincidunt ante. Ut mauris lectus, aliquam a sagittis vitae, consequat eget elit. Interdum et malesuada fames ac ante ipsum primis in faucibus. Pellentesque convallis nunc nisi, a imperdiet elit efficitur et. Duis in lectus mollis, interdum ipsum et, tincidunt orci. Fusce ipsum metus, imperdiet non lacus vitae, facilisis feugiat magna. Nulla volutpat nisl tortor, a consectetur felis consectetur non. Curabitur in enim vulputate sem volutpat bibendum id nec lorem. Mauris laoreet lacus ac volutpat tempus."),
                new Page(3,1,"5 You should see 4 lines of text and truncation at the end. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam mattis quam non enim pellentesque, ut placerat purus finibus. Nulla quis tincidunt ante. Ut mauris lectus, aliquam a sagittis vitae, consequat eget elit. Interdum et malesuada fames ac ante ipsum primis in faucibus. Pellentesque convallis nunc nisi, a imperdiet elit efficitur et. Duis in lectus mollis, interdum ipsum et, tincidunt orci. Fusce ipsum metus, imperdiet non lacus vitae, facilisis feugiat magna. Nulla volutpat nisl tortor, a consectetur felis consectetur non. Curabitur in enim vulputate sem volutpat bibendum id nec lorem. Mauris laoreet lacus ac volutpat tempus."),

            };

            return Lista;
}
    }
}