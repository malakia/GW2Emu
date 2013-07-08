/*
 * This code was autogenerated by
 * GameRevision.GW2Emu.CodeWriter.
 * Date generated: 08-07-13
 */

using System;
using System.IO;
using System.Net;
using GameRevision.GW2Emu.Core;
using GameRevision.GW2Emu.Core.Types;
using GameRevision.GW2Emu.Core.Serializers;

namespace GameRevision.GW2Emu.Messages.GameServer.CtoS
{
    public class P176_UnknownMessage : GenericTriggerableMessage
    {
        public UID Unknown0;
        public UID Unknown1;
        
        public override ushort Header
        {
            get
            {
                return 176;
            }
        }
        
        public override void Deserialize(Deserializer deserializer)
        {
            this.Unknown0 = deserializer.ReadUID();
            this.Unknown1 = deserializer.ReadUID();
        }
    }
}
