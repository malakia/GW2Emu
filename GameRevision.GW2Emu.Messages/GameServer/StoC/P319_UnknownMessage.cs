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
    public class P319_UnknownMessage : GenericMessage
    {
        public int Unknown0;
        public int Unknown1;
        public int Unknown2;
        public float Unknown3;
        public byte Unknown4;
        public int Unknown5;
        public int Unknown6;
        public int Unknown7;
        public int Unknown8;
        public byte Unknown9;
        public int Unknown10;
        public int Unknown11;
        public string Unknown12;
        public string Unknown13;
        public string Unknown14;
        
        public override ushort Header
        {
            get
            {
                return 319;
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
            serializer.WriteVarint(this.Unknown7);
            serializer.WriteVarint(this.Unknown8);
            serializer.Write(this.Unknown9);
            serializer.WriteVarint(this.Unknown10);
            serializer.WriteVarint(this.Unknown11);
            serializer.WriteUtf16String(this.Unknown12);
            serializer.WriteUtf16String(this.Unknown13);
            serializer.WriteUtf16String(this.Unknown14);
        }
    }
}
