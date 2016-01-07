﻿using Microsoft.Xrm.Sdk.Metadata;
using MsCrmTools.MetadataBrowser.AppCode.OptionSetMd;
using System.ComponentModel;

namespace MsCrmTools.MetadataBrowser.AppCode.AttributeMd
{
    public class PicklistAttributeMetadataInfo : AttributeMetadataInfo
    {
        private readonly PicklistAttributeMetadata amd;

        public PicklistAttributeMetadataInfo(PicklistAttributeMetadata amd)
            : base(amd)
        {
            this.amd = amd;
        }

        public int DefaultFormValue
        {
            get { return amd.DefaultFormValue.Value; }
        }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public OptionSetMetadataInfo OptionSet
        {
            get { return new OptionSetMetadataInfo(amd.OptionSet); }
        }
    }
}