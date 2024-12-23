using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Markup;
using System.Xml;

namespace Globals.Documents.FlowDocumentinXAML.FlowDocumentExtractor
{
    public class BasicFlowDocumentExtractor : IExtractor
    {
        public FlowDocument Extract(DependencyObject parent)
        {
            foreach (var child in LogicalTreeHelper.GetChildren(parent))
            {
                if (child is DependencyObject depChild)
                {
                    if (depChild is FlowDocumentScrollViewer scrollViewer)
                    {
                        return CloneFlowDocument(scrollViewer.Document);
                    }
                    else if (depChild is FlowDocumentPageViewer pageViewer)
                    {
                        return CloneFlowDocument((FlowDocument)pageViewer.Document);
                    }
                    else
                    {
                        FlowDocument subDocument = Extract(depChild);
                        if (subDocument != null)
                        {
                            return CloneFlowDocument(subDocument);
                        }
                    }
                }
            }
            return null;
        }

        private FlowDocument CloneFlowDocument(FlowDocument original)
        {
            if (original == null)
                return null;

            string xaml = XamlWriter.Save(original);
            StringReader stringReader = new StringReader(xaml);
            XmlReader xmlReader = XmlReader.Create(stringReader);
            return (FlowDocument)XamlReader.Load(xmlReader);
        }
    }
}
