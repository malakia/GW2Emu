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

namespace GameRevision.GW2Emu.Messages.LoginServer.StoC
{
    public class P17_UnknownMessage : GenericMessage
    {
        public int Unknown0;
        public UID Unknown1;
        public int Unknown2;
        public string Unknown3;
        public byte[] Unknown4;
        
        public override ushort Header
        {
            get
            {
                return 17;
            }
        }
        
        public override void Serialize(Serializer serializer)
        {
            base.Serialize(serializer);
            serializer.WriteVarint(this.Unknown0);
            serializer.WriteUID(this.Unknown1);
            serializer.WriteVarint(this.Unknown2);
            serializer.WriteUtf16String(this.Unknown3);
            serializer.Write((ushort)Unknown4.Length);
            for (int i = 0; i < Unknown4.Length; i++)
            {
                serializer.Write(Unknown4[i]);
            }
        }
    }
}
