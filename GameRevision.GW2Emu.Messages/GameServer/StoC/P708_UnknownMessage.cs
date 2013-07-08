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

namespace GameRevision.GW2Emu.Messages.GameServer.StoC
{
    public class P708_UnknownMessage : GenericMessage
    {
        public short Unknown0;
        public short Unknown1;
        public int Unknown2;
        
        public override ushort Header
        {
            get
            {
                return 708;
            }
        }
        
        public override void Serialize(Serializer serializer)
        {
            base.Serialize(serializer);
            serializer.Write(this.Unknown0);
            serializer.Write(this.Unknown1);
            serializer.WriteVarint(this.Unknown2);
        }
    }
}
