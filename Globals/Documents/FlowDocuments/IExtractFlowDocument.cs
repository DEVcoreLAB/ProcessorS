using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows;

namespace Globals.Documents.FlowDocuments
{
    public interface IExtractFlowDocument
    {
        public FlowDocument Extract(DependencyObject parent);
    }
}
