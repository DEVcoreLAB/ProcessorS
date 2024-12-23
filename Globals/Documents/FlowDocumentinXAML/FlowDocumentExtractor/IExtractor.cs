using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows;

namespace Globals.Documents.FlowDocumentinXAML.FlowDocumentExtractor
{
    public interface IExtractor
    {
        public FlowDocument Extract(DependencyObject parent);
    }
}
