using ProcessMemoryReaderLib;
using System;
using System.Diagnostics;

namespace AssaltCubeGamehack
{
    internal class PlayerData
    {
        int base_addr; // "ac_client.exe"+00169A38 구조체의 위치

        int health_offset = 0xF8;
        int bullet_proof_offset = 0xFC;
        int ammo_offset = 0x150;
        int x_pos_offset = 0x34;
        int z_pos_offset = 0x38;
        int y_pos_offset = 0x3C;
        int x_angle_offset = 0x40;
        int y_angle_offset = 0x44;

        //캐릭터 정보
        public int health;
        public int bullet_proof;
        public int ammo;
        public float x_pos;
        public float y_pos;
        public float z_pos;
        public float x_angle;
        public float y_angle;

        public PlayerData(Process proc,int offset, ProcessMemoryReader mem )
        {
            //"ac_client.exe"+0016BA08
            int base_ptr = proc.MainModule.BaseAddress.ToInt32() + offset;

            // mainplayer 구조체의 위치
            base_addr = mem.ReadInt(base_ptr);

            health = 0;
            bullet_proof = 0;
            ammo = 0;
            x_pos = 0;
            y_pos = 0;
            z_pos = 0;
            x_angle = 0;
            y_angle = 0;
        
    }

        public void SetPlayerData(ProcessMemoryReader mem)
        {
            health = mem.ReadInt(base_addr + health_offset);
            bullet_proof = mem.ReadInt(base_addr + bullet_proof_offset);
            ammo = mem.ReadInt(base_addr + ammo_offset);
            x_pos = mem.ReadFloat(base_addr + x_pos_offset);
            y_pos = mem.ReadFloat(base_addr + y_pos_offset);
            z_pos = mem.ReadFloat(base_addr + z_pos_offset);
            x_angle = mem.ReadFloat(base_addr + x_angle_offset);
            y_angle = mem.ReadFloat(base_addr + y_angle_offset);
        }

        internal void hackHealth(ProcessMemoryReader mem)
        {
            mem.WriteInt(base_addr + health_offset, 1000); // 체력 1000으로..
        }

        internal void hackAmmo(ProcessMemoryReader mem)
        {
            mem.WriteInt(base_addr + ammo_offset, 1000); // 탄약 1000으로..
        }
    }
}