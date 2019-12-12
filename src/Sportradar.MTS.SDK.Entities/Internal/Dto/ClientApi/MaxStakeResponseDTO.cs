/*
 * Copyright (C) Sportradar AG. See LICENSE for full license governing this code
 */

//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v8.6.6263.34621 (http://NJsonSchema.org)
// </auto-generated>
//----------------------

namespace Sportradar.MTS.SDK.Entities.Internal.Dto.ClientApi
{
#pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "8.6.6263.34621")]
    public partial class MaxStakeResponseDTO : System.ComponentModel.INotifyPropertyChanged
    {
        private string _ticketId;
        private long _maxStake;
        private long _timestampUtc;

        /// <summary>Ticket ID (from the original response)</summary>
        [Newtonsoft.Json.JsonProperty("ticketId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TicketId
        {
            get { return _ticketId; }
            set
            {
                if (_ticketId != value)
                {
                    _ticketId = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Maximum reoffer stake (quantity multiplied by 10000 and rounded to a long value)</summary>
        [Newtonsoft.Json.JsonProperty("maxStake", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long MaxStake
        {
            get { return _maxStake; }
            set
            {
                if (_maxStake != value)
                {
                    _maxStake = value;
                    RaisePropertyChanged();
                }
            }
        }

        [Newtonsoft.Json.JsonProperty("timestampUtc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long TimestampUtc
        {
            get { return _timestampUtc; }
            set
            {
                if (_timestampUtc != value)
                {
                    _timestampUtc = value;
                    RaisePropertyChanged();
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static MaxStakeResponseDTO FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<MaxStakeResponseDTO>(data);
        }

        protected virtual void RaisePropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    }
}
