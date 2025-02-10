using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Globals.Reflection.TypeWithProperties.PropertyAsType.Builder
{
    internal class SimplePropertyGenerator
    {
        public static void CreateAutoImplementedProperty(TypeBuilder builder, string propertyName, Type propertyType)
        {
            const MethodAttributes getSetAttr = MethodAttributes.Public | MethodAttributes.SpecialName | MethodAttributes.HideBySig;

            // Definicja właściwości w dynamicznym typie
            var propertyBuilder = builder.DefineProperty(propertyName, PropertyAttributes.HasDefault, propertyType, null);

            var backingField = CreateBackingField(builder, propertyName, propertyType);

            // Definicja metody "get"
            var getPropMthdBldr = builder.DefineMethod($"get_{propertyName}", getSetAttr, propertyType, Type.EmptyTypes);
            var getIL = getPropMthdBldr.GetILGenerator();
            getIL.Emit(OpCodes.Ldarg_0);
            getIL.Emit(OpCodes.Ldfld, backingField);
            getIL.Emit(OpCodes.Ret);
            propertyBuilder.SetGetMethod(getPropMthdBldr);

            // Definicja metody "set"
            var setPropMthdBldr = builder.DefineMethod($"set_{propertyName}", getSetAttr, null, new Type[] { propertyType });
            var setIL = setPropMthdBldr.GetILGenerator();
            setIL.Emit(OpCodes.Ldarg_0);
            setIL.Emit(OpCodes.Ldarg_1);
            setIL.Emit(OpCodes.Stfld, backingField);
            setIL.Emit(OpCodes.Ret);
            propertyBuilder.SetSetMethod(setPropMthdBldr);
        }

        private static FieldBuilder CreateBackingField(TypeBuilder builder, string fieldName, Type type)
        {
            return builder.DefineField($"<{fieldName}>k__BackingField", type, FieldAttributes.Private);
        }
    }
}
