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
    public class P019_UnknownMessage : GenericMessage
    {
        public short Unknown0;
        public int Unknown1;
        public byte Unknown2;
        public byte Unknown3;
        public byte Unknown4;
        public WorldPosition Unknown5;
        public short Unknown6;
        public short Unknown7;
        
        public override ushort Header
        {
            get
            {
                return 19;
            }
        }
        
        public override void Serialize(Serializer serializer)
        {
            base.Serialize(serializer);
            serializer.Write(this.Unknown0);
            serializer.WriteVarint(this.Unknown1);
            serializer.Write(this.Unknown2);
            serializer.Write(this.Unknown3);
            serializer.Write(this.Unknown4);
            serializer.WriteWorldPosition(this.Unknown5);
            serializer.Write(this.Unknown6);
            serializer.Write(this.Unknown7);
        }
    }
}
