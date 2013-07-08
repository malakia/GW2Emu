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
    public class P150_UnknownMessage : GenericTriggerableMessage
    {
        public string Unknown0;
        public string Unknown1;
        
        public override ushort Header
        {
            get
            {
                return 150;
            }
        }
        
        public override void Deserialize(Deserializer deserializer)
        {
            this.Unknown0 = deserializer.ReadUtf16String();
            this.Unknown1 = deserializer.ReadUtf16String();
        }
    }
}
