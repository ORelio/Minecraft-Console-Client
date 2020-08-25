﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinecraftClient.Protocol.Handlers.PacketTypes
{
    public enum PacketTypesIn
    {
        SpawnEntity,
        SpawnExperienceOrb,
        SpawnWeatherEntity,
        SpawnLivingEntity,
        SpawnPainting,
        SpawnPlayer,
        EntityAnimation,
        Statistics,
        AcknowledgePlayerDigging,
        BlockBreakAnimation,
        BlockEntityData,
        BlockAction,
        BlockChange,
        BossBar,
        ServerDifficulty,
        ChatMessage,
        MultiBlockChange,
        TabComplete,
        DeclareCommands,
        WindowConfirmation,
        CloseWindow,
        WindowItems,
        WindowProperty,
        SetSlot,
        SetCooldown,
        PluginMessage,
        NamedSoundEffect,
        Disconnect,
        EntityStatus,
        Explosion,
        UnloadChunk,
        ChangeGameState,
        OpenHorseWindow,
        KeepAlive,
        ChunkData,
        Effect,
        Particle,
        UpdateLight,
        JoinGame,
        MapData,
        TradeList,
        EntityPosition,
        EntityPositionandRotation,
        EntityRotation,
        EntityMovement,
        VehicleMove,
        OpenBook,
        OpenWindow,
        OpenSignEditor,
        CraftRecipeResponse,
        PlayerAbilities,
        CombatEvent,
        PlayerListUpdate, // new name is PlayerInfo. should we change it?
        FacePlayer,
        PlayerPositionAndLook,
        UnlockRecipes,
        DestroyEntities,
        RemoveEntityEffect,
        ResourcePackSend,
        Respawn,
        EntityHeadLook,
        SelectAdvancementTab,
        WorldBorder,
        Camera,
        HeldItemChange,
        UpdateViewPosition,
        UpdateViewDistance,
        DisplayScoreboard,
        EntityMetadata,
        AttachEntity,
        EntityVelocity,
        EntityEquipment,
        SetExperience,
        UpdateHealth,
        ScoreboardObjective,
        SetPassengers,
        Teams,
        UpdateScore,
        SpawnPosition,
        TimeUpdate,
        Title,
        EntitySoundEffect,
        SoundEffect,
        StopSound,
        PlayerListHeaderAndFooter,
        NBTQueryResponse,
        CollectItem,
        EntityTeleport,
        Advancements,
        EntityProperties,
        EntityEffect,
        DeclareRecipes,
        Tags,
        MapChunkBulk, // For 1.8 or below
        Unknown, // For old version packet that have been removed and not used by mcc 
    }
}
