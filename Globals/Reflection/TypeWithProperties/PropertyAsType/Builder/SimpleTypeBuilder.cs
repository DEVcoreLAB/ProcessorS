using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Globals.Reflection.TypeWithProperties.PropertyAsType.Builder
{
    internal class SimpleTypeBuilder
    {
        public SimpleTypeBuilder()
        {
            CreateTypeBuilder();
        }

        private string assemblyName = "MyDynamicAssembly";
        private string moduleName = "MyDynamicModule";
        private string typeName = "MyDynamicType";

        public TypeBuilder _typeBuilder { get; private set; }

        private void CreateTypeBuilder()
        {
            var assemblyBuilder = AssemblyBuilder.DefineDynamicAssembly(new AssemblyName(assemblyName), AssemblyBuilderAccess.Run);
            var moduleBuilder = assemblyBuilder.DefineDynamicModule(moduleName);
            var typeBuilder = moduleBuilder.DefineType(typeName, TypeAttributes.Public);
            _typeBuilder = typeBuilder;
        }
    }
}
