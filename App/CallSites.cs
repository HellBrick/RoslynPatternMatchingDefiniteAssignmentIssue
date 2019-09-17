namespace App
{
	internal class CallSites
	{
		private static string ExternalStringPropCallSite(Lib.StructWithStringProp? nullable)
		{
			bool flag = nullable is Lib.StructWithStringProp notNull;
			return flag ? notNull.ToString() : "";
		}

		private static string ExternalIntFieldCallSite(Lib.StructWithIntField? nullable)
		{
			bool flag = nullable is Lib.StructWithIntField notNull;
			return flag ? notNull.ToString() : "";
		}

		private static string ExternalIntPropCallSite(Lib.StructWithIntProp? nullable)
		{
			bool flag = nullable is Lib.StructWithIntProp notNull;
			return flag ? notNull.ToString() : "";
		}

		private static string ExternalStringFieldCallSite(Lib.StructWithStringField? nullable)
		{
			bool flag = nullable is Lib.StructWithStringField notNull;
			return flag ? notNull.ToString() : "";
		}

		private static string ExternalEmptyStructFieldCallSite( Lib.EmptyStruct? nullable )
		{
			bool flag = nullable is Lib.EmptyStruct notNull;
			return flag ? notNull.ToString() : "";
		}

		private static string InternalStringPropCallSite(App.StructWithStringProp? nullable)
		{
			bool flag = nullable is App.StructWithStringProp notNull;
			return flag ? notNull.ToString() : "";
		}

		private static string InternalIntFieldCallSite(App.StructWithIntField? nullable)
		{
			bool flag = nullable is App.StructWithIntField notNull;
			return flag ? notNull.ToString() : "";
		}

		private static string InternalIntPropCallSite(App.StructWithIntProp? nullable)
		{
			bool flag = nullable is App.StructWithIntProp notNull;
			return flag ? notNull.ToString() : "";
		}

		private static string InternalStringFieldCallSite(App.StructWithStringField? nullable)
		{
			bool flag = nullable is App.StructWithStringField notNull;
			return flag ? notNull.ToString() : "";
		}

		private static string InternalEmptyStructFieldCallSite( App.EmptyStruct? nullable )
		{
			bool flag = nullable is App.EmptyStruct notNull;
			return flag ? notNull.ToString() : "";
		}
	}
}
