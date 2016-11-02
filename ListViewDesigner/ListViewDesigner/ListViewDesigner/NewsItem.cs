using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewDesigner
{
    public class NewsItem : MvvmHelpers.ObservableObject
    {
        private string title;
        private string articleAbstract;
        private string imageSource;

        public string Title {
            get { return title; }
            set
            {
                SetProperty(ref title, value);
            }
        } 

        public string ArticleAbstract
        {
            get { return articleAbstract; }
            set
            {
                SetProperty(ref articleAbstract, value);
            }
        }

        public string ImageSource
                {
            get { return imageSource; }
    set
            {
                SetProperty(ref imageSource, value);
}
        }

    }
}
