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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,206,207,77,85,72,206,79,73,85,200,72,45,74,213,3,1,0,118,39,119,161,19,0,0,0 };
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

