/******************************************************************************
**
** <auto-generated>
**     This code was generated by a tool: UaModeler
**     Runtime Version: 1.6.8, using .NET Server 3.2.0 template (version 0)
**
**     Changes to this file may cause incorrect behavior and will be lost if
**     the code is regenerated.
**
**     Generated by gresser <enrico.gresser@brand.de>
** </auto-generated>
**
** Copyright (c) 2006-2023 Unified Automation GmbH All rights reserved.
**
** Software License Agreement ("SLA") Version 2.8
**
** Unless explicitly acquired and licensed from Licensor under another
** license, the contents of this file are subject to the Software License
** Agreement ("SLA") Version 2.8, or subsequent versions
** as allowed by the SLA, and You may not copy or use this file in either
** source code or executable form, except in compliance with the terms and
** conditions of the SLA.
**
** All software distributed under the SLA is provided strictly on an
** "AS IS" basis, WITHOUT WARRANTY OF ANY KIND, EITHER EXPRESS OR IMPLIED,
** AND LICENSOR HEREBY DISCLAIMS ALL SUCH WARRANTIES, INCLUDING WITHOUT
** LIMITATION, ANY WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR
** PURPOSE, QUIET ENJOYMENT, OR NON-INFRINGEMENT. See the SLA for specific
** language governing rights and limitations under the SLA.
**
** Project: .NET OPC UA SDK information model for namespace http://opcfoundation.org/UA/AMB/
**
** Description: OPC Unified Architecture Software Development Kit.
**
** The complete license agreement can be found here:
** http://unifiedautomation.com/License/SLA/2.8/
**
** Created: 25.03.2023
**
******************************************************************************/

using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Xml;
using System.Linq;
using System.Runtime.Serialization;
using UnifiedAutomation.UaBase;
using System.Diagnostics;

namespace UnifiedAutomation.UaBase
{
    #region MaintenanceMethodEnum
    /// <summary>
    /// https://reference.opcfoundation.org/AMB/v100/docs/12.6
    /// </summary>
    [DataContract(Namespace = UnifiedAutomation.UaBase.Namespaces.UaBaseXsd)]
    public enum MaintenanceMethodEnum
    {
        /// <summary>
        /// Maintenance close to the asset
        /// </summary>
        [EnumMember(Value = "Local_0")]
        Local = 0,
        /// <summary>
        /// Maintenance from another location
        /// </summary>
        [EnumMember(Value = "Remote_1")]
        Remote = 1,
    }

    #region MaintenanceMethodEnumCollection Class
    /// <summary>
    /// A collection of MaintenanceMethodEnum objects.
    /// </summary>
    [CollectionDataContract]
    public partial class MaintenanceMethodEnumCollection : List<MaintenanceMethodEnum>, ICloneable
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public MaintenanceMethodEnumCollection() { }

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public MaintenanceMethodEnumCollection(int capacity) : base(capacity) { }

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public MaintenanceMethodEnumCollection(IEnumerable<MaintenanceMethodEnum> collection) : base(collection) { }
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator MaintenanceMethodEnumCollection(MaintenanceMethodEnum[] values)
        {
            if (values != null)
            {
                return new MaintenanceMethodEnumCollection(values);
            }

            return new MaintenanceMethodEnumCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator MaintenanceMethodEnum[](MaintenanceMethodEnumCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            MaintenanceMethodEnumCollection clone = new MaintenanceMethodEnumCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((MaintenanceMethodEnum)TypeUtils.Clone(this[ii]));
            }

            return clone;
        }
        #endregion
    }
    #endregion

    #endregion

    #region NameNodeIdDataType Class
    /// <summary>
    /// https://reference.opcfoundation.org/AMB/v100/docs/12.5
    /// </summary>
    [DataContract(Namespace = UnifiedAutomation.UaBase.Namespaces.UaBaseXsd)]
    public partial class NameNodeIdDataType : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public NameNodeIdDataType()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            m_Name = null;
            m_NodeId = null;
        }
        #endregion

        #region Public Properties

        /// <summary>
        /// </summary>
        [DataMember(Name = "Name", IsRequired = false, Order = 1)]
        public LocalizedText Name
        {
            get
            {
                return m_Name;
            }
            set
            {
                m_Name = value;
            }
        }

        /// <summary>
        /// </summary>
        [DataMember(Name = "NodeId", IsRequired = false, Order = 2)]
        public NodeId NodeId
        {
            get
            {
                return m_NodeId;
            }
            set
            {
                m_NodeId = value;
            }
        }

        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.NameNodeIdDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.NameNodeIdDataType_Encoding_DefaultBinary; }
        }
        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.NameNodeIdDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Namespaces.UaBaseXsd);

            encoder.WriteLocalizedText("Name", Name);
            encoder.WriteNodeId("NodeId", NodeId);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Namespaces.UaBaseXsd);
            Name = decoder.ReadLocalizedText("Name");
            NodeId = decoder.ReadNodeId("NodeId");

            decoder.PopNamespace();
        }

        /// <summary cref="EncodeableObject.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            NameNodeIdDataType value = encodeable as NameNodeIdDataType;

            if (value == null)
            {
                return false;
            }
            if (!TypeUtils.IsEqual(m_Name, value.m_Name)) return false;
            if (!TypeUtils.IsEqual(m_NodeId, value.m_NodeId)) return false;

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            NameNodeIdDataType clone = (NameNodeIdDataType)this.MemberwiseClone();

            clone.m_Name = (LocalizedText)TypeUtils.Clone(this.m_Name);
            clone.m_NodeId = (NodeId)TypeUtils.Clone(this.m_NodeId);

            return clone;
        }
        #endregion

        #region Private Fields
        private LocalizedText m_Name;
        private NodeId m_NodeId;
        #endregion
    }

    #region NameNodeIdDataTypeCollection class
    /// <summary>
    /// A collection of NameNodeIdDataType objects.
    /// </summary>
    [CollectionDataContract(Name = "ListOfNameNodeIdDataType", Namespace = UnifiedAutomation.UaBase.Namespaces.UaBase, ItemName = "NameNodeIdDataType")]
    public partial class NameNodeIdDataTypeCollection : List<NameNodeIdDataType>, ICloneable
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public NameNodeIdDataTypeCollection() { }

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public NameNodeIdDataTypeCollection(int capacity) : base(capacity) { }

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public NameNodeIdDataTypeCollection(IEnumerable<NameNodeIdDataType> collection) : base(collection) { }
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator NameNodeIdDataTypeCollection(NameNodeIdDataType[] values)
        {
            if (values != null)
            {
                return new NameNodeIdDataTypeCollection(values);
            }

            return new NameNodeIdDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator NameNodeIdDataType[](NameNodeIdDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            NameNodeIdDataTypeCollection clone = new NameNodeIdDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((NameNodeIdDataType)TypeUtils.Clone(this[ii]));
            }

            return clone;
        }
        #endregion
    }
    #endregion
    #endregion

    #region RootCauseDataType Class
    /// <summary>
    /// https://reference.opcfoundation.org/AMB/v100/docs/9.4.3
    /// </summary>
    [DataContract(Namespace = UnifiedAutomation.UaBase.Namespaces.UaBaseXsd)]
    public partial class RootCauseDataType : IEncodeable
    {
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public RootCauseDataType()
        {
            Initialize();
        }

        [OnDeserializing]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private void Initialize()
        {
            m_RootCauseId = null;
            m_RootCause = null;
        }
        #endregion

        #region Public Properties

        /// <summary>
        /// </summary>
        [DataMember(Name = "RootCauseId", IsRequired = false, Order = 1)]
        public NodeId RootCauseId
        {
            get
            {
                return m_RootCauseId;
            }
            set
            {
                m_RootCauseId = value;
            }
        }

        /// <summary>
        /// </summary>
        [DataMember(Name = "RootCause", IsRequired = false, Order = 2)]
        public LocalizedText RootCause
        {
            get
            {
                return m_RootCause;
            }
            set
            {
                m_RootCause = value;
            }
        }

        #endregion

        #region IEncodeable Members
        /// <summary cref="IEncodeable.TypeId" />
        public virtual ExpandedNodeId TypeId
        {
            get { return DataTypeIds.RootCauseDataType; }
        }

        /// <summary cref="IEncodeable.BinaryEncodingId" />
        public virtual ExpandedNodeId BinaryEncodingId
        {
            get { return ObjectIds.RootCauseDataType_Encoding_DefaultBinary; }
        }
        /// <summary cref="IEncodeable.XmlEncodingId" />
        public virtual ExpandedNodeId XmlEncodingId
        {
            get { return ObjectIds.RootCauseDataType_Encoding_DefaultXml; }
        }

        /// <summary cref="IEncodeable.Encode(IEncoder)" />
        public virtual void Encode(IEncoder encoder)
        {
            encoder.PushNamespace(Namespaces.UaBaseXsd);

            encoder.WriteNodeId("RootCauseId", RootCauseId);
            encoder.WriteLocalizedText("RootCause", RootCause);

            encoder.PopNamespace();
        }

        /// <summary cref="IEncodeable.Decode(IDecoder)" />
        public virtual void Decode(IDecoder decoder)
        {
            decoder.PushNamespace(Namespaces.UaBaseXsd);
            RootCauseId = decoder.ReadNodeId("RootCauseId");
            RootCause = decoder.ReadLocalizedText("RootCause");

            decoder.PopNamespace();
        }

        /// <summary cref="EncodeableObject.IsEqual(IEncodeable)" />
        public virtual bool IsEqual(IEncodeable encodeable)
        {
            if (Object.ReferenceEquals(this, encodeable))
            {
                return true;
            }

            RootCauseDataType value = encodeable as RootCauseDataType;

            if (value == null)
            {
                return false;
            }
            if (!TypeUtils.IsEqual(m_RootCauseId, value.m_RootCauseId)) return false;
            if (!TypeUtils.IsEqual(m_RootCause, value.m_RootCause)) return false;

            return true;
        }

        /// <summary cref="ICloneable.Clone" />
        public virtual object Clone()
        {
            RootCauseDataType clone = (RootCauseDataType)this.MemberwiseClone();

            clone.m_RootCauseId = (NodeId)TypeUtils.Clone(this.m_RootCauseId);
            clone.m_RootCause = (LocalizedText)TypeUtils.Clone(this.m_RootCause);

            return clone;
        }
        #endregion

        #region Private Fields
        private NodeId m_RootCauseId;
        private LocalizedText m_RootCause;
        #endregion
    }

    #region RootCauseDataTypeCollection class
    /// <summary>
    /// A collection of RootCauseDataType objects.
    /// </summary>
    [CollectionDataContract(Name = "ListOfRootCauseDataType", Namespace = UnifiedAutomation.UaBase.Namespaces.UaBase, ItemName = "RootCauseDataType")]
    public partial class RootCauseDataTypeCollection : List<RootCauseDataType>, ICloneable
    {
        #region Constructors
        /// <summary>
        /// Initializes the collection with default values.
        /// </summary>
        public RootCauseDataTypeCollection() { }

        /// <summary>
        /// Initializes the collection with an initial capacity.
        /// </summary>
        public RootCauseDataTypeCollection(int capacity) : base(capacity) { }

        /// <summary>
        /// Initializes the collection with another collection.
        /// </summary>
        public RootCauseDataTypeCollection(IEnumerable<RootCauseDataType> collection) : base(collection) { }
        #endregion

        #region Static Operators
        /// <summary>
        /// Converts an array to a collection.
        /// </summary>
        public static implicit operator RootCauseDataTypeCollection(RootCauseDataType[] values)
        {
            if (values != null)
            {
                return new RootCauseDataTypeCollection(values);
            }

            return new RootCauseDataTypeCollection();
        }

        /// <summary>
        /// Converts a collection to an array.
        /// </summary>
        public static explicit operator RootCauseDataType[](RootCauseDataTypeCollection values)
        {
            if (values != null)
            {
                return values.ToArray();
            }

            return null;
        }
        #endregion

        #region ICloneable Methods
        /// <summary>
        /// Creates a deep copy of the collection.
        /// </summary>
        public object Clone()
        {
            RootCauseDataTypeCollection clone = new RootCauseDataTypeCollection(this.Count);

            for (int ii = 0; ii < this.Count; ii++)
            {
                clone.Add((RootCauseDataType)TypeUtils.Clone(this[ii]));
            }

            return clone;
        }
        #endregion
    }
    #endregion
    #endregion


    #region EncodeableTypes
    /// <summary>
    /// Contains a method for registering all encodeable types of the namespace.
    /// </summary>
    public class EncodeableTypes
    {
        /// <summary>
        /// Register all encodeable types of the namespace at the communication stack.
        /// The Decoder will decode the registered types.
        /// </summary>
        public static void RegisterEncodeableTypes(MessageContext context)
        {
            context.Factory.AddEncodeableType(typeof(UnifiedAutomation.UaBase.NameNodeIdDataType));
            context.Factory.AddEncodeableType(typeof(UnifiedAutomation.UaBase.RootCauseDataType));
        }
    }
    #endregion
}