﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewPlatform.Flexberry.ServiceBus
{
    using System;
    using System.Xml;
    
    
    // *** Start programmer edit section *** (Using statements)
    using System.Runtime.Serialization;
    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// NameCommentStruct.
    /// </summary>
    // *** Start programmer edit section *** (NameCommentStruct CustomAttributes)
    [DataContract(Namespace = "http://schemas.datacontract.org/2004/07/IIS.Persona.ServiceBus.Objects")]
    // *** End programmer edit section *** (NameCommentStruct CustomAttributes)
    public class NameCommentStruct
    {
        
        private string fId;
        
        private string fName;
        
        private string fComment;
        
        // *** Start programmer edit section *** (NameCommentStruct CustomMembers)

        // *** End programmer edit section *** (NameCommentStruct CustomMembers)

        
        /// <summary>
        /// Id.
        /// </summary>
        // *** Start programmer edit section *** (NameCommentStruct.Id CustomAttributes)
        [DataMember(Name = "id")]
        // *** End programmer edit section *** (NameCommentStruct.Id CustomAttributes)
        public virtual string Id
        {
            get
            {
                // *** Start programmer edit section *** (NameCommentStruct.Id Get start)

                // *** End programmer edit section *** (NameCommentStruct.Id Get start)
                string result = this.fId;
                // *** Start programmer edit section *** (NameCommentStruct.Id Get end)

                // *** End programmer edit section *** (NameCommentStruct.Id Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (NameCommentStruct.Id Set start)

                // *** End programmer edit section *** (NameCommentStruct.Id Set start)
                this.fId = value;
                // *** Start programmer edit section *** (NameCommentStruct.Id Set end)

                // *** End programmer edit section *** (NameCommentStruct.Id Set end)
            }
        }
        
        /// <summary>
        /// Name.
        /// </summary>
        // *** Start programmer edit section *** (NameCommentStruct.Name CustomAttributes)
        [DataMember(Name = "name")]
        // *** End programmer edit section *** (NameCommentStruct.Name CustomAttributes)
        public virtual string Name
        {
            get
            {
                // *** Start programmer edit section *** (NameCommentStruct.Name Get start)

                // *** End programmer edit section *** (NameCommentStruct.Name Get start)
                string result = this.fName;
                // *** Start programmer edit section *** (NameCommentStruct.Name Get end)

                // *** End programmer edit section *** (NameCommentStruct.Name Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (NameCommentStruct.Name Set start)

                // *** End programmer edit section *** (NameCommentStruct.Name Set start)
                this.fName = value;
                // *** Start programmer edit section *** (NameCommentStruct.Name Set end)

                // *** End programmer edit section *** (NameCommentStruct.Name Set end)
            }
        }
        
        /// <summary>
        /// Comment.
        /// </summary>
        // *** Start programmer edit section *** (NameCommentStruct.Comment CustomAttributes)
        [DataMember(Name = "comment")]
        // *** End programmer edit section *** (NameCommentStruct.Comment CustomAttributes)
        public virtual string Comment
        {
            get
            {
                // *** Start programmer edit section *** (NameCommentStruct.Comment Get start)

                // *** End programmer edit section *** (NameCommentStruct.Comment Get start)
                string result = this.fComment;
                // *** Start programmer edit section *** (NameCommentStruct.Comment Get end)

                // *** End programmer edit section *** (NameCommentStruct.Comment Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (NameCommentStruct.Comment Set start)

                // *** End programmer edit section *** (NameCommentStruct.Comment Set start)
                this.fComment = value;
                // *** Start programmer edit section *** (NameCommentStruct.Comment Set end)

                // *** End programmer edit section *** (NameCommentStruct.Comment Set end)
            }
        }
    }
}
