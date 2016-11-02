using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewDesigner
{
    public class NewsViewModel
    {
        public ObservableCollection<NewsItem> newsItems = new ObservableCollection<NewsItem>();

        public ObservableCollection<NewsItem> NewsItems
        { get { return newsItems; } set { newsItems = value; } }

        public NewsViewModel()
        {
            // generate fake data
            NewsItems = new ObservableCollection<NewsItem>();
            NewsItems.Add(new NewsItem() { Title = "News Item 1", ArticleAbstract = "Some Abstract", ImageSource = "https://pbs.twimg.com/profile_images/639237876920651776/MZ9HIVj-.jpg" });

        }

    }
}
