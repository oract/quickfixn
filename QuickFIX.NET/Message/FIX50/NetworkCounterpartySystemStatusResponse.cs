// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX50 
    {
        public class NetworkCounterpartySystemStatusResponse : Message
        {
            public const string MsgType = "BD";

            public NetworkCounterpartySystemStatusResponse() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("BD"));
            }

            public NetworkCounterpartySystemStatusResponse(
                    QuickFix.Fields.NetworkStatusResponseType aNetworkStatusResponseType,
                    QuickFix.Fields.NetworkResponseID aNetworkResponseID
                ) : this()
            {
                this.networkStatusResponseType = aNetworkStatusResponseType;
                this.networkResponseID = aNetworkResponseID;
            }

            public QuickFix.Fields.NetworkStatusResponseType networkStatusResponseType
            { 
                get 
                {
                    QuickFix.Fields.NetworkStatusResponseType val = new QuickFix.Fields.NetworkStatusResponseType();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NetworkStatusResponseType val) 
            { 
                this.networkStatusResponseType = val;
            }
            
            public QuickFix.Fields.NetworkStatusResponseType Get(QuickFix.Fields.NetworkStatusResponseType val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NetworkStatusResponseType val) 
            { 
                return IsSetNetworkStatusResponseType();
            }
            
            public bool IsSetNetworkStatusResponseType() 
            { 
                return IsSetField(Tags.NetworkStatusResponseType);
            }
            public QuickFix.Fields.NetworkRequestID networkRequestID
            { 
                get 
                {
                    QuickFix.Fields.NetworkRequestID val = new QuickFix.Fields.NetworkRequestID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NetworkRequestID val) 
            { 
                this.networkRequestID = val;
            }
            
            public QuickFix.Fields.NetworkRequestID Get(QuickFix.Fields.NetworkRequestID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NetworkRequestID val) 
            { 
                return IsSetNetworkRequestID();
            }
            
            public bool IsSetNetworkRequestID() 
            { 
                return IsSetField(Tags.NetworkRequestID);
            }
            public QuickFix.Fields.NetworkResponseID networkResponseID
            { 
                get 
                {
                    QuickFix.Fields.NetworkResponseID val = new QuickFix.Fields.NetworkResponseID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NetworkResponseID val) 
            { 
                this.networkResponseID = val;
            }
            
            public QuickFix.Fields.NetworkResponseID Get(QuickFix.Fields.NetworkResponseID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NetworkResponseID val) 
            { 
                return IsSetNetworkResponseID();
            }
            
            public bool IsSetNetworkResponseID() 
            { 
                return IsSetField(Tags.NetworkResponseID);
            }
            public QuickFix.Fields.LastNetworkResponseID lastNetworkResponseID
            { 
                get 
                {
                    QuickFix.Fields.LastNetworkResponseID val = new QuickFix.Fields.LastNetworkResponseID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.LastNetworkResponseID val) 
            { 
                this.lastNetworkResponseID = val;
            }
            
            public QuickFix.Fields.LastNetworkResponseID Get(QuickFix.Fields.LastNetworkResponseID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.LastNetworkResponseID val) 
            { 
                return IsSetLastNetworkResponseID();
            }
            
            public bool IsSetLastNetworkResponseID() 
            { 
                return IsSetField(Tags.LastNetworkResponseID);
            }
            public QuickFix.Fields.NoCompIDs noCompIDs
            { 
                get 
                {
                    QuickFix.Fields.NoCompIDs val = new QuickFix.Fields.NoCompIDs();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoCompIDs val) 
            { 
                this.noCompIDs = val;
            }
            
            public QuickFix.Fields.NoCompIDs Get(QuickFix.Fields.NoCompIDs val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoCompIDs val) 
            { 
                return IsSetNoCompIDs();
            }
            
            public bool IsSetNoCompIDs() 
            { 
                return IsSetField(Tags.NoCompIDs);
            }
            public class NoCompIDs : Group
            {
                public NoCompIDs() 
                  :base( Tags.NoCompIDs, Tags.RefCompID, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.RefCompID, Tags.RefSubID, Tags.LocationID, Tags.DeskID, Tags.StatusValue, Tags.StatusText, 0};
                            public QuickFix.Fields.RefCompID refCompID
                { 
                    get 
                    {
                        QuickFix.Fields.RefCompID val = new QuickFix.Fields.RefCompID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.RefCompID val) 
                { 
                    this.refCompID = val;
                }
                
                public QuickFix.Fields.RefCompID Get(QuickFix.Fields.RefCompID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.RefCompID val) 
                { 
                    return IsSetRefCompID();
                }
                
                public bool IsSetRefCompID() 
                { 
                    return IsSetField(Tags.RefCompID);
                }
                public QuickFix.Fields.RefSubID refSubID
                { 
                    get 
                    {
                        QuickFix.Fields.RefSubID val = new QuickFix.Fields.RefSubID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.RefSubID val) 
                { 
                    this.refSubID = val;
                }
                
                public QuickFix.Fields.RefSubID Get(QuickFix.Fields.RefSubID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.RefSubID val) 
                { 
                    return IsSetRefSubID();
                }
                
                public bool IsSetRefSubID() 
                { 
                    return IsSetField(Tags.RefSubID);
                }
                public QuickFix.Fields.LocationID locationID
                { 
                    get 
                    {
                        QuickFix.Fields.LocationID val = new QuickFix.Fields.LocationID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LocationID val) 
                { 
                    this.locationID = val;
                }
                
                public QuickFix.Fields.LocationID Get(QuickFix.Fields.LocationID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LocationID val) 
                { 
                    return IsSetLocationID();
                }
                
                public bool IsSetLocationID() 
                { 
                    return IsSetField(Tags.LocationID);
                }
                public QuickFix.Fields.DeskID deskID
                { 
                    get 
                    {
                        QuickFix.Fields.DeskID val = new QuickFix.Fields.DeskID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DeskID val) 
                { 
                    this.deskID = val;
                }
                
                public QuickFix.Fields.DeskID Get(QuickFix.Fields.DeskID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DeskID val) 
                { 
                    return IsSetDeskID();
                }
                
                public bool IsSetDeskID() 
                { 
                    return IsSetField(Tags.DeskID);
                }
                public QuickFix.Fields.StatusValue statusValue
                { 
                    get 
                    {
                        QuickFix.Fields.StatusValue val = new QuickFix.Fields.StatusValue();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.StatusValue val) 
                { 
                    this.statusValue = val;
                }
                
                public QuickFix.Fields.StatusValue Get(QuickFix.Fields.StatusValue val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.StatusValue val) 
                { 
                    return IsSetStatusValue();
                }
                
                public bool IsSetStatusValue() 
                { 
                    return IsSetField(Tags.StatusValue);
                }
                public QuickFix.Fields.StatusText statusText
                { 
                    get 
                    {
                        QuickFix.Fields.StatusText val = new QuickFix.Fields.StatusText();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.StatusText val) 
                { 
                    this.statusText = val;
                }
                
                public QuickFix.Fields.StatusText Get(QuickFix.Fields.StatusText val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.StatusText val) 
                { 
                    return IsSetStatusText();
                }
                
                public bool IsSetStatusText() 
                { 
                    return IsSetField(Tags.StatusText);
                }
            
            }
        }
    }
}
