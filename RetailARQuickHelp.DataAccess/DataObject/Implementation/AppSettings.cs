﻿using System;
using System.Collections.Generic;
using System.Xml.Linq;
using RetailARQuickHelp.DataAccess.DataManager.Extension;

namespace RetailARQuickHelp.DataAccess.DataObject.Implementation
{
    /// <summary>
    /// AppSettings object
    /// </summary>
    public class AppSettings : Entity
    {
        public string Key { get; set; }
        public string Value { get; set; }

        protected override void CreateObjectFromXml(XElement xml)
        {
            this.Id = xml.Attribute("Id").ToType<int>();
            this.Key = xml.Attribute("Key").ToType<string>();
            this.Value = xml.Attribute("Value").ToType<string>();

            this.CreatedOn = xml.Attribute("CreatedOn").ToType<DateTime>();
            this.ModifiedOn = xml.Attribute("ModifiedOn").ToType<DateTime>();
        }
    }
}
