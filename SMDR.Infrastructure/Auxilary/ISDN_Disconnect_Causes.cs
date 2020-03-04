using System;
using System.Collections.Generic;
using System.Text;

namespace SMDR.Infratructure.Auxilary
{
    public class ISDN_Disconnect_Causes:Dictionary<byte,string>
    {
        public ISDN_Disconnect_Causes()
        {
            this.Add(0x1, "Unallocated or unassigned number");
            this.Add(0x2, "No route to specified transit network (Transit Network Identity)");
            this.Add(0x3, "No route to destination");
            this.Add(0x4, "Send special information tone");
            this.Add(0x5, "Misdialled trunk prefix");
            this.Add(0x6, "Channel unacceptable");
            this.Add(0x7, "Call awarded and being delivered in an established channel");
            this.Add(0x8, "Prefix 0 dialed but not allowed");
            this.Add(0x9, "Prefix 1 dialed but not allowed");
            this.Add(0xA, "Prefix 1 not dialed but required");
            this.Add(0xB, "More digits received than allowed, call is proceeding");
            this.Add(0x10, "Normal call clearing");
            this.Add(0x11, "User busy");
            this.Add(0x12, "No user responding");
            this.Add(0x13, "T.301 expired: - User Alerted, No answer from user");
            this.Add(0x15, "Call rejected");
            this.Add(0x16, "Number changed to number in diagnostic field.");
            this.Add(0x17, "Reverse charging rejected");
            this.Add(0x18, "Call suspended");
            this.Add(0x19, "Call resumed");
            this.Add(0x1A, "Non-selected user clearing");
            this.Add(0x1B, "Destination out of order");
            this.Add(0x1C, "Invalid number format or incomplete address");
            this.Add(0x1D, "EKTS facility rejected by network");
            this.Add(0x1E, "Response to STATUS ENQUIRY");
            this.Add(0x1F, "Normal, unspecified");
            this.Add(0x21, "Circuit out of order");
            this.Add(0x22, "No circuit/channel available");
            this.Add(0x23, "Destination unattainable");
            this.Add(0x24, "Out of order");
            this.Add(0x25, "Degraded service");
            this.Add(0x26, "Network out of order");
            this.Add(0x27, "Transit delay range cannot be achieved");
            this.Add(0x28, "Throughput range cannot be achieved");
            this.Add(0x29, "Temporary failure");
            this.Add(0x2A, "Switching equipment congestion");
            this.Add(0x2B, "Access information discarded");
            this.Add(0x2C, "Requested circuit channel not available");
            this.Add(0x2D, "Preempted");
            this.Add(0x2E, "Precedence call blocked");
            this.Add(0x2F, "Resource unavailable, unspecified");
            this.Add(0x31, "Quality of service unavailable");
            this.Add(0x32, "Requested facility not subscribed");
            this.Add(0x33, "Reverse charging not allowed");
            this.Add(0x34, "Outgoing calls barred");
            this.Add(0x35, "Outgoing calls barred within CUG");
            this.Add(0x36, "Incoming calls barred");
            this.Add(0x37, "Incoming calls barred within CUG");
            this.Add(0x38, "Call waiting not subscribed");
            this.Add(0x39, "Bearer capability not authorized");
            this.Add(0x3A, "Bearer capability not presently available");
            this.Add(0x3F, "Service or option not available, unspecified");
            this.Add(0x41, "Bearer service not implemented");
            this.Add(0x42, "Channel type not implemented");
            this.Add(0x43, "Transit network selection not implemented");
            this.Add(0x44, "Message not implemented");
            this.Add(0x45, "Requested facility not implemented");
            this.Add(0x46, "Only restricted digital information bearer capability is available");
            this.Add(0x4F, "Service or option not implemented, unspecified");
            this.Add(0x51, "Invalid call reference value");
            this.Add(0x52, "Identified channel does not exist");
            this.Add(0x53, "A suspended call exists, but this call identity does not");
            this.Add(0x54, "Call identity in use");
            this.Add(0x55, "No call suspended");
            this.Add(0x56, "Call having the requested call identity has been cleared");
            this.Add(0x57, "Called user not member of CUG");
            this.Add(0x58, "Incompatible destination");
            this.Add(0x59, "Non-existent abbreviated address entry");
            this.Add(0x5A, "Destination address missing, and direct call not subscribed");
            this.Add(0x5B, "Invalid transit network selection (national use)");
            this.Add(0x5C, "Invalid facility parameter 93 Mandatory information element is missing");
            this.Add(0x5D, "Message type non-existent or not implemented");
            this.Add(0x5F, "Invalid message, unspecified");
            this.Add(0x60, "Mandatory information element is missing");
            this.Add(0x61, "Message type non-existent or not implemented");
            this.Add(0x62, "Message not compatible with call state or message type non-existent or not implemented");
            this.Add(0x63, "Information element nonexistent or not implemented");
            this.Add(0x64, "Invalid information element contents");
            this.Add(0x65, "Message not compatible with call state");
            this.Add(0x66, "Recovery on timer expiry");
            this.Add(0x67, "Parameter non-existent or not implemented - passed on");
            this.Add(0x6F, "Protocol error, unspecified");
            this.Add(0x7F, "Internetworking, unspecified");
            this.Add(0x80, "Proprietary diagnostic code (not necessarily bad). Typically used to pass proprietary control or maintenance messages between multiplexers.");
        }
        public new string this[byte index]
        {
            get { return index > 127 ? base[128] : base[index]; }
            set { /* set the specified index to value here */ }
        }
    }
}
