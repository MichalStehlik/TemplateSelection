using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace TemplateSelection.ViewModels
{
    class PersonTemplateSelector: DataTemplateSelector
    {
        protected override DataTemplate SelectTemplateCore(object item, DependencyObject dependency)
        {
            if (item is Models.Teacher)
                return TeacherTemplate;
            else if (item is Models.Student)
                return StudentTemplate;
            else
                return HumanTemplate;
        }

        public DataTemplate TeacherTemplate { get; set; }
        public DataTemplate StudentTemplate { get; set; }
        public DataTemplate HumanTemplate { get; set; }
    }
}
