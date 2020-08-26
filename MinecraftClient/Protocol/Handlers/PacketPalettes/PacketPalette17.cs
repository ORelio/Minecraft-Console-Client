﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinecraftClient.Protocol.Handlers.PacketPalettes
{
    /// <summary>
    /// For Minecraft version 1.7 - 1.8
    /// </summary>
    class PacketPalette17 : PacketTypePalette
    {
        private List<PacketTypesIn> typeIn = new List<PacketTypesIn>()
        {
            PacketTypesIn.KeepAlive,
            PacketTypesIn.JoinGame,
            PacketTypesIn.ChatMessage,
            PacketTypesIn.TimeUpdate,
            PacketTypesIn.EntityEquipment,
            PacketTypesIn.SpawnPosition,
            PacketTypesIn.UpdateHealth,
            PacketTypesIn.Respawn,
            PacketTypesIn.PlayerPositionAndLook,
            PacketTypesIn.HeldItemChange,
            PacketTypesIn.UseBed,
            PacketTypesIn.EntityAnimation,
            PacketTypesIn.SpawnPlayer,
            PacketTypesIn.CollectItem,
            PacketTypesIn.SpawnEntity,
            PacketTypesIn.SpawnLivingEntity,
            PacketTypesIn.SpawnPainting,
            PacketTypesIn.SpawnExperienceOrb,
            PacketTypesIn.EntityVelocity,
            PacketTypesIn.DestroyEntities,
            PacketTypesIn.EntityMovement,
            PacketTypesIn.EntityPosition,
            PacketTypesIn.EntityRotation,
            PacketTypesIn.EntityPositionAndRotation,
            PacketTypesIn.EntityTeleport,
            PacketTypesIn.EntityHeadLook,
            PacketTypesIn.EntityStatus,
            PacketTypesIn.AttachEntity,
            PacketTypesIn.EntityMetadata,
            PacketTypesIn.EntityEffect,
            PacketTypesIn.RemoveEntityEffect,
            PacketTypesIn.SetExperience,
            PacketTypesIn.EntityProperties,
            PacketTypesIn.ChunkData,
            PacketTypesIn.MultiBlockChange,
            PacketTypesIn.BlockChange,
            PacketTypesIn.BlockAction,
            PacketTypesIn.BlockBreakAnimation,
            PacketTypesIn.MapChunkBulk,
            PacketTypesIn.Explosion,
            PacketTypesIn.Effect,
            PacketTypesIn.SoundEffect,
            PacketTypesIn.Particle,
            PacketTypesIn.ChangeGameState,
            PacketTypesIn.SpawnWeatherEntity,
            PacketTypesIn.OpenWindow,
            PacketTypesIn.CloseWindow,
            PacketTypesIn.SetSlot,
            PacketTypesIn.WindowItems,
            PacketTypesIn.WindowProperty,
            PacketTypesIn.WindowConfirmation,
            PacketTypesIn.Unknown, // UpdateSign
            PacketTypesIn.MapData,
            PacketTypesIn.BlockEntityData,
            PacketTypesIn.OpenSignEditor,
            PacketTypesIn.Statistics,
            PacketTypesIn.PlayerInfo,
            PacketTypesIn.PlayerAbilities,
            PacketTypesIn.TabComplete,
            PacketTypesIn.ScoreboardObjective,
            PacketTypesIn.UpdateScore,
            PacketTypesIn.DisplayScoreboard,
            PacketTypesIn.Teams,
            PacketTypesIn.PluginMessage,
            PacketTypesIn.Disconnect,
            PacketTypesIn.ServerDifficulty,
            PacketTypesIn.CombatEvent,
            PacketTypesIn.Camera,
            PacketTypesIn.WorldBorder,
            PacketTypesIn.Title,
            PacketTypesIn.SetCompression,
            PacketTypesIn.PlayerListHeaderAndFooter,
            PacketTypesIn.ResourcePackSend,
            PacketTypesIn.Unknown // UpdateEntityNBT
        };

        private List<PacketTypesOut> typeOut = new List<PacketTypesOut>()
        {
            PacketTypesOut.KeepAlive,
            PacketTypesOut.ChatMessage,
            PacketTypesOut.InteractEntity,
            PacketTypesOut.PlayerMovement,
            PacketTypesOut.PlayerPosition,
            PacketTypesOut.PlayerRotation,
            PacketTypesOut.PlayerPositionAndRotation,
            PacketTypesOut.PlayerDigging,
            PacketTypesOut.PlayerBlockPlacement,
            PacketTypesOut.HeldItemChange,
            PacketTypesOut.Animation,
            PacketTypesOut.EntityAction,
            PacketTypesOut.SteerVehicle,
            PacketTypesOut.CloseWindow,
            PacketTypesOut.ClickWindow,
            PacketTypesOut.WindowConfirmation,
            PacketTypesOut.CreativeInventoryAction,
            PacketTypesOut.EnchantItem,
            PacketTypesOut.UpdateSign,
            PacketTypesOut.PlayerAbilities,
            PacketTypesOut.TabComplete,
            PacketTypesOut.ClientSettings,
            PacketTypesOut.ClientStatus,
            PacketTypesOut.PluginMessage,
            PacketTypesOut.Spectate,
            PacketTypesOut.ResourcePackStatus
        };

        protected override List<PacketTypesIn> GetListIn()
        {
            return typeIn;
        }

        protected override List<PacketTypesOut> GetListOut()
        {
            return typeOut;
        }
    }
}
