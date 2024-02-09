namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrRealtyClassicEventsSchema

	/// <exclude/>
	public class UsrRealtyClassicEventsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrRealtyClassicEventsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrRealtyClassicEventsSchema(UsrRealtyClassicEventsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("62b3b412-3fa4-4d75-bc14-903ebd4d3b50");
			Name = "UsrRealtyClassicEvents";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e3b55088-2140-410e-86c6-9b439b43a15e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,193,106,220,48,16,189,7,242,15,131,233,193,134,69,36,215,166,13,212,203,54,4,66,27,178,78,47,165,7,173,60,235,168,200,146,209,200,155,110,75,254,189,35,203,219,108,236,20,50,23,73,163,55,111,230,61,198,202,22,169,147,10,161,66,239,37,185,109,16,75,103,183,186,233,189,12,218,217,211,147,63,167,39,192,209,147,182,13,172,247,20,176,189,56,78,29,23,182,173,179,255,253,244,40,86,54,232,160,145,222,130,17,171,29,218,112,128,126,31,210,251,33,119,163,121,8,139,62,95,171,7,108,229,23,214,0,31,33,187,39,127,135,210,132,253,210,72,34,173,178,226,71,170,237,250,141,209,10,84,76,67,130,188,194,6,239,161,148,132,175,252,36,150,209,135,35,66,183,227,201,117,141,176,115,186,134,175,118,45,119,172,39,119,155,159,168,2,16,218,26,253,2,18,97,137,91,22,55,208,126,242,13,1,22,207,116,71,204,49,54,60,133,248,199,118,160,193,226,226,37,44,241,130,31,244,176,254,60,37,138,84,48,1,215,168,116,43,13,116,94,171,104,86,170,18,87,24,170,125,135,245,210,153,190,181,223,164,233,241,195,8,189,204,163,161,183,17,127,85,222,102,211,238,122,11,121,34,187,132,243,179,67,20,47,65,19,97,49,80,92,211,82,90,133,6,107,158,35,248,30,153,121,142,163,224,227,110,240,118,146,108,176,194,182,51,50,196,201,45,62,194,141,83,210,232,223,114,99,112,61,224,242,81,207,61,161,231,245,181,236,63,239,174,184,67,114,189,87,12,114,158,89,22,243,54,49,102,139,147,22,47,91,64,54,107,68,98,48,233,154,42,231,74,221,164,87,86,136,202,141,131,20,111,80,195,42,82,66,124,118,190,149,33,159,168,228,198,231,226,172,124,55,51,61,70,120,240,238,113,112,97,245,75,97,23,117,30,234,167,240,167,231,231,120,229,227,233,47,18,203,70,128,243,3,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("8166fad8-cb37-9fb8-6018-bb71ff508220"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("e3b55088-2140-410e-86c6-9b439b43a15e"),
				CreatedInSchemaUId = new Guid("62b3b412-3fa4-4d75-bc14-903ebd4d3b50"),
				ModifiedInSchemaUId = new Guid("62b3b412-3fa4-4d75-bc14-903ebd4d3b50")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("62b3b412-3fa4-4d75-bc14-903ebd4d3b50"));
		}

		#endregion

	}

	#endregion

}

