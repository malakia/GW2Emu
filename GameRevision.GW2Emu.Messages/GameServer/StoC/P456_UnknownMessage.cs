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
    public class P456_UnknownMessage : GenericMessage
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public byte Unknown3;
        public byte Unknown4;
        public int Unknown5;
        public int Unknown6;
        public string Unknown7;
        public WorldPosition Unknown8;
        public int Unknown9;
        
        public override ushort Header
        {
            get
            {
                return 456;
            }
        }
        
        public override void Serialize(Serializer serializer)
        {
            base.Serialize(serializer);
            serializer.WriteVarint(this.Unknown0);
            serializer.WriteVarint(this.Unknown1);
            serializer.WriteVarint(this.Unknown2);
            serializer.Write(this.Unknown3);
            serializer.Write(this.Unknown4);
            serializer.WriteVarint(this.Unknown5);
            serializer.WriteVarint(this.Unknown6);
            serializer.WriteUtf16String(this.Unknown7);
            serializer.WriteWorldPosition(this.Unknown8);
            serializer.WriteVarint(this.Unknown9);
        }
    }
}
