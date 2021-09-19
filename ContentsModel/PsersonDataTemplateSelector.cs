using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ContentsModel {
    class PsersonDataTemplateSelector : DataTemplateSelector {
        public override DataTemplate SelectTemplate(object item, DependencyObject container) {
            var P = (Person)item;
            if (P.Age < 40) {
                return (DataTemplate)((FrameworkElement)container).FindResource("PersonTemplate1");
            } else {
                return (DataTemplate)((FrameworkElement)container).FindResource("PersonTemplate2");
            }
        }
    }
}
