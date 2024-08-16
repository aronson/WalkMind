module WalkMind.Domain

open FSharp.Json


type cell =
    | ``NO_CELL`` = -1
    | ``EARTH`` = 0
    | ``EARTH_EXC`` = 1
    | ``GROUND`` = 2
    | ``FLOOR_RETRACTED`` = 3
    | ``FLOOR_SAN`` = 4
    | ``FLOOR_YRD`` = 5
    | ``FLOOR_MAT`` = 6
    | ``FLOOR_FAC`` = 7
    | ``FLOOR_RES`` = 8
    | ``FLOOR_ACC`` = 9
    | ``FLOOR_SUR`` = 10
    | ``FLOOR_MIN`` = 11
    | ``FLOOR_EXI`` = 12
    | ``FLOOR_STO`` = 13
    | ``FLOOR_REC`` = 14
    | ``FLOOR_SCR`` = 15
    | ``FLOOR_WAS`` = 16
    | ``FLOOR_GAR`` = 17
    | ``FLOOR_DSF`` = 18
    | ``FLOOR_SUB`` = 19
    | ``FLOOR_LOW`` = 20
    | ``FLOOR_UPP`` = 21
    | ``FLOOR_PRO`` = 22
    | ``FLOOR_DEE`` = 23
    | ``FLOOR_ZIO`` = 24
    | ``FLOOR_DAT`` = 25
    | ``FLOOR_ZHI`` = 26
    | ``FLOOR_WAR`` = 27
    | ``FLOOR_EXT`` = 28
    | ``FLOOR_CET`` = 29
    | ``FLOOR_ARC`` = 30
    | ``FLOOR_HUB`` = 31
    | ``FLOOR_ARM`` = 32
    | ``FLOOR_LAB`` = 33
    | ``FLOOR_QUA`` = 34
    | ``FLOOR_TES`` = 35
    | ``FLOOR_SEC`` = 36
    | ``FLOOR_COM`` = 37
    | ``FLOOR_AC0`` = 38
    | ``FLOOR_LAI`` = 39
    | ``FLOOR_TOW`` = 40
    | ``TEMP_WALL`` = 41
    | ``WALL_SAN`` = 42
    | ``WALL_YRD`` = 43
    | ``WALL_MAT`` = 44
    | ``WALL_FAC`` = 45
    | ``WALL_RES`` = 46
    | ``WALL_ACC`` = 47
    | ``WALL_SUR`` = 48
    | ``WALL_MIN`` = 49
    | ``WALL_EXI`` = 50
    | ``WALL_STO`` = 51
    | ``WALL_REC`` = 52
    | ``WALL_SCR`` = 53
    | ``WALL_WAS`` = 54
    | ``WALL_GAR`` = 55
    | ``WALL_DSF`` = 56
    | ``WALL_SUB`` = 57
    | ``WALL_LOW`` = 58
    | ``WALL_UPP`` = 59
    | ``WALL_PRO`` = 60
    | ``WALL_DEE`` = 61
    | ``WALL_ZIO`` = 62
    | ``WALL_DAT`` = 63
    | ``WALL_ZHI`` = 64
    | ``WALL_WAR`` = 65
    | ``WALL_EXT`` = 66
    | ``WALL_CET`` = 67
    | ``WALL_ARC`` = 68
    | ``WALL_HUB`` = 69
    | ``WALL_ARM`` = 70
    | ``WALL_LAB`` = 71
    | ``WALL_QUA`` = 72
    | ``WALL_TES`` = 73
    | ``WALL_SEC`` = 74
    | ``WALL_COM`` = 75
    | ``WALL_AC0`` = 76
    | ``WALL_LAI`` = 77
    | ``WALL_TOW`` = 78
    | ``BARRIER_SAN`` = 79
    | ``BARRIER_YRD`` = 80
    | ``BARRIER_MAT`` = 81
    | ``BARRIER_FAC`` = 82
    | ``BARRIER_RES`` = 83
    | ``BARRIER_ACC`` = 84
    | ``BARRIER_SUR`` = 85
    | ``BARRIER_MIN`` = 86
    | ``BARRIER_EXI`` = 87
    | ``BARRIER_STO`` = 88
    | ``BARRIER_REC`` = 89
    | ``BARRIER_SCR`` = 90
    | ``BARRIER_WAS`` = 91
    | ``BARRIER_GAR`` = 92
    | ``BARRIER_DSF`` = 93
    | ``BARRIER_SUB`` = 94
    | ``BARRIER_LOW`` = 95
    | ``BARRIER_UPP`` = 96
    | ``BARRIER_PRO`` = 97
    | ``BARRIER_DEE`` = 98
    | ``BARRIER_ZIO`` = 99
    | ``BARRIER_DAT`` = 100
    | ``BARRIER_ZHI`` = 101
    | ``BARRIER_WAR`` = 102
    | ``BARRIER_EXT`` = 103
    | ``BARRIER_CET`` = 104
    | ``BARRIER_ARC`` = 105
    | ``BARRIER_HUB`` = 106
    | ``BARRIER_ARM`` = 107
    | ``BARRIER_LAB`` = 108
    | ``BARRIER_QUA`` = 109
    | ``BARRIER_TES`` = 110
    | ``BARRIER_SEC`` = 111
    | ``BARRIER_COM`` = 112
    | ``BARRIER_AC0`` = 113
    | ``BARRIER_LAI`` = 114
    | ``BARRIER_TOW`` = 115
    | ``SHORTCUT_SAN`` = 116
    | ``SHORTCUT_YRD`` = 117
    | ``SHORTCUT_MAT`` = 118
    | ``SHORTCUT_FAC`` = 119
    | ``SHORTCUT_RES`` = 120
    | ``SHORTCUT_ACC`` = 121
    | ``SHORTCUT_SUR`` = 122
    | ``SHORTCUT_MIN`` = 123
    | ``SHORTCUT_EXI`` = 124
    | ``SHORTCUT_STO`` = 125
    | ``SHORTCUT_REC`` = 126
    | ``SHORTCUT_SCR`` = 127
    | ``SHORTCUT_WAS`` = 128
    | ``SHORTCUT_GAR`` = 129
    | ``SHORTCUT_DSF`` = 130
    | ``SHORTCUT_SUB`` = 131
    | ``SHORTCUT_LOW`` = 132
    | ``SHORTCUT_UPP`` = 133
    | ``SHORTCUT_PRO`` = 134
    | ``SHORTCUT_DEE`` = 135
    | ``SHORTCUT_ZIO`` = 136
    | ``SHORTCUT_DAT`` = 137
    | ``SHORTCUT_ZHI`` = 138
    | ``SHORTCUT_WAR`` = 139
    | ``SHORTCUT_EXT`` = 140
    | ``SHORTCUT_CET`` = 141
    | ``SHORTCUT_ARC`` = 142
    | ``SHORTCUT_HUB`` = 143
    | ``SHORTCUT_ARM`` = 144
    | ``SHORTCUT_LAB`` = 145
    | ``SHORTCUT_QUA`` = 146
    | ``SHORTCUT_TES`` = 147
    | ``SHORTCUT_SEC`` = 148
    | ``SHORTCUT_COM`` = 149
    | ``SHORTCUT_AC0`` = 150
    | ``SHORTCUT_LAI`` = 151
    | ``SHORTCUT_TOW`` = 152
    | ``SHORTCUT_KNOWN`` = 153
    | ``PHASEWALL_SAN`` = 154
    | ``PHASEWALL_YRD`` = 155
    | ``PHASEWALL_MAT`` = 156
    | ``PHASEWALL_FAC`` = 157
    | ``PHASEWALL_RES`` = 158
    | ``PHASEWALL_ACC`` = 159
    | ``PHASEWALL_SUR`` = 160
    | ``PHASEWALL_MIN`` = 161
    | ``PHASEWALL_EXI`` = 162
    | ``PHASEWALL_STO`` = 163
    | ``PHASEWALL_REC`` = 164
    | ``PHASEWALL_SCR`` = 165
    | ``PHASEWALL_WAS`` = 166
    | ``PHASEWALL_GAR`` = 167
    | ``PHASEWALL_DSF`` = 168
    | ``PHASEWALL_SUB`` = 169
    | ``PHASEWALL_LOW`` = 170
    | ``PHASEWALL_UPP`` = 171
    | ``PHASEWALL_PRO`` = 172
    | ``PHASEWALL_DEE`` = 173
    | ``PHASEWALL_ZIO`` = 174
    | ``PHASEWALL_DAT`` = 175
    | ``PHASEWALL_ZHI`` = 176
    | ``PHASEWALL_WAR`` = 177
    | ``PHASEWALL_EXT`` = 178
    | ``PHASEWALL_CET`` = 179
    | ``PHASEWALL_ARC`` = 180
    | ``PHASEWALL_HUB`` = 181
    | ``PHASEWALL_ARM`` = 182
    | ``PHASEWALL_LAB`` = 183
    | ``PHASEWALL_QUA`` = 184
    | ``PHASEWALL_TES`` = 185
    | ``PHASEWALL_SEC`` = 186
    | ``PHASEWALL_COM`` = 187
    | ``PHASEWALL_AC0`` = 188
    | ``PHASEWALL_LAI`` = 189
    | ``PHASEWALL_TOW`` = 190
    | ``PHASEWALL_KNOWN`` = 191
    | ``SEALED_DOOR`` = 192
    | ``DOOR_SAN`` = 193
    | ``DOOR_YRD`` = 194
    | ``DOOR_MAT`` = 195
    | ``DOOR_FAC`` = 196
    | ``DOOR_RES`` = 197
    | ``DOOR_ACC`` = 198
    | ``DOOR_SUR`` = 199
    | ``DOOR_MIN`` = 200
    | ``DOOR_EXI`` = 201
    | ``DOOR_STO`` = 202
    | ``DOOR_REC`` = 203
    | ``DOOR_SCR`` = 204
    | ``DOOR_WAS`` = 205
    | ``DOOR_GAR`` = 206
    | ``DOOR_DSF`` = 207
    | ``DOOR_SUB`` = 208
    | ``DOOR_LOW`` = 209
    | ``DOOR_UPP`` = 210
    | ``DOOR_PRO`` = 211
    | ``DOOR_DEE`` = 212
    | ``DOOR_ZIO`` = 213
    | ``DOOR_DAT`` = 214
    | ``DOOR_ZHI`` = 215
    | ``DOOR_WAR`` = 216
    | ``DOOR_EXT`` = 217
    | ``DOOR_CET`` = 218
    | ``DOOR_ARC`` = 219
    | ``DOOR_HUB`` = 220
    | ``DOOR_ARM`` = 221
    | ``DOOR_LAB`` = 222
    | ``DOOR_QUA`` = 223
    | ``DOOR_TES`` = 224
    | ``DOOR_SEC`` = 225
    | ``DOOR_COM`` = 226
    | ``DOOR_AC0`` = 227
    | ``DOOR_LAI`` = 228
    | ``DOOR_TOW`` = 229
    | ``STAIRS_SAN`` = 230
    | ``STAIRS_YRD`` = 231
    | ``STAIRS_MAT`` = 232
    | ``STAIRS_FAC`` = 233
    | ``STAIRS_RES`` = 234
    | ``STAIRS_SUR`` = 235
    | ``STAIRS_ACC`` = 236
    | ``STAIRS_MIN`` = 237
    | ``STAIRS_EXI`` = 238
    | ``STAIRS_STO`` = 239
    | ``STAIRS_REC`` = 240
    | ``STAIRS_SCR`` = 241
    | ``STAIRS_WAS`` = 242
    | ``STAIRS_GAR`` = 243
    | ``STAIRS_DSF`` = 244
    | ``STAIRS_SUB`` = 245
    | ``STAIRS_LOW`` = 246
    | ``STAIRS_UPP`` = 247
    | ``STAIRS_PRO`` = 248
    | ``STAIRS_DEE`` = 249
    | ``STAIRS_ZIO`` = 250
    | ``STAIRS_DAT`` = 251
    | ``STAIRS_ZHI`` = 252
    | ``STAIRS_WAR`` = 253
    | ``STAIRS_EXT`` = 254
    | ``STAIRS_CET`` = 255
    | ``STAIRS_ARC`` = 256
    | ``STAIRS_HUB`` = 257
    | ``STAIRS_ARM`` = 258
    | ``STAIRS_LAB`` = 259
    | ``STAIRS_QUA`` = 260
    | ``STAIRS_TES`` = 261
    | ``STAIRS_SEC`` = 262
    | ``STAIRS_COM`` = 263
    | ``STAIRS_AC0`` = 264
    | ``STAIRS_LAI`` = 265
    | ``STAIRS_TOW`` = 266
    | ``STAIRS_NOACCESS`` = 267
    | ``STAIRS_BLOCKED`` = 268
    | ``STAIRS_GAR_OPEN`` = 269
    | ``STAIRS_DSF_OPEN`` = 270
    | ``STAIRS_SHORTCUT`` = 271


[<RequireQualifiedAccess>]
type Item =
    | [<JsonUnionCase(@"Matter")>] ``Matter``
    | [<JsonUnionCase(@"Data Core")>] ``Data Core``
    | [<JsonUnionCase(@"Derelict Log")>] ``Derelict Log``
    | [<JsonUnionCase(@"Schematic Archive")>] ``Schematic Archive``
    | [<JsonUnionCase(@"Imprinter Data Core")>] ``Imprinter Data Core``
    | [<JsonUnionCase(@"A2 Data Core")>] ``A2 Data Core``
    | [<JsonUnionCase(@"A7 Data Core")>] ``A7 Data Core``
    | [<JsonUnionCase(@"MAIN.C Data Core")>] ``MAIN_C Data Core``
    | [<JsonUnionCase(@"Architect Data Core")>] ``Architect Data Core``
    | [<JsonUnionCase(@"Scrap")>] ``Scrap``
    | [<JsonUnionCase(@"Protomatter")>] ``Protomatter``
    | [<JsonUnionCase(@"Ion Engine")>] ``Ion Engine``
    | [<JsonUnionCase(@"Lgt. Ion Engine")>] ``Lgt_ Ion Engine``
    | [<JsonUnionCase(@"Backup Power I")>] ``Backup Power I``
    | [<JsonUnionCase(@"Imp. Ion Engine")>] ``Imp_ Ion Engine``
    | [<JsonUnionCase(@"Rnf. Ion Engine")>] ``Rnf_ Ion Engine``
    | [<JsonUnionCase(@"Hvy. Ion Engine")>] ``Hvy_ Ion Engine``
    | [<JsonUnionCase(@"Cld. Ion Engine")>] ``Cld_ Ion Engine``
    | [<JsonUnionCase(@"Sub. Power Source")>] ``Sub_ Power Source``
    | [<JsonUnionCase(@"Deuterium Engine")>] ``Deuterium Engine``
    | [<JsonUnionCase(@"Lgt. Deuterium Engine")>] ``Lgt_ Deuterium Engine``
    | [<JsonUnionCase(@"Backup Power III")>] ``Backup Power III``
    | [<JsonUnionCase(@"Nuclear Core")>] ``Nuclear Core``
    | [<JsonUnionCase(@"Lgt. Nuclear Core")>] ``Lgt_ Nuclear Core``
    | [<JsonUnionCase(@"Imp. Deuterium Engine")>] ``Imp_ Deuterium Engine``
    | [<JsonUnionCase(@"Rnf. Deuterium Engine")>] ``Rnf_ Deuterium Engine``
    | [<JsonUnionCase(@"Hyb. Deuterium Engine")>] ``Hyb_ Deuterium Engine``
    | [<JsonUnionCase(@"Hvy. Deuterium Engine")>] ``Hvy_ Deuterium Engine``
    | [<JsonUnionCase(@"Cld. Deuterium Engine")>] ``Cld_ Deuterium Engine``
    | [<JsonUnionCase(@"Enh. Nuclear Core")>] ``Enh_ Nuclear Core``
    | [<JsonUnionCase(@"Mic. Nuclear Core")>] ``Mic_ Nuclear Core``
    | [<JsonUnionCase(@"Mak. Power Source")>] ``Mak_ Power Source``
    | [<JsonUnionCase(@"Angular Momentum Engine")>] ``Angular Momentum Engine``
    | [<JsonUnionCase(@"Lgt. Angular Momentum Engine")>] ``Lgt_ Angular Momentum Engine``
    | [<JsonUnionCase(@"F-cell Engine")>] ``F-cell Engine``
    | [<JsonUnionCase(@"Fission Core")>] ``Fission Core``
    | [<JsonUnionCase(@"Lgt. Fission Core")>] ``Lgt_ Fission Core``
    | [<JsonUnionCase(@"Hyb. Fission Core")>] ``Hyb_ Fission Core``
    | [<JsonUnionCase(@"Fusion Compressor")>] ``Fusion Compressor``
    | [<JsonUnionCase(@"Cold Fusion Reactor")>] ``Cold Fusion Reactor``
    | [<JsonUnionCase(@"Neutrino Core")>] ``Neutrino Core``
    | [<JsonUnionCase(@"Lgt. Neutrino Core")>] ``Lgt_ Neutrino Core``
    | [<JsonUnionCase(@"Rnf. Fission Core")>] ``Rnf_ Fission Core``
    | [<JsonUnionCase(@"Enh. Fission Core")>] ``Enh_ Fission Core``
    | [<JsonUnionCase(@"Cld. Fission Core")>] ``Cld_ Fission Core``
    | [<JsonUnionCase(@"Mic. Fission Core")>] ``Mic_ Fission Core``
    | [<JsonUnionCase(@"Fusion Reactor")>] ``Fusion Reactor``
    | [<JsonUnionCase(@"Antimatter Reactor")>] ``Antimatter Reactor``
    | [<JsonUnionCase(@"Lgt. Antimatter Reactor")>] ``Lgt_ Antimatter Reactor``
    | [<JsonUnionCase(@"Rnf. Antimatter Reactor")>] ``Rnf_ Antimatter Reactor``
    | [<JsonUnionCase(@"Hyb. Antimatter Reactor")>] ``Hyb_ Antimatter Reactor``
    | [<JsonUnionCase(@"Backup Power VII")>] ``Backup Power VII``
    | [<JsonUnionCase(@"MA-1KR's Cyclogen")>] ``MA-1KR's Cyclogen``
    | [<JsonUnionCase(@"Hvy. Antimatter Reactor")>] ``Hvy_ Antimatter Reactor``
    | [<JsonUnionCase(@"Mni. Fusion Reactor")>] ``Mni_ Fusion Reactor``
    | [<JsonUnionCase(@"Imp. Fusion Compressor")>] ``Imp_ Fusion Compressor``
    | [<JsonUnionCase(@"Mic. Neutrino Core")>] ``Mic_ Neutrino Core``
    | [<JsonUnionCase(@"Zio. Light DM Reactor")>] ``Zio_ Light DM Reactor``
    | [<JsonUnionCase(@"Zio. Heavy DM Reactor")>] ``Zio_ Heavy DM Reactor``
    | [<JsonUnionCase(@"Particle Reactor")>] ``Particle Reactor``
    | [<JsonUnionCase(@"Lgt. Particle Reactor")>] ``Lgt_ Particle Reactor``
    | [<JsonUnionCase(@"Mic. Antimatter Reactor")>] ``Mic_ Antimatter Reactor``
    | [<JsonUnionCase(@"Com. Particle Reactor")>] ``Com_ Particle Reactor``
    | [<JsonUnionCase(@"Cld. Antimatter Reactor")>] ``Cld_ Antimatter Reactor``
    | [<JsonUnionCase(@"Graviton Reactor")>] ``Graviton Reactor``
    | [<JsonUnionCase(@"Asb. Flux Generator")>] ``Asb_ Flux Generator``
    | [<JsonUnionCase(@"Quantum Reactor")>] ``Quantum Reactor``
    | [<JsonUnionCase(@"Lgt. Quantum Reactor")>] ``Lgt_ Quantum Reactor``
    | [<JsonUnionCase(@"Rnf. Quantum Reactor")>] ``Rnf_ Quantum Reactor``
    | [<JsonUnionCase(@"Imp. Quantum Reactor")>] ``Imp_ Quantum Reactor``
    | [<JsonUnionCase(@"Zero-point Reactor")>] ``Zero-point Reactor``
    | [<JsonUnionCase(@"Vortex Chain Reactor")>] ``Vortex Chain Reactor``
    | [<JsonUnionCase(@"Singularity Reactor")>] ``Singularity Reactor``
    | [<JsonUnionCase(@"Matter Drive")>] ``Matter Drive``
    | [<JsonUnionCase(@"Meta Core")>] ``Meta Core``
    | [<JsonUnionCase(@"SE_PO1")>] ``SE_PO1``
    | [<JsonUnionCase(@"Lgt. Treads")>] ``Lgt_ Treads``
    | [<JsonUnionCase(@"Imp. Treads")>] ``Imp_ Treads``
    | [<JsonUnionCase(@"Spk. Treads")>] ``Spk_ Treads``
    | [<JsonUnionCase(@"Arm. Treads")>] ``Arm_ Treads``
    | [<JsonUnionCase(@"Adv. Treads")>] ``Adv_ Treads``
    | [<JsonUnionCase(@"Ovr. Treads")>] ``Ovr_ Treads``
    | [<JsonUnionCase(@"Med. Treads")>] ``Med_ Treads``
    | [<JsonUnionCase(@"Imp. Medium Treads")>] ``Imp_ Medium Treads``
    | [<JsonUnionCase(@"Spk. Medium Treads")>] ``Spk_ Medium Treads``
    | [<JsonUnionCase(@"Arm. Medium Treads")>] ``Arm_ Medium Treads``
    | [<JsonUnionCase(@"Hvy. Treads")>] ``Hvy_ Treads``
    | [<JsonUnionCase(@"Ovr. Medium Treads")>] ``Ovr_ Medium Treads``
    | [<JsonUnionCase(@"Tri-treads")>] ``Tri-treads``
    | [<JsonUnionCase(@"Wartreads")>] ``Wartreads``
    | [<JsonUnionCase(@"Adv. Medium Treads")>] ``Adv_ Medium Treads``
    | [<JsonUnionCase(@"Enh. Armored Medium Treads")>] ``Enh_ Armored Medium Treads``
    | [<JsonUnionCase(@"Imp. Heavy Treads")>] ``Imp_ Heavy Treads``
    | [<JsonUnionCase(@"Hvy. Siege Treads")>] ``Hvy_ Siege Treads``
    | [<JsonUnionCase(@"Spk. Heavy Treads")>] ``Spk_ Heavy Treads``
    | [<JsonUnionCase(@"Vmp. Heavy Siege Treads")>] ``Vmp_ Heavy Siege Treads``
    | [<JsonUnionCase(@"DD-05H's Wartreads")>] ``DD-05H's Wartreads``
    | [<JsonUnionCase(@"Biometal Medium Treads")>] ``Biometal Medium Treads``
    | [<JsonUnionCase(@"Arm. Heavy Treads")>] ``Arm_ Heavy Treads``
    | [<JsonUnionCase(@"Adv. Heavy Treads")>] ``Adv_ Heavy Treads``
    | [<JsonUnionCase(@"Imp. Heavy Siege Treads")>] ``Imp_ Heavy Siege Treads``
    | [<JsonUnionCase(@"Centrium Heavy Treads")>] ``Centrium Heavy Treads``
    | [<JsonUnionCase(@"Megatreads")>] ``Megatreads``
    | [<JsonUnionCase(@"Biometal Heavy Treads")>] ``Biometal Heavy Treads``
    | [<JsonUnionCase(@"Exp. Biometal Heavy Treads")>] ``Exp_ Biometal Heavy Treads``
    | [<JsonUnionCase(@"Enh. Armored Heavy Treads")>] ``Enh_ Armored Heavy Treads``
    | [<JsonUnionCase(@"Adv. Heavy Siege Treads")>] ``Adv_ Heavy Siege Treads``
    | [<JsonUnionCase(@"Hdn. Centrium Heavy Treads")>] ``Hdn_ Centrium Heavy Treads``
    | [<JsonUnionCase(@"Exp. Biometal Medium Treads")>] ``Exp_ Biometal Medium Treads``
    | [<JsonUnionCase(@"Aluminum Leg")>] ``Aluminum Leg``
    | [<JsonUnionCase(@"Imp. Aluminum Leg")>] ``Imp_ Aluminum Leg``
    | [<JsonUnionCase(@"Carbon-fiber Leg")>] ``Carbon-fiber Leg``
    | [<JsonUnionCase(@"Titanium Leg")>] ``Titanium Leg``
    | [<JsonUnionCase(@"Ovr. Titanium Leg")>] ``Ovr_ Titanium Leg``
    | [<JsonUnionCase(@"VSS Leg")>] ``VSS Leg``
    | [<JsonUnionCase(@"Imp. Carbon-fiber Leg")>] ``Imp_ Carbon-fiber Leg``
    | [<JsonUnionCase(@"Imp. Titanium Leg")>] ``Imp_ Titanium Leg``
    | [<JsonUnionCase(@"Lgt. Armored Exoskeleton")>] ``Lgt_ Armored Exoskeleton``
    | [<JsonUnionCase(@"Mak. Leg")>] ``Mak_ Leg``
    | [<JsonUnionCase(@"Flexi-carbon Leg")>] ``Flexi-carbon Leg``
    | [<JsonUnionCase(@"Arm. Leg")>] ``Arm_ Leg``
    | [<JsonUnionCase(@"Imp. VSS Leg")>] ``Imp_ VSS Leg``
    | [<JsonUnionCase(@"Zio. Composite Leg I")>] ``Zio_ Composite Leg I``
    | [<JsonUnionCase(@"Med. Armored Exoskeleton")>] ``Med_ Armored Exoskeleton``
    | [<JsonUnionCase(@"Ovr. Flexi-carbon Leg")>] ``Ovr_ Flexi-carbon Leg``
    | [<JsonUnionCase(@"Enh. Flexi-carbon Leg")>] ``Enh_ Flexi-carbon Leg``
    | [<JsonUnionCase(@"Enh. Armored Leg")>] ``Enh_ Armored Leg``
    | [<JsonUnionCase(@"Arachnoskeleton")>] ``Arachnoskeleton``
    | [<JsonUnionCase(@"Myomer Leg")>] ``Myomer Leg``
    | [<JsonUnionCase(@"Adv. VSS Leg")>] ``Adv_ VSS Leg``
    | [<JsonUnionCase(@"Adv. Myomer Leg")>] ``Adv_ Myomer Leg``
    | [<JsonUnionCase(@"Exp. Flexi-carbon Leg")>] ``Exp_ Flexi-carbon Leg``
    | [<JsonUnionCase(@"Zio. Composite Leg II")>] ``Zio_ Composite Leg II``
    | [<JsonUnionCase(@"Cargo Legs")>] ``Cargo Legs``
    | [<JsonUnionCase(@"Etherial Tendrils")>] ``Etherial Tendrils``
    | [<JsonUnionCase(@"Biometal Leg")>] ``Biometal Leg``
    | [<JsonUnionCase(@"Hvy. Armored Exoskeleton")>] ``Hvy_ Armored Exoskeleton``
    | [<JsonUnionCase(@"Enh. Biometal Leg")>] ``Enh_ Biometal Leg``
    | [<JsonUnionCase(@"Exp. Myomer Leg")>] ``Exp_ Myomer Leg``
    | [<JsonUnionCase(@"Tripod Weapons Platform")>] ``Tripod Weapons Platform``
    | [<JsonUnionCase(@"T.R.O.L.L. Exoskeleton")>] ``T_R_O_L_L_ Exoskeleton``
    | [<JsonUnionCase(@"Asb. Alloy Leg")>] ``Asb_ Alloy Leg``
    | [<JsonUnionCase(@"Centrium Leg")>] ``Centrium Leg``
    | [<JsonUnionCase(@"Hdn. Centrium Leg")>] ``Hdn_ Centrium Leg``
    | [<JsonUnionCase(@"Exp. Biometal Leg")>] ``Exp_ Biometal Leg``
    | [<JsonUnionCase(@"Zio. Supercomposite Leg")>] ``Zio_ Supercomposite Leg``
    | [<JsonUnionCase(@"Potential Leg")>] ``Potential Leg``
    | [<JsonUnionCase(@"Myomer Exoskeleton")>] ``Myomer Exoskeleton``
    | [<JsonUnionCase(@"Sigix Exoskeleton")>] ``Sigix Exoskeleton``
    | [<JsonUnionCase(@"SE_PR1")>] ``SE_PR1``
    | [<JsonUnionCase(@"Wheel")>] ``Wheel``
    | [<JsonUnionCase(@"Com. Wheel")>] ``Com_ Wheel``
    | [<JsonUnionCase(@"Arm. Wheel")>] ``Arm_ Wheel``
    | [<JsonUnionCase(@"Sub. Monowheel")>] ``Sub_ Monowheel``
    | [<JsonUnionCase(@"Ovr. Scrapsphere")>] ``Ovr_ Scrapsphere``
    | [<JsonUnionCase(@"Arm. Huge Wheel")>] ``Arm_ Huge Wheel``
    | [<JsonUnionCase(@"Ballwheel")>] ``Ballwheel``
    | [<JsonUnionCase(@"Ovr. Huge Scrapsphere")>] ``Ovr_ Huge Scrapsphere``
    | [<JsonUnionCase(@"Centrium Wheel")>] ``Centrium Wheel``
    | [<JsonUnionCase(@"Hdn. Centrium Wheel")>] ``Hdn_ Centrium Wheel``
    | [<JsonUnionCase(@"Hover Unit")>] ``Hover Unit``
    | [<JsonUnionCase(@"Backup Propulsion I")>] ``Backup Propulsion I``
    | [<JsonUnionCase(@"Imp. Hover Unit")>] ``Imp_ Hover Unit``
    | [<JsonUnionCase(@"Airjet")>] ``Airjet``
    | [<JsonUnionCase(@"Aerolev Unit")>] ``Aerolev Unit``
    | [<JsonUnionCase(@"Asb. Hover Unit")>] ``Asb_ Hover Unit``
    | [<JsonUnionCase(@"Backup Propulsion III")>] ``Backup Propulsion III``
    | [<JsonUnionCase(@"Gravmag System")>] ``Gravmag System``
    | [<JsonUnionCase(@"Asb. Hover System")>] ``Asb_ Hover System``
    | [<JsonUnionCase(@"Imp. Airjet")>] ``Imp_ Airjet``
    | [<JsonUnionCase(@"Cld. Airjet")>] ``Cld_ Airjet``
    | [<JsonUnionCase(@"Imp. Gravmag System")>] ``Imp_ Gravmag System``
    | [<JsonUnionCase(@"Cld. Aerolev Unit")>] ``Cld_ Aerolev Unit``
    | [<JsonUnionCase(@"Cmb. Airjet")>] ``Cmb_ Airjet``
    | [<JsonUnionCase(@"Gravmag Array")>] ``Gravmag Array``
    | [<JsonUnionCase(@"Mak. Hover Unit")>] ``Mak_ Hover Unit``
    | [<JsonUnionCase(@"Zio. Glidesys I")>] ``Zio_ Glidesys I``
    | [<JsonUnionCase(@"Antigrav System")>] ``Antigrav System``
    | [<JsonUnionCase(@"Gyrokinetic Inverter")>] ``Gyrokinetic Inverter``
    | [<JsonUnionCase(@"Linear Gravjet")>] ``Linear Gravjet``
    | [<JsonUnionCase(@"Cld. Gravmag System")>] ``Cld_ Gravmag System``
    | [<JsonUnionCase(@"Cmb. Gravmag System")>] ``Cmb_ Gravmag System``
    | [<JsonUnionCase(@"Imp. Antigrav System")>] ``Imp_ Antigrav System``
    | [<JsonUnionCase(@"Imp. Gyrokinetic Inverter")>] ``Imp_ Gyrokinetic Inverter``
    | [<JsonUnionCase(@"Imp. Linear Gravjet")>] ``Imp_ Linear Gravjet``
    | [<JsonUnionCase(@"Backup Propulsion VII")>] ``Backup Propulsion VII``
    | [<JsonUnionCase(@"Zio. Glidesys II")>] ``Zio_ Glidesys II``
    | [<JsonUnionCase(@"Cld. Antigrav System")>] ``Cld_ Antigrav System``
    | [<JsonUnionCase(@"Cmb. Antigrav System")>] ``Cmb_ Antigrav System``
    | [<JsonUnionCase(@"Antigrav Array")>] ``Antigrav Array``
    | [<JsonUnionCase(@"Exp. Gyrokinetic Inverter")>] ``Exp_ Gyrokinetic Inverter``
    | [<JsonUnionCase(@"Cld. Linear Gravjet")>] ``Cld_ Linear Gravjet``
    | [<JsonUnionCase(@"Cmb. Linear Gravjet")>] ``Cmb_ Linear Gravjet``
    | [<JsonUnionCase(@"Flight Unit")>] ``Flight Unit``
    | [<JsonUnionCase(@"VTOL Module")>] ``VTOL Module``
    | [<JsonUnionCase(@"Imp. Flight Unit")>] ``Imp_ Flight Unit``
    | [<JsonUnionCase(@"Cesium-ion Thruster")>] ``Cesium-ion Thruster``
    | [<JsonUnionCase(@"Surge Thruster")>] ``Surge Thruster``
    | [<JsonUnionCase(@"Imp. VTOL Module")>] ``Imp_ VTOL Module``
    | [<JsonUnionCase(@"Xenon Bombardment Thruster")>] ``Xenon Bombardment Thruster``
    | [<JsonUnionCase(@"Imp. Cesium-ion Thruster")>] ``Imp_ Cesium-ion Thruster``
    | [<JsonUnionCase(@"Cld. VTOL Module")>] ``Cld_ VTOL Module``
    | [<JsonUnionCase(@"Mak. Flight Unit")>] ``Mak_ Flight Unit``
    | [<JsonUnionCase(@"Nuclear Pulse Thruster")>] ``Nuclear Pulse Thruster``
    | [<JsonUnionCase(@"Imp. Surge Thruster")>] ``Imp_ Surge Thruster``
    | [<JsonUnionCase(@"Mni. Nuclear Pulse Thruster")>] ``Mni_ Nuclear Pulse Thruster``
    | [<JsonUnionCase(@"Cld. Cesium-ion Thruster")>] ``Cld_ Cesium-ion Thruster``
    | [<JsonUnionCase(@"Biomechanical Wings")>] ``Biomechanical Wings``
    | [<JsonUnionCase(@"Field Propulsion Drive")>] ``Field Propulsion Drive``
    | [<JsonUnionCase(@"Cld. Nuclear Pulse Thruster")>] ``Cld_ Nuclear Pulse Thruster``
    | [<JsonUnionCase(@"Exp. Cesium-ion Thruster")>] ``Exp_ Cesium-ion Thruster``
    | [<JsonUnionCase(@"Nuclear Pulse Array")>] ``Nuclear Pulse Array``
    | [<JsonUnionCase(@"Mak. Microthruster")>] ``Mak_ Microthruster``
    | [<JsonUnionCase(@"Impulse Thruster")>] ``Impulse Thruster``
    | [<JsonUnionCase(@"Adv. Surge Thruster")>] ``Adv_ Surge Thruster``
    | [<JsonUnionCase(@"Cld. Field Propulsion Drive")>] ``Cld_ Field Propulsion Drive``
    | [<JsonUnionCase(@"Field Propulsion Array")>] ``Field Propulsion Array``
    | [<JsonUnionCase(@"Diametric Drive")>] ``Diametric Drive``
    | [<JsonUnionCase(@"Flying Fortress v7")>] ``Flying Fortress v7``
    | [<JsonUnionCase(@"T-thruster")>] ``T-thruster``
    | [<JsonUnionCase(@"Integrated Tracker Drive")>] ``Integrated Tracker Drive``
    | [<JsonUnionCase(@"Etherial Propulsion")>] ``Etherial Propulsion``
    | [<JsonUnionCase(@"Q-thruster")>] ``Q-thruster``
    | [<JsonUnionCase(@"Electron Diverter")>] ``Electron Diverter``
    | [<JsonUnionCase(@"Imp. Diametric Drive")>] ``Imp_ Diametric Drive``
    | [<JsonUnionCase(@"Cld. Impulse Thruster")>] ``Cld_ Impulse Thruster``
    | [<JsonUnionCase(@"Impulse Thruster Array")>] ``Impulse Thruster Array``
    | [<JsonUnionCase(@"Flightbrick")>] ``Flightbrick``
    | [<JsonUnionCase(@"Imp. Q-thruster")>] ``Imp_ Q-thruster``
    | [<JsonUnionCase(@"Cld. Q-thruster")>] ``Cld_ Q-thruster``
    | [<JsonUnionCase(@"Exp. Q-thruster")>] ``Exp_ Q-thruster``
    | [<JsonUnionCase(@"Scrap Engine")>] ``Scrap Engine``
    | [<JsonUnionCase(@"Arm. Scrap Engine")>] ``Arm_ Scrap Engine``
    | [<JsonUnionCase(@"Scrap Suit")>] ``Scrap Suit``
    | [<JsonUnionCase(@"Matter Focus")>] ``Matter Focus``
    | [<JsonUnionCase(@"Desublimator")>] ``Desublimator``
    | [<JsonUnionCase(@"Power Amplifier")>] ``Power Amplifier``
    | [<JsonUnionCase(@"Adv. Power Amplifier")>] ``Adv_ Power Amplifier``
    | [<JsonUnionCase(@"Exp. Power Amplifier")>] ``Exp_ Power Amplifier``
    | [<JsonUnionCase(@"Thermal Generator")>] ``Thermal Generator``
    | [<JsonUnionCase(@"Imp. Thermal Generator")>] ``Imp_ Thermal Generator``
    | [<JsonUnionCase(@"Adv. Thermal Generator")>] ``Adv_ Thermal Generator``
    | [<JsonUnionCase(@"Exp. Thermal Generator")>] ``Exp_ Thermal Generator``
    | [<JsonUnionCase(@"Cryofiber Web")>] ``Cryofiber Web``
    | [<JsonUnionCase(@"Imp. Cryofiber Web")>] ``Imp_ Cryofiber Web``
    | [<JsonUnionCase(@"Adv. Cryofiber Web")>] ``Adv_ Cryofiber Web``
    | [<JsonUnionCase(@"Exp. Cryofiber Web")>] ``Exp_ Cryofiber Web``
    | [<JsonUnionCase(@"Heat Sink")>] ``Heat Sink``
    | [<JsonUnionCase(@"Imp. Heat Sink")>] ``Imp_ Heat Sink``
    | [<JsonUnionCase(@"Adv. Heat Sink")>] ``Adv_ Heat Sink``
    | [<JsonUnionCase(@"Exp. Heat Sink")>] ``Exp_ Heat Sink``
    | [<JsonUnionCase(@"Cooling System")>] ``Cooling System``
    | [<JsonUnionCase(@"Imp. Cooling System")>] ``Imp_ Cooling System``
    | [<JsonUnionCase(@"Adv. Cooling System")>] ``Adv_ Cooling System``
    | [<JsonUnionCase(@"Exp. Cooling System")>] ``Exp_ Cooling System``
    | [<JsonUnionCase(@"Mak. Coolant Network")>] ``Mak_ Coolant Network``
    | [<JsonUnionCase(@"Coolant Network")>] ``Coolant Network``
    | [<JsonUnionCase(@"Asb. Nanovents")>] ``Asb_ Nanovents``
    | [<JsonUnionCase(@"2N-1CE's Frost Array")>] ``2N-1CE's Frost Array``
    | [<JsonUnionCase(@"Disposable Heat Sink")>] ``Disposable Heat Sink``
    | [<JsonUnionCase(@"Coolant Injector")>] ``Coolant Injector``
    | [<JsonUnionCase(@"Imp. Coolant Injector")>] ``Imp_ Coolant Injector``
    | [<JsonUnionCase(@"Adv. Coolant Injector")>] ``Adv_ Coolant Injector``
    | [<JsonUnionCase(@"Exp. Coolant Injector")>] ``Exp_ Coolant Injector``
    | [<JsonUnionCase(@"Mak. Microdissipator Network")>] ``Mak_ Microdissipator Network``
    | [<JsonUnionCase(@"Sml. Storage Unit")>] ``Sml_ Storage Unit``
    | [<JsonUnionCase(@"Med. Storage Unit")>] ``Med_ Storage Unit``
    | [<JsonUnionCase(@"Lrg. Storage Unit")>] ``Lrg_ Storage Unit``
    | [<JsonUnionCase(@"Hcp. Storage Unit")>] ``Hcp_ Storage Unit``
    | [<JsonUnionCase(@"Huge Storage Unit")>] ``Huge Storage Unit``
    | [<JsonUnionCase(@"Cargo Storage Unit")>] ``Cargo Storage Unit``
    | [<JsonUnionCase(@"Humpback")>] ``Humpback``
    | [<JsonUnionCase(@"Vmp. Humpback")>] ``Vmp_ Humpback``
    | [<JsonUnionCase(@"Lightpack 2.0")>] ``Lightpack 2_0``
    | [<JsonUnionCase(@"Sml. Battery")>] ``Sml_ Battery``
    | [<JsonUnionCase(@"Med. Battery")>] ``Med_ Battery``
    | [<JsonUnionCase(@"Lrg. Battery")>] ``Lrg_ Battery``
    | [<JsonUnionCase(@"Hcp. Battery")>] ``Hcp_ Battery``
    | [<JsonUnionCase(@"Com. Battery")>] ``Com_ Battery``
    | [<JsonUnionCase(@"Energy Well")>] ``Energy Well``
    | [<JsonUnionCase(@"Imp. Energy Well")>] ``Imp_ Energy Well``
    | [<JsonUnionCase(@"Adv. Energy Well")>] ``Adv_ Energy Well``
    | [<JsonUnionCase(@"Exp. Energy Well")>] ``Exp_ Energy Well``
    | [<JsonUnionCase(@"Zio. Biocell")>] ``Zio_ Biocell``
    | [<JsonUnionCase(@"Asb. Biocell Array")>] ``Asb_ Biocell Array``
    | [<JsonUnionCase(@"Zio. Biocell Array")>] ``Zio_ Biocell Array``
    | [<JsonUnionCase(@"Superbattery")>] ``Superbattery``
    | [<JsonUnionCase(@"Sml. Matter Pod")>] ``Sml_ Matter Pod``
    | [<JsonUnionCase(@"Med. Matter Pod")>] ``Med_ Matter Pod``
    | [<JsonUnionCase(@"Lrg. Matter Pod")>] ``Lrg_ Matter Pod``
    | [<JsonUnionCase(@"Hcp. Matter Pod")>] ``Hcp_ Matter Pod``
    | [<JsonUnionCase(@"Com. Matter Pod")>] ``Com_ Matter Pod``
    | [<JsonUnionCase(@"Matter Compressor")>] ``Matter Compressor``
    | [<JsonUnionCase(@"Imp. Matter Compressor")>] ``Imp_ Matter Compressor``
    | [<JsonUnionCase(@"Adv. Matter Compressor")>] ``Adv_ Matter Compressor``
    | [<JsonUnionCase(@"Exp. Matter Compressor")>] ``Exp_ Matter Compressor``
    | [<JsonUnionCase(@"YI-UF0's Bottomless Matter Pit")>] ``YI-UF0's Bottomless Matter Pit``
    | [<JsonUnionCase(@"Weight Redist. System")>] ``Weight Redist_ System``
    | [<JsonUnionCase(@"Adv. Weight Redist. System")>] ``Adv_ Weight Redist_ System``
    | [<JsonUnionCase(@"Gravity Neutralizer")>] ``Gravity Neutralizer``
    | [<JsonUnionCase(@"Adv. Gravity Neutralizer")>] ``Adv_ Gravity Neutralizer``
    | [<JsonUnionCase(@"Quantum Shading Machine")>] ``Quantum Shading Machine``
    | [<JsonUnionCase(@"Asb. Suspension Frame")>] ``Asb_ Suspension Frame``
    | [<JsonUnionCase(@"Adv. Quantum Shading Machine")>] ``Adv_ Quantum Shading Machine``
    | [<JsonUnionCase(@"Rocket Booster")>] ``Rocket Booster``
    | [<JsonUnionCase(@"Asb. Metafiber Network")>] ``Asb_ Metafiber Network``
    | [<JsonUnionCase(@"Zio. Metafield Generator")>] ``Zio_ Metafield Generator``
    | [<JsonUnionCase(@"ST Field Compressor")>] ``ST Field Compressor``
    | [<JsonUnionCase(@"Siege Articulator")>] ``Siege Articulator``
    | [<JsonUnionCase(@"Structural Scanner")>] ``Structural Scanner``
    | [<JsonUnionCase(@"Deep Structural Scanner")>] ``Deep Structural Scanner``
    | [<JsonUnionCase(@"Trap Scanner")>] ``Trap Scanner``
    | [<JsonUnionCase(@"Imp. Trap Scanner")>] ``Imp_ Trap Scanner``
    | [<JsonUnionCase(@"Mak. Trap Scanner")>] ``Mak_ Trap Scanner``
    | [<JsonUnionCase(@"Adv. Trap Scanner")>] ``Adv_ Trap Scanner``
    | [<JsonUnionCase(@"Machine Analyzer")>] ``Machine Analyzer``
    | [<JsonUnionCase(@"Triangulator")>] ``Triangulator``
    | [<JsonUnionCase(@"Visual Processing Unit")>] ``Visual Processing Unit``
    | [<JsonUnionCase(@"Sub. Optics")>] ``Sub_ Optics``
    | [<JsonUnionCase(@"Adv. Visual Processing Unit")>] ``Adv_ Visual Processing Unit``
    | [<JsonUnionCase(@"Enh. Optical Array")>] ``Enh_ Optical Array``
    | [<JsonUnionCase(@"Exp. Optical Array")>] ``Exp_ Optical Array``
    | [<JsonUnionCase(@"Spectral Analyzer")>] ``Spectral Analyzer``
    | [<JsonUnionCase(@"Sensor Array")>] ``Sensor Array``
    | [<JsonUnionCase(@"Imp. Sensor Array")>] ``Imp_ Sensor Array``
    | [<JsonUnionCase(@"Adv. Sensor Array")>] ``Adv_ Sensor Array``
    | [<JsonUnionCase(@"Lrn. Sensor Array")>] ``Lrn_ Sensor Array``
    | [<JsonUnionCase(@"Mak. Sensor Array")>] ``Mak_ Sensor Array``
    | [<JsonUnionCase(@"Exp. Sensor Array")>] ``Exp_ Sensor Array``
    | [<JsonUnionCase(@"Signal Interpreter")>] ``Signal Interpreter``
    | [<JsonUnionCase(@"Imp. Signal Interpreter")>] ``Imp_ Signal Interpreter``
    | [<JsonUnionCase(@"Adv. Signal Interpreter")>] ``Adv_ Signal Interpreter``
    | [<JsonUnionCase(@"Exp. Signal Interpreter")>] ``Exp_ Signal Interpreter``
    | [<JsonUnionCase(@"Active Sensor Suite")>] ``Active Sensor Suite``
    | [<JsonUnionCase(@"Terrain Scanner")>] ``Terrain Scanner``
    | [<JsonUnionCase(@"Imp. Terrain Scanner")>] ``Imp_ Terrain Scanner``
    | [<JsonUnionCase(@"Adv. Terrain Scanner")>] ``Adv_ Terrain Scanner``
    | [<JsonUnionCase(@"Mak. Terrain Scanner")>] ``Mak_ Terrain Scanner``
    | [<JsonUnionCase(@"Lrn. Terrain Scanner")>] ``Lrn_ Terrain Scanner``
    | [<JsonUnionCase(@"Exp. Terrain Scanner")>] ``Exp_ Terrain Scanner``
    | [<JsonUnionCase(@"Surveybot 24 Scanner")>] ``Surveybot 24 Scanner``
    | [<JsonUnionCase(@"Terrain Scan Processor")>] ``Terrain Scan Processor``
    | [<JsonUnionCase(@"Imp. Terrain Scan Processor")>] ``Imp_ Terrain Scan Processor``
    | [<JsonUnionCase(@"Mak. Terrain Scan Processor")>] ``Mak_ Terrain Scan Processor``
    | [<JsonUnionCase(@"Adv. Terrain Scan Processor")>] ``Adv_ Terrain Scan Processor``
    | [<JsonUnionCase(@"Exp. Terrain Scan Processor")>] ``Exp_ Terrain Scan Processor``
    | [<JsonUnionCase(@"Surveybot 17 Chip")>] ``Surveybot 17 Chip``
    | [<JsonUnionCase(@"Surveybot 24 Chip")>] ``Surveybot 24 Chip``
    | [<JsonUnionCase(@"Seismic Detector")>] ``Seismic Detector``
    | [<JsonUnionCase(@"Transport Network Coupler")>] ``Transport Network Coupler``
    | [<JsonUnionCase(@"Modified TNC")>] ``Modified TNC``
    | [<JsonUnionCase(@"Encrypted Comm Array")>] ``Encrypted Comm Array``
    | [<JsonUnionCase(@"0b10 Decoder Chip [Generic]")>] ``0b10 Decoder Chip _Generic_``
    | [<JsonUnionCase(@"0b10 Decoder Chip [Looter]")>] ``0b10 Decoder Chip _Looter_``
    | [<JsonUnionCase(@"0b10 Decoder Chip [Scout]")>] ``0b10 Decoder Chip _Scout_``
    | [<JsonUnionCase(@"0b10 Decoder Chip [Skirmisher]")>] ``0b10 Decoder Chip _Skirmisher_``
    | [<JsonUnionCase(@"0b10 Alert Chip")>] ``0b10 Alert Chip``
    | [<JsonUnionCase(@"Salvage Targeting Computer")>] ``Salvage Targeting Computer``
    | [<JsonUnionCase(@"Imp. Salvage Targeting Computer")>] ``Imp_ Salvage Targeting Computer``
    | [<JsonUnionCase(@"Mak. Salvage Targeting Computer")>] ``Mak_ Salvage Targeting Computer``
    | [<JsonUnionCase(@"Adv. Salvage Targeting Computer")>] ``Adv_ Salvage Targeting Computer``
    | [<JsonUnionCase(@"Asb. Combat Suite")>] ``Asb_ Combat Suite``
    | [<JsonUnionCase(@"Targeting Computer")>] ``Targeting Computer``
    | [<JsonUnionCase(@"Imp. Targeting Computer")>] ``Imp_ Targeting Computer``
    | [<JsonUnionCase(@"Mak. Targeting Computer")>] ``Mak_ Targeting Computer``
    | [<JsonUnionCase(@"Adv. Targeting Computer")>] ``Adv_ Targeting Computer``
    | [<JsonUnionCase(@"Exp. Targeting Computer")>] ``Exp_ Targeting Computer``
    | [<JsonUnionCase(@"Multitargeting Array")>] ``Multitargeting Array``
    | [<JsonUnionCase(@"Tactical Coordination Suite")>] ``Tactical Coordination Suite``
    | [<JsonUnionCase(@"Melee Analysis Suite")>] ``Melee Analysis Suite``
    | [<JsonUnionCase(@"Imp. Melee Analysis Suite")>] ``Imp_ Melee Analysis Suite``
    | [<JsonUnionCase(@"Adv. Melee Analysis Suite")>] ``Adv_ Melee Analysis Suite``
    | [<JsonUnionCase(@"Exp. Melee Analysis Suite")>] ``Exp_ Melee Analysis Suite``
    | [<JsonUnionCase(@"Launcher Guidance Computer")>] ``Launcher Guidance Computer``
    | [<JsonUnionCase(@"Imp. Launcher Guidance Computer")>] ``Imp_ Launcher Guidance Computer``
    | [<JsonUnionCase(@"Adv. Launcher Guidance Computer")>] ``Adv_ Launcher Guidance Computer``
    | [<JsonUnionCase(@"Weapon Mount")>] ``Weapon Mount``
    | [<JsonUnionCase(@"Target Analyzer")>] ``Target Analyzer``
    | [<JsonUnionCase(@"Imp. Target Analyzer")>] ``Imp_ Target Analyzer``
    | [<JsonUnionCase(@"Adv. Target Analyzer")>] ``Adv_ Target Analyzer``
    | [<JsonUnionCase(@"Exp. Target Analyzer")>] ``Exp_ Target Analyzer``
    | [<JsonUnionCase(@"Core Analyzer")>] ``Core Analyzer``
    | [<JsonUnionCase(@"Exp. Core Analyzer")>] ``Exp_ Core Analyzer``
    | [<JsonUnionCase(@"Armor Integrity Analyzer")>] ``Armor Integrity Analyzer``
    | [<JsonUnionCase(@"Imp. Armor Integrity Analyzer")>] ``Imp_ Armor Integrity Analyzer``
    | [<JsonUnionCase(@"Exp. Armor Integrity Analyzer")>] ``Exp_ Armor Integrity Analyzer``
    | [<JsonUnionCase(@"Recoil Stabilizer")>] ``Recoil Stabilizer``
    | [<JsonUnionCase(@"Recoil Nullifier")>] ``Recoil Nullifier``
    | [<JsonUnionCase(@"Matter Filter")>] ``Matter Filter``
    | [<JsonUnionCase(@"Prc. Matter Filter")>] ``Prc_ Matter Filter``
    | [<JsonUnionCase(@"Energy Filter")>] ``Energy Filter``
    | [<JsonUnionCase(@"Prc. Energy Filter")>] ``Prc_ Energy Filter``
    | [<JsonUnionCase(@"Particle Charger")>] ``Particle Charger``
    | [<JsonUnionCase(@"Imp. Particle Charger")>] ``Imp_ Particle Charger``
    | [<JsonUnionCase(@"Adv. Particle Charger")>] ``Adv_ Particle Charger``
    | [<JsonUnionCase(@"Particle Accelerator")>] ``Particle Accelerator``
    | [<JsonUnionCase(@"Imp. Particle Accelerator")>] ``Imp_ Particle Accelerator``
    | [<JsonUnionCase(@"Adv. Particle Accelerator")>] ``Adv_ Particle Accelerator``
    | [<JsonUnionCase(@"Kinecellerator")>] ``Kinecellerator``
    | [<JsonUnionCase(@"Imp. Kinecellerator")>] ``Imp_ Kinecellerator``
    | [<JsonUnionCase(@"Adv. Kinecellerator")>] ``Adv_ Kinecellerator``
    | [<JsonUnionCase(@"Expert System")>] ``Expert System``
    | [<JsonUnionCase(@"Heavy Servo Lattice")>] ``Heavy Servo Lattice``
    | [<JsonUnionCase(@"VL-GR5's Timing Chip")>] ``VL-GR5's Timing Chip``
    | [<JsonUnionCase(@"Launcher Loader")>] ``Launcher Loader``
    | [<JsonUnionCase(@"Quantum Capacitor")>] ``Quantum Capacitor``
    | [<JsonUnionCase(@"Weapon Cycler")>] ``Weapon Cycler``
    | [<JsonUnionCase(@"Imp. Weapon Cycler")>] ``Imp_ Weapon Cycler``
    | [<JsonUnionCase(@"Adv. Weapon Cycler")>] ``Adv_ Weapon Cycler``
    | [<JsonUnionCase(@"Exp. Weapon Cycler")>] ``Exp_ Weapon Cycler``
    | [<JsonUnionCase(@"Microactuators")>] ``Microactuators``
    | [<JsonUnionCase(@"Nanoactuators")>] ``Nanoactuators``
    | [<JsonUnionCase(@"Femtoactuators")>] ``Femtoactuators``
    | [<JsonUnionCase(@"Actuator Array")>] ``Actuator Array``
    | [<JsonUnionCase(@"Imp. Actuator Array")>] ``Imp_ Actuator Array``
    | [<JsonUnionCase(@"Adv. Actuator Array")>] ``Adv_ Actuator Array``
    | [<JsonUnionCase(@"Exp. Actuator Array")>] ``Exp_ Actuator Array``
    | [<JsonUnionCase(@"Force Booster")>] ``Force Booster``
    | [<JsonUnionCase(@"Imp. Force Booster")>] ``Imp_ Force Booster``
    | [<JsonUnionCase(@"Adv. Force Booster")>] ``Adv_ Force Booster``
    | [<JsonUnionCase(@"Stasis Canceller")>] ``Stasis Canceller``
    | [<JsonUnionCase(@"Transmission Jammer")>] ``Transmission Jammer``
    | [<JsonUnionCase(@"Mak. Transmission Jammer")>] ``Mak_ Transmission Jammer``
    | [<JsonUnionCase(@"Imp. Transmission Jammer")>] ``Imp_ Transmission Jammer``
    | [<JsonUnionCase(@"Adv. Transmission Jammer")>] ``Adv_ Transmission Jammer``
    | [<JsonUnionCase(@"Exp. Transmission Jammer")>] ``Exp_ Transmission Jammer``
    | [<JsonUnionCase(@"ECM Suite")>] ``ECM Suite``
    | [<JsonUnionCase(@"Mak. ECM Suite")>] ``Mak_ ECM Suite``
    | [<JsonUnionCase(@"Adv. ECM Suite")>] ``Adv_ ECM Suite``
    | [<JsonUnionCase(@"Exp. ECM Suite")>] ``Exp_ ECM Suite``
    | [<JsonUnionCase(@"Active Sensor Spoofer")>] ``Active Sensor Spoofer``
    | [<JsonUnionCase(@"Reaction Control System")>] ``Reaction Control System``
    | [<JsonUnionCase(@"Imp. Reaction Control System")>] ``Imp_ Reaction Control System``
    | [<JsonUnionCase(@"Adv. Reaction Control System")>] ``Adv_ Reaction Control System``
    | [<JsonUnionCase(@"Exp. Reaction Control System")>] ``Exp_ Reaction Control System``
    | [<JsonUnionCase(@"Phase Shifter")>] ``Phase Shifter``
    | [<JsonUnionCase(@"Imp. Phase Shifter")>] ``Imp_ Phase Shifter``
    | [<JsonUnionCase(@"Adv. Phase Shifter")>] ``Adv_ Phase Shifter``
    | [<JsonUnionCase(@"Exp. Phase Shifter")>] ``Exp_ Phase Shifter``
    | [<JsonUnionCase(@"Cloaking Device")>] ``Cloaking Device``
    | [<JsonUnionCase(@"Mak. Cloaking Device")>] ``Mak_ Cloaking Device``
    | [<JsonUnionCase(@"Imp. Cloaking Device")>] ``Imp_ Cloaking Device``
    | [<JsonUnionCase(@"Adv. Cloaking Device")>] ``Adv_ Cloaking Device``
    | [<JsonUnionCase(@"Exp. Cloaking Device")>] ``Exp_ Cloaking Device``
    | [<JsonUnionCase(@"Cloak of Protection")>] ``Cloak of Protection``
    | [<JsonUnionCase(@"5H-AD0's Cloak")>] ``5H-AD0's Cloak``
    | [<JsonUnionCase(@"ID Mask")>] ``ID Mask``
    | [<JsonUnionCase(@"Core Shielding")>] ``Core Shielding``
    | [<JsonUnionCase(@"Imp. Core Shielding")>] ``Imp_ Core Shielding``
    | [<JsonUnionCase(@"Mak. Core Shielding")>] ``Mak_ Core Shielding``
    | [<JsonUnionCase(@"Exp. Core Shielding")>] ``Exp_ Core Shielding``
    | [<JsonUnionCase(@"Power Shielding")>] ``Power Shielding``
    | [<JsonUnionCase(@"Imp. Power Shielding")>] ``Imp_ Power Shielding``
    | [<JsonUnionCase(@"Mak. Power Shielding")>] ``Mak_ Power Shielding``
    | [<JsonUnionCase(@"Exp. Power Shielding")>] ``Exp_ Power Shielding``
    | [<JsonUnionCase(@"Propulsion Shielding")>] ``Propulsion Shielding``
    | [<JsonUnionCase(@"Imp. Propulsion Shielding")>] ``Imp_ Propulsion Shielding``
    | [<JsonUnionCase(@"Mak. Propulsion Shielding")>] ``Mak_ Propulsion Shielding``
    | [<JsonUnionCase(@"Exp. Propulsion Shielding")>] ``Exp_ Propulsion Shielding``
    | [<JsonUnionCase(@"Utility Shielding")>] ``Utility Shielding``
    | [<JsonUnionCase(@"Imp. Utility Shielding")>] ``Imp_ Utility Shielding``
    | [<JsonUnionCase(@"Mak. Utility Shielding")>] ``Mak_ Utility Shielding``
    | [<JsonUnionCase(@"Exp. Utility Shielding")>] ``Exp_ Utility Shielding``
    | [<JsonUnionCase(@"Weapon Shielding")>] ``Weapon Shielding``
    | [<JsonUnionCase(@"Imp. Weapon Shielding")>] ``Imp_ Weapon Shielding``
    | [<JsonUnionCase(@"Mak. Weapon Shielding")>] ``Mak_ Weapon Shielding``
    | [<JsonUnionCase(@"Exp. Weapon Shielding")>] ``Exp_ Weapon Shielding``
    | [<JsonUnionCase(@"Zio. Weapon Casing")>] ``Zio_ Weapon Casing``
    | [<JsonUnionCase(@"Backup Plating I")>] ``Backup Plating I``
    | [<JsonUnionCase(@"Backup Plating III")>] ``Backup Plating III``
    | [<JsonUnionCase(@"Backup Plating VII")>] ``Backup Plating VII``
    | [<JsonUnionCase(@"Lgt. Armor Plating")>] ``Lgt_ Armor Plating``
    | [<JsonUnionCase(@"Med. Armor Plating")>] ``Med_ Armor Plating``
    | [<JsonUnionCase(@"Hvy. Armor Plating")>] ``Hvy_ Armor Plating``
    | [<JsonUnionCase(@"Zio. Light Carapace")>] ``Zio_ Light Carapace``
    | [<JsonUnionCase(@"Zio. Heavy Carapace")>] ``Zio_ Heavy Carapace``
    | [<JsonUnionCase(@"Hrd. Light Armor Plating")>] ``Hrd_ Light Armor Plating``
    | [<JsonUnionCase(@"Hrd. Medium Armor Plating")>] ``Hrd_ Medium Armor Plating``
    | [<JsonUnionCase(@"Hrd. Heavy Armor Plating")>] ``Hrd_ Heavy Armor Plating``
    | [<JsonUnionCase(@"Imp. Light Armor Plating")>] ``Imp_ Light Armor Plating``
    | [<JsonUnionCase(@"Imp. Medium Armor Plating")>] ``Imp_ Medium Armor Plating``
    | [<JsonUnionCase(@"Imp. Heavy Armor Plating")>] ``Imp_ Heavy Armor Plating``
    | [<JsonUnionCase(@"Mak. Light Armor Plating")>] ``Mak_ Light Armor Plating``
    | [<JsonUnionCase(@"Mak. Medium Armor Plating")>] ``Mak_ Medium Armor Plating``
    | [<JsonUnionCase(@"Mak. Heavy Armor Plating")>] ``Mak_ Heavy Armor Plating``
    | [<JsonUnionCase(@"Lyr. Light Armor Plating")>] ``Lyr_ Light Armor Plating``
    | [<JsonUnionCase(@"Lyr. Medium Armor Plating")>] ``Lyr_ Medium Armor Plating``
    | [<JsonUnionCase(@"Lyr. Heavy Armor Plating")>] ``Lyr_ Heavy Armor Plating``
    | [<JsonUnionCase(@"Gun Armor")>] ``Gun Armor``
    | [<JsonUnionCase(@"Centrium Light Armor Plating")>] ``Centrium Light Armor Plating``
    | [<JsonUnionCase(@"Centrium Medium Armor Plating")>] ``Centrium Medium Armor Plating``
    | [<JsonUnionCase(@"Centrium Heavy Armor Plating")>] ``Centrium Heavy Armor Plating``
    | [<JsonUnionCase(@"Centrium Linked Plating")>] ``Centrium Linked Plating``
    | [<JsonUnionCase(@"Reactive Plating")>] ``Reactive Plating``
    | [<JsonUnionCase(@"Med. Reactive Plating")>] ``Med_ Reactive Plating``
    | [<JsonUnionCase(@"Mak. Kinetic Plating")>] ``Mak_ Kinetic Plating``
    | [<JsonUnionCase(@"Hvy. Reactive Plating")>] ``Hvy_ Reactive Plating``
    | [<JsonUnionCase(@"Superdense Plating")>] ``Superdense Plating``
    | [<JsonUnionCase(@"Reflective Plating")>] ``Reflective Plating``
    | [<JsonUnionCase(@"Med. Reflective Plating")>] ``Med_ Reflective Plating``
    | [<JsonUnionCase(@"Mak. Thermal Plating")>] ``Mak_ Thermal Plating``
    | [<JsonUnionCase(@"Hvy. Reflective Plating")>] ``Hvy_ Reflective Plating``
    | [<JsonUnionCase(@"8R-AWN's Armor/TH")>] ``8R-AWN's Armor_TH``
    | [<JsonUnionCase(@"8R-AWN's Armor/EX")>] ``8R-AWN's Armor_EX``
    | [<JsonUnionCase(@"Insulated Plating")>] ``Insulated Plating``
    | [<JsonUnionCase(@"Med. Insulated Plating")>] ``Med_ Insulated Plating``
    | [<JsonUnionCase(@"Hvy. Insulated Plating")>] ``Hvy_ Insulated Plating``
    | [<JsonUnionCase(@"Damper Plating")>] ``Damper Plating``
    | [<JsonUnionCase(@"Zio. Shade Carapace")>] ``Zio_ Shade Carapace``
    | [<JsonUnionCase(@"Zio. Shade Armor")>] ``Zio_ Shade Armor``
    | [<JsonUnionCase(@"Asb. Alloy Armor")>] ``Asb_ Alloy Armor``
    | [<JsonUnionCase(@"Mak. Ablative Armor")>] ``Mak_ Ablative Armor``
    | [<JsonUnionCase(@"Active Cooling Armor")>] ``Active Cooling Armor``
    | [<JsonUnionCase(@"Scrap Shield")>] ``Scrap Shield``
    | [<JsonUnionCase(@"Enh. Scrap Shield")>] ``Enh_ Scrap Shield``
    | [<JsonUnionCase(@"Powered Armor")>] ``Powered Armor``
    | [<JsonUnionCase(@"Imp. Powered Armor")>] ``Imp_ Powered Armor``
    | [<JsonUnionCase(@"Adv. Powered Armor")>] ``Adv_ Powered Armor``
    | [<JsonUnionCase(@"Exp. Powered Armor")>] ``Exp_ Powered Armor``
    | [<JsonUnionCase(@"1C-UTU's Buckler")>] ``1C-UTU's Buckler``
    | [<JsonUnionCase(@"Tower Shield")>] ``Tower Shield``
    | [<JsonUnionCase(@"Lgt. Regenerative Plating")>] ``Lgt_ Regenerative Plating``
    | [<JsonUnionCase(@"Med. Regenerative Plating")>] ``Med_ Regenerative Plating``
    | [<JsonUnionCase(@"Hvy. Regenerative Plating")>] ``Hvy_ Regenerative Plating``
    | [<JsonUnionCase(@"SHELL Armor")>] ``SHELL Armor``
    | [<JsonUnionCase(@"Phase Armor")>] ``Phase Armor``
    | [<JsonUnionCase(@"Vmp. Brace Plating")>] ``Vmp_ Brace Plating``
    | [<JsonUnionCase(@"Graphene Brace")>] ``Graphene Brace``
    | [<JsonUnionCase(@"Focal Shield")>] ``Focal Shield``
    | [<JsonUnionCase(@"Imp. Focal Shield")>] ``Imp_ Focal Shield``
    | [<JsonUnionCase(@"Adv. Focal Shield")>] ``Adv_ Focal Shield``
    | [<JsonUnionCase(@"Exp. Focal Shield")>] ``Exp_ Focal Shield``
    | [<JsonUnionCase(@"Thermal Shield")>] ``Thermal Shield``
    | [<JsonUnionCase(@"Imp. Thermal Shield")>] ``Imp_ Thermal Shield``
    | [<JsonUnionCase(@"Adv. Thermal Shield")>] ``Adv_ Thermal Shield``
    | [<JsonUnionCase(@"Exp. Thermal Shield")>] ``Exp_ Thermal Shield``
    | [<JsonUnionCase(@"Thermal Barrier")>] ``Thermal Barrier``
    | [<JsonUnionCase(@"Beam Splitter")>] ``Beam Splitter``
    | [<JsonUnionCase(@"Thermal Defense Suite")>] ``Thermal Defense Suite``
    | [<JsonUnionCase(@"Imp. Thermal Defense Suite")>] ``Imp_ Thermal Defense Suite``
    | [<JsonUnionCase(@"Adv. Thermal Defense Suite")>] ``Adv_ Thermal Defense Suite``
    | [<JsonUnionCase(@"Exp. Thermal Defense Suite")>] ``Exp_ Thermal Defense Suite``
    | [<JsonUnionCase(@"Shock Absorption System")>] ``Shock Absorption System``
    | [<JsonUnionCase(@"Imp. Shock Absorption System")>] ``Imp_ Shock Absorption System``
    | [<JsonUnionCase(@"Exp. Shock Absorption System")>] ``Exp_ Shock Absorption System``
    | [<JsonUnionCase(@"EM Disruption Field")>] ``EM Disruption Field``
    | [<JsonUnionCase(@"Adv. EM Disruption Field")>] ``Adv_ EM Disruption Field``
    | [<JsonUnionCase(@"Exp. EM Disruption Field")>] ``Exp_ EM Disruption Field``
    | [<JsonUnionCase(@"ME-RLN's Chromatic Screen")>] ``ME-RLN's Chromatic Screen``
    | [<JsonUnionCase(@"Hardlight Generator")>] ``Hardlight Generator``
    | [<JsonUnionCase(@"Imp. Hardlight Generator")>] ``Imp_ Hardlight Generator``
    | [<JsonUnionCase(@"Adv. Hardlight Generator")>] ``Adv_ Hardlight Generator``
    | [<JsonUnionCase(@"Exp. Hardlight Generator")>] ``Exp_ Hardlight Generator``
    | [<JsonUnionCase(@"Shield Generator")>] ``Shield Generator``
    | [<JsonUnionCase(@"Imp. Shield Generator")>] ``Imp_ Shield Generator``
    | [<JsonUnionCase(@"Adv. Shield Generator")>] ``Adv_ Shield Generator``
    | [<JsonUnionCase(@"Exp. Shield Generator")>] ``Exp_ Shield Generator``
    | [<JsonUnionCase(@"Force Field")>] ``Force Field``
    | [<JsonUnionCase(@"Imp. Force Field")>] ``Imp_ Force Field``
    | [<JsonUnionCase(@"Adv. Force Field")>] ``Adv_ Force Field``
    | [<JsonUnionCase(@"Exp. Force Field")>] ``Exp_ Force Field``
    | [<JsonUnionCase(@"7V-RTL's Ultimate Field")>] ``7V-RTL's Ultimate Field``
    | [<JsonUnionCase(@"Vortex Field Projector")>] ``Vortex Field Projector``
    | [<JsonUnionCase(@"Remote Shield")>] ``Remote Shield``
    | [<JsonUnionCase(@"Imp. Remote Shield")>] ``Imp_ Remote Shield``
    | [<JsonUnionCase(@"Adv. Remote Shield")>] ``Adv_ Remote Shield``
    | [<JsonUnionCase(@"Remote Force Field")>] ``Remote Force Field``
    | [<JsonUnionCase(@"Imp. Remote Force Field")>] ``Imp_ Remote Force Field``
    | [<JsonUnionCase(@"Energy Mantle")>] ``Energy Mantle``
    | [<JsonUnionCase(@"Imp. Energy Mantle")>] ``Imp_ Energy Mantle``
    | [<JsonUnionCase(@"AEGIS Remote Shield")>] ``AEGIS Remote Shield``
    | [<JsonUnionCase(@"Phase Redirector")>] ``Phase Redirector``
    | [<JsonUnionCase(@"Field Manipulator")>] ``Field Manipulator``
    | [<JsonUnionCase(@"Energy Deflector")>] ``Energy Deflector``
    | [<JsonUnionCase(@"Point Defense System")>] ``Point Defense System``
    | [<JsonUnionCase(@"Point Defense Array")>] ``Point Defense Array``
    | [<JsonUnionCase(@"Antimissile System")>] ``Antimissile System``
    | [<JsonUnionCase(@"EX Chip 1")>] ``EX Chip 1``
    | [<JsonUnionCase(@"Hacking Suite")>] ``Hacking Suite``
    | [<JsonUnionCase(@"Mak. Hacking Suite")>] ``Mak_ Hacking Suite``
    | [<JsonUnionCase(@"Imp. Hacking Suite")>] ``Imp_ Hacking Suite``
    | [<JsonUnionCase(@"Adv. Hacking Suite")>] ``Adv_ Hacking Suite``
    | [<JsonUnionCase(@"Exp. Hacking Suite")>] ``Exp_ Hacking Suite``
    | [<JsonUnionCase(@"System Mapper")>] ``System Mapper``
    | [<JsonUnionCase(@"Deep Network Scanner")>] ``Deep Network Scanner``
    | [<JsonUnionCase(@"Architect God Chip A")>] ``Architect God Chip A``
    | [<JsonUnionCase(@"EX Chip 2")>] ``EX Chip 2``
    | [<JsonUnionCase(@"System Shield")>] ``System Shield``
    | [<JsonUnionCase(@"Mak. System Shield")>] ``Mak_ System Shield``
    | [<JsonUnionCase(@"Imp. System Shield")>] ``Imp_ System Shield``
    | [<JsonUnionCase(@"Adv. System Shield")>] ``Adv_ System Shield``
    | [<JsonUnionCase(@"Exp. System Shield")>] ``Exp_ System Shield``
    | [<JsonUnionCase(@"Ghost Barrier")>] ``Ghost Barrier``
    | [<JsonUnionCase(@"Quantum Router")>] ``Quantum Router``
    | [<JsonUnionCase(@"Architect God Chip D")>] ``Architect God Chip D``
    | [<JsonUnionCase(@"Authchip [R/NC]")>] ``Authchip _R_NC_``
    | [<JsonUnionCase(@"Authchip [R/Combat]")>] ``Authchip _R_Combat_``
    | [<JsonUnionCase(@"Authchip [Power]")>] ``Authchip _Power_``
    | [<JsonUnionCase(@"Authchip [Propulsion]")>] ``Authchip _Propulsion_``
    | [<JsonUnionCase(@"Authchip [Device]")>] ``Authchip _Device_``
    | [<JsonUnionCase(@"Authchip [Storage]")>] ``Authchip _Storage_``
    | [<JsonUnionCase(@"Authchip [Processor]")>] ``Authchip _Processor_``
    | [<JsonUnionCase(@"Authchip [Armor]")>] ``Authchip _Armor_``
    | [<JsonUnionCase(@"Authchip [Weapon]")>] ``Authchip _Weapon_``
    | [<JsonUnionCase(@"Relay Coupler [NC]")>] ``Relay Coupler _NC_``
    | [<JsonUnionCase(@"Relay Coupler [C]")>] ``Relay Coupler _C_``
    | [<JsonUnionCase(@"Relay Coupler [Swarmer]")>] ``Relay Coupler _Swarmer_``
    | [<JsonUnionCase(@"Relay Coupler [Cutter]")>] ``Relay Coupler _Cutter_``
    | [<JsonUnionCase(@"Relay Coupler [Grunt]")>] ``Relay Coupler _Grunt_``
    | [<JsonUnionCase(@"Relay Coupler [Brawler]")>] ``Relay Coupler _Brawler_``
    | [<JsonUnionCase(@"Relay Coupler [Duelist]")>] ``Relay Coupler _Duelist_``
    | [<JsonUnionCase(@"Relay Coupler [Sentry]")>] ``Relay Coupler _Sentry_``
    | [<JsonUnionCase(@"Relay Coupler [Demolisher]")>] ``Relay Coupler _Demolisher_``
    | [<JsonUnionCase(@"Relay Coupler [Specialist]")>] ``Relay Coupler _Specialist_``
    | [<JsonUnionCase(@"Relay Coupler [Hunter]")>] ``Relay Coupler _Hunter_``
    | [<JsonUnionCase(@"Relay Coupler [Heavy]")>] ``Relay Coupler _Heavy_``
    | [<JsonUnionCase(@"Relay Coupler [Behemoth]")>] ``Relay Coupler _Behemoth_``
    | [<JsonUnionCase(@"Relay Coupler [Programmer]")>] ``Relay Coupler _Programmer_``
    | [<JsonUnionCase(@"Relay Coupler [Proto]")>] ``Relay Coupler _Proto_``
    | [<JsonUnionCase(@"Skeleton Box")>] ``Skeleton Box``
    | [<JsonUnionCase(@"01-MTF's Autohacker")>] ``01-MTF's Autohacker``
    | [<JsonUnionCase(@"Component Analysis Suite")>] ``Component Analysis Suite``
    | [<JsonUnionCase(@"Imp. Component Analysis Suite")>] ``Imp_ Component Analysis Suite``
    | [<JsonUnionCase(@"Adv. Component Analysis Suite")>] ``Adv_ Component Analysis Suite``
    | [<JsonUnionCase(@"A0-MCA's Component Scanner")>] ``A0-MCA's Component Scanner``
    | [<JsonUnionCase(@"Tech Extrapolator")>] ``Tech Extrapolator``
    | [<JsonUnionCase(@"Dynamic Insulation System")>] ``Dynamic Insulation System``
    | [<JsonUnionCase(@"Imp. Dynamic Insulation System")>] ``Imp_ Dynamic Insulation System``
    | [<JsonUnionCase(@"Adv. Dynamic Insulation System")>] ``Adv_ Dynamic Insulation System``
    | [<JsonUnionCase(@"System Guard")>] ``System Guard``
    | [<JsonUnionCase(@"Imp. System Guard")>] ``Imp_ System Guard``
    | [<JsonUnionCase(@"Exp. System Guard")>] ``Exp_ System Guard``
    | [<JsonUnionCase(@"Corruption Screen")>] ``Corruption Screen``
    | [<JsonUnionCase(@"Imp. Corruption Screen")>] ``Imp_ Corruption Screen``
    | [<JsonUnionCase(@"Adv. Corruption Screen")>] ``Adv_ Corruption Screen``
    | [<JsonUnionCase(@"System Restoration Module")>] ``System Restoration Module``
    | [<JsonUnionCase(@"Mak. System Restoration Module")>] ``Mak_ System Restoration Module``
    | [<JsonUnionCase(@"Imp. System Restoration Module")>] ``Imp_ System Restoration Module``
    | [<JsonUnionCase(@"Adv. System Restoration Module")>] ``Adv_ System Restoration Module``
    | [<JsonUnionCase(@"System Purifier")>] ``System Purifier``
    | [<JsonUnionCase(@"Exp. System Purifier")>] ``Exp_ System Purifier``
    | [<JsonUnionCase(@"Tractor Beam")>] ``Tractor Beam``
    | [<JsonUnionCase(@"Hpw. Tractor Beam")>] ``Hpw_ Tractor Beam``
    | [<JsonUnionCase(@"Lrn. Tractor Beam")>] ``Lrn_ Tractor Beam``
    | [<JsonUnionCase(@"Mobile Refinery Mk. CCLXVII")>] ``Mobile Refinery Mk_ CCLXVII``
    | [<JsonUnionCase(@"Trap Extractor")>] ``Trap Extractor``
    | [<JsonUnionCase(@"Imp. Trap Extractor")>] ``Imp_ Trap Extractor``
    | [<JsonUnionCase(@"Adv. Trap Extractor")>] ``Adv_ Trap Extractor``
    | [<JsonUnionCase(@"Trap Reconfigurator")>] ``Trap Reconfigurator``
    | [<JsonUnionCase(@"Recalibrator")>] ``Recalibrator``
    | [<JsonUnionCase(@"Imp. Recalibrator")>] ``Imp_ Recalibrator``
    | [<JsonUnionCase(@"Adv. Recalibrator")>] ``Adv_ Recalibrator``
    | [<JsonUnionCase(@"Exp. Recalibrator")>] ``Exp_ Recalibrator``
    | [<JsonUnionCase(@"Field Recycling Unit")>] ``Field Recycling Unit``
    | [<JsonUnionCase(@"Imp. Field Recycling Unit")>] ``Imp_ Field Recycling Unit``
    | [<JsonUnionCase(@"Adv. Field Recycling Unit")>] ``Adv_ Field Recycling Unit``
    | [<JsonUnionCase(@"Exp. Field Recycling Unit")>] ``Exp_ Field Recycling Unit``
    | [<JsonUnionCase(@"Drone Bay")>] ``Drone Bay``
    | [<JsonUnionCase(@"Z-Drone Bay")>] ``Z-Drone Bay``
    | [<JsonUnionCase(@"Mni. Drone Bay")>] ``Mni_ Drone Bay``
    | [<JsonUnionCase(@"Mapping Drone Bay")>] ``Mapping Drone Bay``
    | [<JsonUnionCase(@"Adv. Drone Bay")>] ``Adv_ Drone Bay``
    | [<JsonUnionCase(@"Bomb Drone Bay")>] ``Bomb Drone Bay``
    | [<JsonUnionCase(@"Thief Drone Bay")>] ``Thief Drone Bay``
    | [<JsonUnionCase(@"Decoy Drone Bay")>] ``Decoy Drone Bay``
    | [<JsonUnionCase(@"Splice Drone Bay")>] ``Splice Drone Bay``
    | [<JsonUnionCase(@"Combat Drone Bay")>] ``Combat Drone Bay``
    | [<JsonUnionCase(@"Assault Drone Bay")>] ``Assault Drone Bay``
    | [<JsonUnionCase(@"Stealth Drone Bay")>] ``Stealth Drone Bay``
    | [<JsonUnionCase(@"Swarm Drone Bay")>] ``Swarm Drone Bay``
    | [<JsonUnionCase(@"Supersonic Drone Bay")>] ``Supersonic Drone Bay``
    | [<JsonUnionCase(@"Sensor Drone Bay")>] ``Sensor Drone Bay``
    | [<JsonUnionCase(@"Hacking Drone Bay")>] ``Hacking Drone Bay``
    | [<JsonUnionCase(@"Minesniffer Drone Bay")>] ``Minesniffer Drone Bay``
    | [<JsonUnionCase(@"Army-in-a-Box")>] ``Army-in-a-Box``
    | [<JsonUnionCase(@"Master Drone Bay")>] ``Master Drone Bay``
    | [<JsonUnionCase(@"Wardrone Bay")>] ``Wardrone Bay``
    | [<JsonUnionCase(@"Cobbler Unit")>] ``Cobbler Unit``
    | [<JsonUnionCase(@"Bomb Factory No. 2")>] ``Bomb Factory No_ 2``
    | [<JsonUnionCase(@"Mobile Assembly Unit")>] ``Mobile Assembly Unit``
    | [<JsonUnionCase(@"Heart of Steel")>] ``Heart of Steel``
    | [<JsonUnionCase(@"Scrapoid Pod")>] ``Scrapoid Pod``
    | [<JsonUnionCase(@"GOLEM Unit")>] ``GOLEM Unit``
    | [<JsonUnionCase(@"PSU Rigger")>] ``PSU Rigger``
    | [<JsonUnionCase(@"Machine Rigger")>] ``Machine Rigger``
    | [<JsonUnionCase(@"Phasing AFG")>] ``Phasing AFG``
    | [<JsonUnionCase(@"AS-neutralizer No. 17b")>] ``AS-neutralizer No_ 17b``
    | [<JsonUnionCase(@"V3-11A's Pendant")>] ``V3-11A's Pendant``
    | [<JsonUnionCase(@"Amulet of Y3-NDR")>] ``Amulet of Y3-NDR``
    | [<JsonUnionCase(@"Chronowheel")>] ``Chronowheel``
    | [<JsonUnionCase(@"Power Bank")>] ``Power Bank``
    | [<JsonUnionCase(@"Rainbow Chip")>] ``Rainbow Chip``
    | [<JsonUnionCase(@"VL-GR5's Exoskeleton 'Deathgrip'")>] ``VL-GR5's Exoskeleton _Deathgrip_``
    | [<JsonUnionCase(@"Dimensional Node Initializer")>] ``Dimensional Node Initializer``
    | [<JsonUnionCase(@"Transdimensional Reconstructor")>] ``Transdimensional Reconstructor``
    | [<JsonUnionCase(@"Hpw. Transdimensional Reconstructor")>] ``Hpw_ Transdimensional Reconstructor``
    | [<JsonUnionCase(@"Supercharged TR")>] ``Supercharged TR``
    | [<JsonUnionCase(@"Core Expander")>] ``Core Expander``
    | [<JsonUnionCase(@"Core Regenerator")>] ``Core Regenerator``
    | [<JsonUnionCase(@"Integrity Redistributor")>] ``Integrity Redistributor``
    | [<JsonUnionCase(@"Integrated Dissipator")>] ``Integrated Dissipator``
    | [<JsonUnionCase(@"Supercharged Integrated Dissipator")>] ``Supercharged Integrated Dissipator``
    | [<JsonUnionCase(@"Integrated Thermoelectric Network")>] ``Integrated Thermoelectric Network``
    | [<JsonUnionCase(@"Integrated Reactor")>] ``Integrated Reactor``
    | [<JsonUnionCase(@"Supercharged Integrated Reactor")>] ``Supercharged Integrated Reactor``
    | [<JsonUnionCase(@"Integrated Mediator")>] ``Integrated Mediator``
    | [<JsonUnionCase(@"Core Membrane")>] ``Core Membrane``
    | [<JsonUnionCase(@"Navigation Efficiency Matrix")>] ``Navigation Efficiency Matrix``
    | [<JsonUnionCase(@"Core Reset Matrix")>] ``Core Reset Matrix``
    | [<JsonUnionCase(@"Subatomic Replicator")>] ``Subatomic Replicator``
    | [<JsonUnionCase(@"Terrabomb")>] ``Terrabomb``
    | [<JsonUnionCase(@"Core Physics Calibrator")>] ``Core Physics Calibrator``
    | [<JsonUnionCase(@"Personal Teleporter v0.10")>] ``Personal Teleporter v0_10``
    | [<JsonUnionCase(@"Telecube")>] ``Telecube``
    | [<JsonUnionCase(@"Spacefold Activator")>] ``Spacefold Activator``
    | [<JsonUnionCase(@"Microwarp Drive")>] ``Microwarp Drive``
    | [<JsonUnionCase(@"LC Capacitor")>] ``LC Capacitor``
    | [<JsonUnionCase(@"LRC Armor")>] ``LRC Armor``
    | [<JsonUnionCase(@"LRC Storage")>] ``LRC Storage``
    | [<JsonUnionCase(@"LRC Energy Well")>] ``LRC Energy Well``
    | [<JsonUnionCase(@"LRC Matter Compressor")>] ``LRC Matter Compressor``
    | [<JsonUnionCase(@"LRC Inertial Stabilizer")>] ``LRC Inertial Stabilizer``
    | [<JsonUnionCase(@"LRC Insulator")>] ``LRC Insulator``
    | [<JsonUnionCase(@"EM Pulse Gun")>] ``EM Pulse Gun``
    | [<JsonUnionCase(@"Hvy. EM Pulse Gun")>] ``Hvy_ EM Pulse Gun``
    | [<JsonUnionCase(@"EM Shotgun")>] ``EM Shotgun``
    | [<JsonUnionCase(@"Imp. EM Shotgun")>] ``Imp_ EM Shotgun``
    | [<JsonUnionCase(@"Shock Rifle")>] ``Shock Rifle``
    | [<JsonUnionCase(@"Riot Gun")>] ``Riot Gun``
    | [<JsonUnionCase(@"Hvy. EM Shotgun")>] ``Hvy_ EM Shotgun``
    | [<JsonUnionCase(@"Lightning Gun")>] ``Lightning Gun``
    | [<JsonUnionCase(@"Hvy. Riot Gun")>] ``Hvy_ Riot Gun``
    | [<JsonUnionCase(@"Arc Projector")>] ``Arc Projector``
    | [<JsonUnionCase(@"Prc. Shock Rifle")>] ``Prc_ Shock Rifle``
    | [<JsonUnionCase(@"Hpw. Shock Rifle")>] ``Hpw_ Shock Rifle``
    | [<JsonUnionCase(@"Arc Thrower")>] ``Arc Thrower``
    | [<JsonUnionCase(@"Imp. Lightning Gun")>] ``Imp_ Lightning Gun``
    | [<JsonUnionCase(@"Tesla Rifle")>] ``Tesla Rifle``
    | [<JsonUnionCase(@"Imp. Arc Projector")>] ``Imp_ Arc Projector``
    | [<JsonUnionCase(@"Hvy. Tesla Rifle")>] ``Hvy_ Tesla Rifle``
    | [<JsonUnionCase(@"Hyp. EM Gauss Rifle")>] ``Hyp_ EM Gauss Rifle``
    | [<JsonUnionCase(@"Imp. Arc Thrower")>] ``Imp_ Arc Thrower``
    | [<JsonUnionCase(@"01-MTF's Shockpuncher")>] ``01-MTF's Shockpuncher``
    | [<JsonUnionCase(@"Gamma Rifle")>] ``Gamma Rifle``
    | [<JsonUnionCase(@"Tachyon Dispersion Ray")>] ``Tachyon Dispersion Ray``
    | [<JsonUnionCase(@"Immobilizer")>] ``Immobilizer``
    | [<JsonUnionCase(@"Electrostorm Shotgun")>] ``Electrostorm Shotgun``
    | [<JsonUnionCase(@"Modified EM Gauss Rifle")>] ``Modified EM Gauss Rifle``
    | [<JsonUnionCase(@"AWS/EX-DEC")>] ``AWS_EX-DEC``
    | [<JsonUnionCase(@"Enh. Gamma Rifle")>] ``Enh_ Gamma Rifle``
    | [<JsonUnionCase(@"Med. Laser")>] ``Med_ Laser``
    | [<JsonUnionCase(@"Sml. Laser")>] ``Sml_ Laser``
    | [<JsonUnionCase(@"Salvaging Laser")>] ``Salvaging Laser``
    | [<JsonUnionCase(@"Backup Laser I")>] ``Backup Laser I``
    | [<JsonUnionCase(@"Beam Rifle")>] ``Beam Rifle``
    | [<JsonUnionCase(@"Particle Gun")>] ``Particle Gun``
    | [<JsonUnionCase(@"Spread Laser")>] ``Spread Laser``
    | [<JsonUnionCase(@"Imp. Medium Laser")>] ``Imp_ Medium Laser``
    | [<JsonUnionCase(@"Sub. Laser")>] ``Sub_ Laser``
    | [<JsonUnionCase(@"Autobeam")>] ``Autobeam``
    | [<JsonUnionCase(@"Field Laser")>] ``Field Laser``
    | [<JsonUnionCase(@"Pulse Rifle")>] ``Pulse Rifle``
    | [<JsonUnionCase(@"Ovr. Pulse Rifle")>] ``Ovr_ Pulse Rifle``
    | [<JsonUnionCase(@"Backup Laser III")>] ``Backup Laser III``
    | [<JsonUnionCase(@"Hvy. Particle Gun")>] ``Hvy_ Particle Gun``
    | [<JsonUnionCase(@"Prc. Beam Rifle")>] ``Prc_ Beam Rifle``
    | [<JsonUnionCase(@"Adv. Beam Rifle")>] ``Adv_ Beam Rifle``
    | [<JsonUnionCase(@"Hvy. Laser")>] ``Hvy_ Laser``
    | [<JsonUnionCase(@"Gatling Laser")>] ``Gatling Laser``
    | [<JsonUnionCase(@"Cld. Pulse Rifle")>] ``Cld_ Pulse Rifle``
    | [<JsonUnionCase(@"Hpw. Field Laser")>] ``Hpw_ Field Laser``
    | [<JsonUnionCase(@"Imp. Spread Laser")>] ``Imp_ Spread Laser``
    | [<JsonUnionCase(@"Mak. Laser")>] ``Mak_ Laser``
    | [<JsonUnionCase(@"Plasma Rifle")>] ``Plasma Rifle``
    | [<JsonUnionCase(@"Thermic Laser")>] ``Thermic Laser``
    | [<JsonUnionCase(@"Beamcaster")>] ``Beamcaster``
    | [<JsonUnionCase(@"Force Rifle")>] ``Force Rifle``
    | [<JsonUnionCase(@"Imp. Heavy Laser")>] ``Imp_ Heavy Laser``
    | [<JsonUnionCase(@"Storm Laser")>] ``Storm Laser``
    | [<JsonUnionCase(@"Zio. Laser-S")>] ``Zio_ Laser-S``
    | [<JsonUnionCase(@"Wave Gun")>] ``Wave Gun``
    | [<JsonUnionCase(@"Variable Charge Gun")>] ``Variable Charge Gun``
    | [<JsonUnionCase(@"Hvy. Beamcaster")>] ``Hvy_ Beamcaster``
    | [<JsonUnionCase(@"Ovr. Beamcaster")>] ``Ovr_ Beamcaster``
    | [<JsonUnionCase(@"Cld. Plasma Rifle")>] ``Cld_ Plasma Rifle``
    | [<JsonUnionCase(@"Enh. Force Rifle")>] ``Enh_ Force Rifle``
    | [<JsonUnionCase(@"Hvy. Gatling Laser")>] ``Hvy_ Gatling Laser``
    | [<JsonUnionCase(@"Zio. Phaser-S")>] ``Zio_ Phaser-S``
    | [<JsonUnionCase(@"Phase Gun")>] ``Phase Gun``
    | [<JsonUnionCase(@"Dispersion Rifle")>] ``Dispersion Rifle``
    | [<JsonUnionCase(@"Backup Laser VII")>] ``Backup Laser VII``
    | [<JsonUnionCase(@"Plasma Storm")>] ``Plasma Storm``
    | [<JsonUnionCase(@"Adv. Plasma Rifle")>] ``Adv_ Plasma Rifle``
    | [<JsonUnionCase(@"Hvy. Wave Gun")>] ``Hvy_ Wave Gun``
    | [<JsonUnionCase(@"Adv. Variable Charge Gun")>] ``Adv_ Variable Charge Gun``
    | [<JsonUnionCase(@"Cld. Phase Gun")>] ``Cld_ Phase Gun``
    | [<JsonUnionCase(@"Lrn. Gatling Laser")>] ``Lrn_ Gatling Laser``
    | [<JsonUnionCase(@"Warp Gun")>] ``Warp Gun``
    | [<JsonUnionCase(@"Vortex Rifle")>] ``Vortex Rifle``
    | [<JsonUnionCase(@"Zio. Laser-M")>] ``Zio_ Laser-M``
    | [<JsonUnionCase(@"AWS/Thermal")>] ``AWS_Thermal``
    | [<JsonUnionCase(@"PD Laser")>] ``PD Laser``
    | [<JsonUnionCase(@"KN-7UR's Autopenetrator")>] ``KN-7UR's Autopenetrator``
    | [<JsonUnionCase(@"Quantum Rifle")>] ``Quantum Rifle``
    | [<JsonUnionCase(@"Ovr. Quantum Rifle")>] ``Ovr_ Quantum Rifle``
    | [<JsonUnionCase(@"Prc. Phase Gun")>] ``Prc_ Phase Gun``
    | [<JsonUnionCase(@"Hvy. Dispersion Rifle")>] ``Hvy_ Dispersion Rifle``
    | [<JsonUnionCase(@"Vortex Shotgun")>] ``Vortex Shotgun``
    | [<JsonUnionCase(@"Vortex Rail")>] ``Vortex Rail``
    | [<JsonUnionCase(@"Zio. Phaser-M")>] ``Zio_ Phaser-M``
    | [<JsonUnionCase(@"Enh. Quantum Rifle")>] ``Enh_ Quantum Rifle``
    | [<JsonUnionCase(@"Zio. Laser-H")>] ``Zio_ Laser-H``
    | [<JsonUnionCase(@"Hvy. Quantum Rifle")>] ``Hvy_ Quantum Rifle``
    | [<JsonUnionCase(@"Zio. Phaser-H")>] ``Zio_ Phaser-H``
    | [<JsonUnionCase(@"Gatling Beam")>] ``Gatling Beam``
    | [<JsonUnionCase(@"Sigix Sheargun")>] ``Sigix Sheargun``
    | [<JsonUnionCase(@"Modified Sigix Sheargun")>] ``Modified Sigix Sheargun``
    | [<JsonUnionCase(@"Lgt. EM Pulse Cannon")>] ``Lgt_ EM Pulse Cannon``
    | [<JsonUnionCase(@"EM Pulse Cannon")>] ``EM Pulse Cannon``
    | [<JsonUnionCase(@"Imp. EM Pulse Cannon")>] ``Imp_ EM Pulse Cannon``
    | [<JsonUnionCase(@"Proton Cannon")>] ``Proton Cannon``
    | [<JsonUnionCase(@"Lrn. Proton Cannon")>] ``Lrn_ Proton Cannon``
    | [<JsonUnionCase(@"Disruptor Cannon")>] ``Disruptor Cannon``
    | [<JsonUnionCase(@"Hvy. Proton Cannon")>] ``Hvy_ Proton Cannon``
    | [<JsonUnionCase(@"HERF Cannon")>] ``HERF Cannon``
    | [<JsonUnionCase(@"Hvy. Disruptor Cannon")>] ``Hvy_ Disruptor Cannon``
    | [<JsonUnionCase(@"Cld. Proton Cannon")>] ``Cld_ Proton Cannon``
    | [<JsonUnionCase(@"Proton Burst Cannon")>] ``Proton Burst Cannon``
    | [<JsonUnionCase(@"Com. HERF Cannon")>] ``Com_ HERF Cannon``
    | [<JsonUnionCase(@"Latent Energy Streamer")>] ``Latent Energy Streamer``
    | [<JsonUnionCase(@"NK-0LA's Tesla Doomcannon")>] ``NK-0LA's Tesla Doomcannon``
    | [<JsonUnionCase(@"EMDS")>] ``EMDS``
    | [<JsonUnionCase(@"Hpw. Disruptor Cannon")>] ``Hpw_ Disruptor Cannon``
    | [<JsonUnionCase(@"Beam Cannon")>] ``Beam Cannon``
    | [<JsonUnionCase(@"Particle Cannon")>] ``Particle Cannon``
    | [<JsonUnionCase(@"Adv. Beam Cannon")>] ``Adv_ Beam Cannon``
    | [<JsonUnionCase(@"Sub. Beam Cannon")>] ``Sub_ Beam Cannon``
    | [<JsonUnionCase(@"Hvy. Particle Cannon")>] ``Hvy_ Particle Cannon``
    | [<JsonUnionCase(@"Ion Cannon")>] ``Ion Cannon``
    | [<JsonUnionCase(@"Plasma Cannon")>] ``Plasma Cannon``
    | [<JsonUnionCase(@"Hvy. Ion Cannon")>] ``Hvy_ Ion Cannon``
    | [<JsonUnionCase(@"Cld. Particle Cannon")>] ``Cld_ Particle Cannon``
    | [<JsonUnionCase(@"Phase Cannon")>] ``Phase Cannon``
    | [<JsonUnionCase(@"Hvy. Plasma Cannon")>] ``Hvy_ Plasma Cannon``
    | [<JsonUnionCase(@"Cld. Plasma Cannon")>] ``Cld_ Plasma Cannon``
    | [<JsonUnionCase(@"Com. Ion Cannon")>] ``Com_ Ion Cannon``
    | [<JsonUnionCase(@"Ion Burst Cannon")>] ``Ion Burst Cannon``
    | [<JsonUnionCase(@"Adv. Plasma Cannon")>] ``Adv_ Plasma Cannon``
    | [<JsonUnionCase(@"Hvy. Phase Cannon")>] ``Hvy_ Phase Cannon``
    | [<JsonUnionCase(@"Neutron Cannon")>] ``Neutron Cannon``
    | [<JsonUnionCase(@"Powered Cannon")>] ``Powered Cannon``
    | [<JsonUnionCase(@"Matter Neutralizer")>] ``Matter Neutralizer``
    | [<JsonUnionCase(@"Hvy. Neutron Cannon")>] ``Hvy_ Neutron Cannon``
    | [<JsonUnionCase(@"Lrn. Phase Cannon")>] ``Lrn_ Phase Cannon``
    | [<JsonUnionCase(@"Cld. Phase Cannon")>] ``Cld_ Phase Cannon``
    | [<JsonUnionCase(@"Vortex Cannon")>] ``Vortex Cannon``
    | [<JsonUnionCase(@"Gui. Plasma Cannon")>] ``Gui_ Plasma Cannon``
    | [<JsonUnionCase(@"Nova Cannon")>] ``Nova Cannon``
    | [<JsonUnionCase(@"Imp. Matter Neutralizer")>] ``Imp_ Matter Neutralizer``
    | [<JsonUnionCase(@"Exp. Thermic Cannon")>] ``Exp_ Thermic Cannon``
    | [<JsonUnionCase(@"Vortex Driver")>] ``Vortex Driver``
    | [<JsonUnionCase(@"Zio. Alpha Cannon")>] ``Zio_ Alpha Cannon``
    | [<JsonUnionCase(@"Asb. Focal Cannon")>] ``Asb_ Focal Cannon``
    | [<JsonUnionCase(@"Enh. Nova Cannon")>] ``Enh_ Nova Cannon``
    | [<JsonUnionCase(@"Firepult")>] ``Firepult``
    | [<JsonUnionCase(@"YOLO Cannon")>] ``YOLO Cannon``
    | [<JsonUnionCase(@"Potential Cannon")>] ``Potential Cannon``
    | [<JsonUnionCase(@"Warp Cannon")>] ``Warp Cannon``
    | [<JsonUnionCase(@"Cld. Nova Cannon")>] ``Cld_ Nova Cannon``
    | [<JsonUnionCase(@"Null Cannon")>] ``Null Cannon``
    | [<JsonUnionCase(@"Hyp. Alpha Cannon")>] ``Hyp_ Alpha Cannon``
    | [<JsonUnionCase(@"Zio. Alpha Cannon Mk. II")>] ``Zio_ Alpha Cannon Mk_ II``
    | [<JsonUnionCase(@"Imp. Potential Cannon")>] ``Imp_ Potential Cannon``
    | [<JsonUnionCase(@"Multinova Projection Cannon")>] ``Multinova Projection Cannon``
    | [<JsonUnionCase(@"Disintegrator")>] ``Disintegrator``
    | [<JsonUnionCase(@"Core Cannon")>] ``Core Cannon``
    | [<JsonUnionCase(@"Sigix Shearcannon")>] ``Sigix Shearcannon``
    | [<JsonUnionCase(@"Drained L-Cannon")>] ``Drained L-Cannon``
    | [<JsonUnionCase(@"L-Cannon")>] ``L-Cannon``
    | [<JsonUnionCase(@"BFG-9k Vortex Edition")>] ``BFG-9k Vortex Edition``
    | [<JsonUnionCase(@"Assault Rifle")>] ``Assault Rifle``
    | [<JsonUnionCase(@"Asb. Rifle")>] ``Asb_ Rifle``
    | [<JsonUnionCase(@"Lgt. Assault Rifle")>] ``Lgt_ Assault Rifle``
    | [<JsonUnionCase(@"Bolt Gun")>] ``Bolt Gun``
    | [<JsonUnionCase(@"Hvy. Assault Rifle")>] ``Hvy_ Assault Rifle``
    | [<JsonUnionCase(@"Autogun")>] ``Autogun``
    | [<JsonUnionCase(@"Shotgun")>] ``Shotgun``
    | [<JsonUnionCase(@"Battle Rifle")>] ``Battle Rifle``
    | [<JsonUnionCase(@"Asb. Heavy Rifle")>] ``Asb_ Heavy Rifle``
    | [<JsonUnionCase(@"Sub. Machine Gun")>] ``Sub_ Machine Gun``
    | [<JsonUnionCase(@"Imp. Assault Rifle")>] ``Imp_ Assault Rifle``
    | [<JsonUnionCase(@"Minigun")>] ``Minigun``
    | [<JsonUnionCase(@"Hpw. Shotgun")>] ``Hpw_ Shotgun``
    | [<JsonUnionCase(@"Asb. Shotgun")>] ``Asb_ Shotgun``
    | [<JsonUnionCase(@"Barrage Gun")>] ``Barrage Gun``
    | [<JsonUnionCase(@"Ovr. Barrage Gun")>] ``Ovr_ Barrage Gun``
    | [<JsonUnionCase(@"Enh. Autogun")>] ``Enh_ Autogun``
    | [<JsonUnionCase(@"Gauss Rifle")>] ``Gauss Rifle``
    | [<JsonUnionCase(@"Asb. Gauss Rifle")>] ``Asb_ Gauss Rifle``
    | [<JsonUnionCase(@"Flak Gun")>] ``Flak Gun``
    | [<JsonUnionCase(@"Prc. Assault Rifle")>] ``Prc_ Assault Rifle``
    | [<JsonUnionCase(@"Hvy. Battle Rifle")>] ``Hvy_ Battle Rifle``
    | [<JsonUnionCase(@"Mak. Shrapnel Gun")>] ``Mak_ Shrapnel Gun``
    | [<JsonUnionCase(@"Coil Gun")>] ``Coil Gun``
    | [<JsonUnionCase(@"Hyp. Gauss Rifle")>] ``Hyp_ Gauss Rifle``
    | [<JsonUnionCase(@"Hvy. Machine Gun")>] ``Hvy_ Machine Gun``
    | [<JsonUnionCase(@"Imp. Heavy Machine Gun")>] ``Imp_ Heavy Machine Gun``
    | [<JsonUnionCase(@"Com. Gauss Rifle")>] ``Com_ Gauss Rifle``
    | [<JsonUnionCase(@"XL Autogun Subcomponent")>] ``XL Autogun Subcomponent``
    | [<JsonUnionCase(@"KE Penetrator")>] ``KE Penetrator``
    | [<JsonUnionCase(@"Hyp. Coil Gun")>] ``Hyp_ Coil Gun``
    | [<JsonUnionCase(@"Ovr. Coil Gun")>] ``Ovr_ Coil Gun``
    | [<JsonUnionCase(@"Imp. KE Penetrator")>] ``Imp_ KE Penetrator``
    | [<JsonUnionCase(@"Enh. Coil Gun")>] ``Enh_ Coil Gun``
    | [<JsonUnionCase(@"Com. Coil Gun")>] ``Com_ Coil Gun``
    | [<JsonUnionCase(@"Railgun")>] ``Railgun``
    | [<JsonUnionCase(@"Adv. KE Penetrator")>] ``Adv_ KE Penetrator``
    | [<JsonUnionCase(@"Linked Autogun")>] ``Linked Autogun``
    | [<JsonUnionCase(@"AWS/Gauss")>] ``AWS_Gauss``
    | [<JsonUnionCase(@"Hyp. Railgun")>] ``Hyp_ Railgun``
    | [<JsonUnionCase(@"Ovr. Railgun")>] ``Ovr_ Railgun``
    | [<JsonUnionCase(@"Helical Railgun")>] ``Helical Railgun``
    | [<JsonUnionCase(@"Com. Railgun")>] ``Com_ Railgun``
    | [<JsonUnionCase(@"XL Autogun Array")>] ``XL Autogun Array``
    | [<JsonUnionCase(@"12-ASH's Boomstick")>] ``12-ASH's Boomstick``
    | [<JsonUnionCase(@"8R-AWN's Boregun")>] ``8R-AWN's Boregun``
    | [<JsonUnionCase(@"Multirail")>] ``Multirail``
    | [<JsonUnionCase(@"Hyp. Multirail")>] ``Hyp_ Multirail``
    | [<JsonUnionCase(@"5H-AD0's Sniper Rifle")>] ``5H-AD0's Sniper Rifle``
    | [<JsonUnionCase(@"A3's Sniper Rifle")>] ``A3's Sniper Rifle``
    | [<JsonUnionCase(@"Lgt. Cannon")>] ``Lgt_ Cannon``
    | [<JsonUnionCase(@"Imp. Light Cannon")>] ``Imp_ Light Cannon``
    | [<JsonUnionCase(@"Battle Cannon")>] ``Battle Cannon``
    | [<JsonUnionCase(@"Assault Cannon")>] ``Assault Cannon``
    | [<JsonUnionCase(@"Hvy. Assault Cannon")>] ``Hvy_ Assault Cannon``
    | [<JsonUnionCase(@"Flak Cannon")>] ``Flak Cannon``
    | [<JsonUnionCase(@"Adv. Assault Cannon")>] ``Adv_ Assault Cannon``
    | [<JsonUnionCase(@"Gauss Cannon")>] ``Gauss Cannon``
    | [<JsonUnionCase(@"Slug Cannon")>] ``Slug Cannon``
    | [<JsonUnionCase(@"Mni. Assault Cannon")>] ``Mni_ Assault Cannon``
    | [<JsonUnionCase(@"Siege Cannon Replica")>] ``Siege Cannon Replica``
    | [<JsonUnionCase(@"Magnetic Acceleration Cannon")>] ``Magnetic Acceleration Cannon``
    | [<JsonUnionCase(@"Hvy. Flak Cannon")>] ``Hvy_ Flak Cannon``
    | [<JsonUnionCase(@"Bore Cannon")>] ``Bore Cannon``
    | [<JsonUnionCase(@"Antimatter Cannon")>] ``Antimatter Cannon``
    | [<JsonUnionCase(@"Siege Cannon")>] ``Siege Cannon``
    | [<JsonUnionCase(@"Mass Driver")>] ``Mass Driver``
    | [<JsonUnionCase(@"Hvy. Mass Driver")>] ``Hvy_ Mass Driver``
    | [<JsonUnionCase(@"Enh. Gauss Cannon")>] ``Enh_ Gauss Cannon``
    | [<JsonUnionCase(@"Hyp. Gauss Cannon")>] ``Hyp_ Gauss Cannon``
    | [<JsonUnionCase(@"Tri-rail Accelerator")>] ``Tri-rail Accelerator``
    | [<JsonUnionCase(@"Hardcell Cannon")>] ``Hardcell Cannon``
    | [<JsonUnionCase(@"Hvy. Gauss Cannon")>] ``Hvy_ Gauss Cannon``
    | [<JsonUnionCase(@"Hyp. Mass Driver")>] ``Hyp_ Mass Driver``
    | [<JsonUnionCase(@"Hvy. Autocannon")>] ``Hvy_ Autocannon``
    | [<JsonUnionCase(@"DAS Cannon")>] ``DAS Cannon``
    | [<JsonUnionCase(@"Lgt. Antimatter Cannon")>] ``Lgt_ Antimatter Cannon``
    | [<JsonUnionCase(@"Linear Accelerator")>] ``Linear Accelerator``
    | [<JsonUnionCase(@"Hvy. Linear Accelerator")>] ``Hvy_ Linear Accelerator``
    | [<JsonUnionCase(@"Com. Mass Driver")>] ``Com_ Mass Driver``
    | [<JsonUnionCase(@"Hvy. Hardcell Cannon")>] ``Hvy_ Hardcell Cannon``
    | [<JsonUnionCase(@"Com. Linear Accelerator")>] ``Com_ Linear Accelerator``
    | [<JsonUnionCase(@"Hyp. Linear Accelerator")>] ``Hyp_ Linear Accelerator``
    | [<JsonUnionCase(@"Hcl. Linear Accelerator")>] ``Hcl_ Linear Accelerator``
    | [<JsonUnionCase(@"Graviton Cannon")>] ``Graviton Cannon``
    | [<JsonUnionCase(@"Blast Cannon")>] ``Blast Cannon``
    | [<JsonUnionCase(@"P1-3CE's Gatling Flakker")>] ``P1-3CE's Gatling Flakker``
    | [<JsonUnionCase(@"AWS/Autocannon")>] ``AWS_Autocannon``
    | [<JsonUnionCase(@"Perforator")>] ``Perforator``
    | [<JsonUnionCase(@"Omega Cannon")>] ``Omega Cannon``
    | [<JsonUnionCase(@"PL-3XN's Obliterator")>] ``PL-3XN's Obliterator``
    | [<JsonUnionCase(@"EMP Blaster")>] ``EMP Blaster``
    | [<JsonUnionCase(@"Shock Bomb Launcher")>] ``Shock Bomb Launcher``
    | [<JsonUnionCase(@"Adv. EMP Blaster")>] ``Adv_ EMP Blaster``
    | [<JsonUnionCase(@"Proton Missile Launcher")>] ``Proton Missile Launcher``
    | [<JsonUnionCase(@"Imp. Proton Missile Launcher")>] ``Imp_ Proton Missile Launcher``
    | [<JsonUnionCase(@"Gui. EMP Blaster")>] ``Gui_ EMP Blaster``
    | [<JsonUnionCase(@"Hvy. Shock Bomb Launcher")>] ``Hvy_ Shock Bomb Launcher``
    | [<JsonUnionCase(@"Tesla Bomb Launcher")>] ``Tesla Bomb Launcher``
    | [<JsonUnionCase(@"Hvy. Proton Missile Launcher")>] ``Hvy_ Proton Missile Launcher``
    | [<JsonUnionCase(@"Com. Tesla Bomb Launcher")>] ``Com_ Tesla Bomb Launcher``
    | [<JsonUnionCase(@"Gamma Bomb Array")>] ``Gamma Bomb Array``
    | [<JsonUnionCase(@"Enh. Gamma Bomb Array")>] ``Enh_ Gamma Bomb Array``
    | [<JsonUnionCase(@"Grenade Launcher")>] ``Grenade Launcher``
    | [<JsonUnionCase(@"Rocket Launcher")>] ``Rocket Launcher``
    | [<JsonUnionCase(@"Mni. Grenade Launcher")>] ``Mni_ Grenade Launcher``
    | [<JsonUnionCase(@"Sub. Shrapnel Launcher")>] ``Sub_ Shrapnel Launcher``
    | [<JsonUnionCase(@"Imp. Grenade Launcher")>] ``Imp_ Grenade Launcher``
    | [<JsonUnionCase(@"Missile Launcher")>] ``Missile Launcher``
    | [<JsonUnionCase(@"Concussive RPG")>] ``Concussive RPG``
    | [<JsonUnionCase(@"YI-UF0's Doublenader")>] ``YI-UF0's Doublenader``
    | [<JsonUnionCase(@"Hvy. Rocket Launcher")>] ``Hvy_ Rocket Launcher``
    | [<JsonUnionCase(@"Hvy. Missile Launcher")>] ``Hvy_ Missile Launcher``
    | [<JsonUnionCase(@"Gui. Missile Launcher")>] ``Gui_ Missile Launcher``
    | [<JsonUnionCase(@"Prc. Grenade Launcher")>] ``Prc_ Grenade Launcher``
    | [<JsonUnionCase(@"Rocket Array")>] ``Rocket Array``
    | [<JsonUnionCase(@"Lrn. Missile Launcher")>] ``Lrn_ Missile Launcher``
    | [<JsonUnionCase(@"Imp. Concussive RPG")>] ``Imp_ Concussive RPG``
    | [<JsonUnionCase(@"Prc. Rocket Launcher")>] ``Prc_ Rocket Launcher``
    | [<JsonUnionCase(@"Scatter Rocket Array")>] ``Scatter Rocket Array``
    | [<JsonUnionCase(@"Smartbomb Launcher")>] ``Smartbomb Launcher``
    | [<JsonUnionCase(@"Mni. Smartbomb Launcher")>] ``Mni_ Smartbomb Launcher``
    | [<JsonUnionCase(@"Tiamat Missile Launcher")>] ``Tiamat Missile Launcher``
    | [<JsonUnionCase(@"Thermoblaster")>] ``Thermoblaster``
    | [<JsonUnionCase(@"Micro-nuke Launcher")>] ``Micro-nuke Launcher``
    | [<JsonUnionCase(@"Adv. Concussive RPG")>] ``Adv_ Concussive RPG``
    | [<JsonUnionCase(@"Neutron Missile Launcher")>] ``Neutron Missile Launcher``
    | [<JsonUnionCase(@"Fusion Bomb Launcher")>] ``Fusion Bomb Launcher``
    | [<JsonUnionCase(@"Hellfire Missile Launcher")>] ``Hellfire Missile Launcher``
    | [<JsonUnionCase(@"Adv. Micro-nuke Launcher")>] ``Adv_ Micro-nuke Launcher``
    | [<JsonUnionCase(@"Tactical Quantum Warhead")>] ``Tactical Quantum Warhead``
    | [<JsonUnionCase(@"Vortex Catalyst Activator")>] ``Vortex Catalyst Activator``
    | [<JsonUnionCase(@"Chain Missile Launcher")>] ``Chain Missile Launcher``
    | [<JsonUnionCase(@"Ragnarok Missile Launcher")>] ``Ragnarok Missile Launcher``
    | [<JsonUnionCase(@"Point Singularity Launcher")>] ``Point Singularity Launcher``
    | [<JsonUnionCase(@"Gui. Micro-nuke Launcher")>] ``Gui_ Micro-nuke Launcher``
    | [<JsonUnionCase(@"99-TNT's Nukerbomber")>] ``99-TNT's Nukerbomber``
    | [<JsonUnionCase(@"Exp. Neutron Missile Launcher")>] ``Exp_ Neutron Missile Launcher``
    | [<JsonUnionCase(@"Z-bomb Delivery System")>] ``Z-bomb Delivery System``
    | [<JsonUnionCase(@"Sigix Terminator")>] ``Sigix Terminator``
    | [<JsonUnionCase(@"Supercharged Sigix Terminator")>] ``Supercharged Sigix Terminator``
    | [<JsonUnionCase(@"Containment Facilitator")>] ``Containment Facilitator``
    | [<JsonUnionCase(@"Detonator")>] ``Detonator``
    | [<JsonUnionCase(@"Dirty Datajack")>] ``Dirty Datajack``
    | [<JsonUnionCase(@"Splice Injector")>] ``Splice Injector``
    | [<JsonUnionCase(@"Master Link")>] ``Master Link``
    | [<JsonUnionCase(@"Datajack")>] ``Datajack``
    | [<JsonUnionCase(@"Imp. Datajack")>] ``Imp_ Datajack``
    | [<JsonUnionCase(@"Adv. Datajack")>] ``Adv_ Datajack``
    | [<JsonUnionCase(@"Remote Datajack")>] ``Remote Datajack``
    | [<JsonUnionCase(@"Imp. Remote Datajack")>] ``Imp_ Remote Datajack``
    | [<JsonUnionCase(@"Adv. Remote Datajack")>] ``Adv_ Remote Datajack``
    | [<JsonUnionCase(@"Exp. Remote Datajack")>] ``Exp_ Remote Datajack``
    | [<JsonUnionCase(@"Gui. Remote Datajack")>] ``Gui_ Remote Datajack``
    | [<JsonUnionCase(@"ME-RLN's Wand")>] ``ME-RLN's Wand``
    | [<JsonUnionCase(@"System Spiker")>] ``System Spiker``
    | [<JsonUnionCase(@"Field Lobotomy Kit")>] ``Field Lobotomy Kit``
    | [<JsonUnionCase(@"Mining Laser")>] ``Mining Laser``
    | [<JsonUnionCase(@"LU-1G1's Laser Shovel")>] ``LU-1G1's Laser Shovel``
    | [<JsonUnionCase(@"Welding Torch")>] ``Welding Torch``
    | [<JsonUnionCase(@"Plasma Cutter")>] ``Plasma Cutter``
    | [<JsonUnionCase(@"Imp. Plasma Cutter")>] ``Imp_ Plasma Cutter``
    | [<JsonUnionCase(@"Exp. Plasma Cutter")>] ``Exp_ Plasma Cutter``
    | [<JsonUnionCase(@"CPS Tube")>] ``CPS Tube``
    | [<JsonUnionCase(@"Multitool")>] ``Multitool``
    | [<JsonUnionCase(@"Flamer")>] ``Flamer``
    | [<JsonUnionCase(@"Asb. F-torch")>] ``Asb_ F-torch``
    | [<JsonUnionCase(@"Enh. Flamer")>] ``Enh_ Flamer``
    | [<JsonUnionCase(@"Plasma Flamer")>] ``Plasma Flamer``
    | [<JsonUnionCase(@"Asb. P-torch")>] ``Asb_ P-torch``
    | [<JsonUnionCase(@"RU-N14's Throwing Claymores")>] ``RU-N14's Throwing Claymores``
    | [<JsonUnionCase(@"RU-N14's Throwing Claymores v3")>] ``RU-N14's Throwing Claymores v3``
    | [<JsonUnionCase(@"Warlord Statue")>] ``Warlord Statue``
    | [<JsonUnionCase(@"Voltaic Drivehammer")>] ``Voltaic Drivehammer``
    | [<JsonUnionCase(@"AD-0RF's Magmablaster")>] ``AD-0RF's Magmablaster``
    | [<JsonUnionCase(@"IN-MT5's Pitchfork 'Insurrection'")>] ``IN-MT5's Pitchfork _Insurrection_``
    | [<JsonUnionCase(@"Shield Trident")>] ``Shield Trident``
    | [<JsonUnionCase(@"Junk Cannon")>] ``Junk Cannon``
    | [<JsonUnionCase(@"Stasis Beam")>] ``Stasis Beam``
    | [<JsonUnionCase(@"Stasis Projector")>] ``Stasis Projector``
    | [<JsonUnionCase(@"Exp. Stasis Projector")>] ``Exp_ Stasis Projector``
    | [<JsonUnionCase(@"Molecular Deconstructor")>] ``Molecular Deconstructor``
    | [<JsonUnionCase(@"SE_WE1")>] ``SE_WE1``
    | [<JsonUnionCase(@"SE_WE2")>] ``SE_WE2``
    | [<JsonUnionCase(@"SE_WE3")>] ``SE_WE3``
    | [<JsonUnionCase(@"SE_WE4")>] ``SE_WE4``
    | [<JsonUnionCase(@"SE_WE5")>] ``SE_WE5``
    | [<JsonUnionCase(@"Hammer")>] ``Hammer``
    | [<JsonUnionCase(@"Mace")>] ``Mace``
    | [<JsonUnionCase(@"Flail")>] ``Flail``
    | [<JsonUnionCase(@"Maul")>] ``Maul``
    | [<JsonUnionCase(@"Asb. Maul")>] ``Asb_ Maul``
    | [<JsonUnionCase(@"Hvy. Hammer")>] ``Hvy_ Hammer``
    | [<JsonUnionCase(@"Hvy. Mace")>] ``Hvy_ Mace``
    | [<JsonUnionCase(@"Hvy. Flail")>] ``Hvy_ Flail``
    | [<JsonUnionCase(@"Great Maul")>] ``Great Maul``
    | [<JsonUnionCase(@"Powered Hammer")>] ``Powered Hammer``
    | [<JsonUnionCase(@"Mak. Hammer")>] ``Mak_ Hammer``
    | [<JsonUnionCase(@"Power Maul")>] ``Power Maul``
    | [<JsonUnionCase(@"Asb. P-maul")>] ``Asb_ P-maul``
    | [<JsonUnionCase(@"Impact Mace")>] ``Impact Mace``
    | [<JsonUnionCase(@"Shock Maul")>] ``Shock Maul``
    | [<JsonUnionCase(@"Thunder Hammer")>] ``Thunder Hammer``
    | [<JsonUnionCase(@"Compactor")>] ``Compactor``
    | [<JsonUnionCase(@"Gravity Flail")>] ``Gravity Flail``
    | [<JsonUnionCase(@"CL-ANK's Mallet")>] ``CL-ANK's Mallet``
    | [<JsonUnionCase(@"Core Stripper")>] ``Core Stripper``
    | [<JsonUnionCase(@"Mining Claw")>] ``Mining Claw``
    | [<JsonUnionCase(@"EC_1")>] ``EC_1``
    | [<JsonUnionCase(@"Katana")>] ``Katana``
    | [<JsonUnionCase(@"Asb. Blade")>] ``Asb_ Blade``
    | [<JsonUnionCase(@"Scythe")>] ``Scythe``
    | [<JsonUnionCase(@"Axe")>] ``Axe``
    | [<JsonUnionCase(@"Blade Saw")>] ``Blade Saw``
    | [<JsonUnionCase(@"EC_3")>] ``EC_3``
    | [<JsonUnionCase(@"Chainsword")>] ``Chainsword``
    | [<JsonUnionCase(@"Ripper")>] ``Ripper``
    | [<JsonUnionCase(@"Mak. Axe")>] ``Mak_ Axe``
    | [<JsonUnionCase(@"Mak. Sword")>] ``Mak_ Sword``
    | [<JsonUnionCase(@"Great Axe")>] ``Great Axe``
    | [<JsonUnionCase(@"Greatsword")>] ``Greatsword``
    | [<JsonUnionCase(@"Ripteeth")>] ``Ripteeth``
    | [<JsonUnionCase(@"Power Sword")>] ``Power Sword``
    | [<JsonUnionCase(@"Asb. P-sword")>] ``Asb_ P-sword``
    | [<JsonUnionCase(@"Falx")>] ``Falx``
    | [<JsonUnionCase(@"Carbide Saw")>] ``Carbide Saw``
    | [<JsonUnionCase(@"Segregator")>] ``Segregator``
    | [<JsonUnionCase(@"Tearclaws")>] ``Tearclaws``
    | [<JsonUnionCase(@"Companion Sword")>] ``Companion Sword``
    | [<JsonUnionCase(@"EC_5")>] ``EC_5``
    | [<JsonUnionCase(@"Phasing Sabre")>] ``Phasing Sabre``
    | [<JsonUnionCase(@"Plasma Sword")>] ``Plasma Sword``
    | [<JsonUnionCase(@"Ionic Axe")>] ``Ionic Axe``
    | [<JsonUnionCase(@"Mni. Tearclaws")>] ``Mni_ Tearclaws``
    | [<JsonUnionCase(@"Vmp. Broadsword")>] ``Vmp_ Broadsword``
    | [<JsonUnionCase(@"Dual-blade Saw")>] ``Dual-blade Saw``
    | [<JsonUnionCase(@"Vibroblade")>] ``Vibroblade``
    | [<JsonUnionCase(@"Molecular Scythe")>] ``Molecular Scythe``
    | [<JsonUnionCase(@"Centrium Greatsword")>] ``Centrium Greatsword``
    | [<JsonUnionCase(@"Master Tearclaws")>] ``Master Tearclaws``
    | [<JsonUnionCase(@"Longsword +1")>] ``Longsword _1``
    | [<JsonUnionCase(@"EC_7")>] ``EC_7``
    | [<JsonUnionCase(@"Nanosword")>] ``Nanosword``
    | [<JsonUnionCase(@"Particle Cleaver")>] ``Particle Cleaver``
    | [<JsonUnionCase(@"Centrium Claws")>] ``Centrium Claws``
    | [<JsonUnionCase(@"1C-UTU's Sword 'Lootmaker'")>] ``1C-UTU's Sword _Lootmaker_``
    | [<JsonUnionCase(@"DM-GVY's Chainsaw")>] ``DM-GVY's Chainsaw``
    | [<JsonUnionCase(@"Vortex Shredder")>] ``Vortex Shredder``
    | [<JsonUnionCase(@"EC_9")>] ``EC_9``
    | [<JsonUnionCase(@"1C-UTU's Sword 'Choppy'")>] ``1C-UTU's Sword _Choppy_``
    | [<JsonUnionCase(@"Quantum Companion")>] ``Quantum Companion``
    | [<JsonUnionCase(@"Superquantum Companion")>] ``Superquantum Companion``
    | [<JsonUnionCase(@"Quantum Blade")>] ``Quantum Blade``
    | [<JsonUnionCase(@"Sigix Broadsword")>] ``Sigix Broadsword``
    | [<JsonUnionCase(@"Spear")>] ``Spear``
    | [<JsonUnionCase(@"Mak. Spear")>] ``Mak_ Spear``
    | [<JsonUnionCase(@"CR-A16's Pointy Stick")>] ``CR-A16's Pointy Stick``
    | [<JsonUnionCase(@"Hvy. Pick")>] ``Hvy_ Pick``
    | [<JsonUnionCase(@"Lance")>] ``Lance``
    | [<JsonUnionCase(@"Kinetic Spear")>] ``Kinetic Spear``
    | [<JsonUnionCase(@"Force Lance")>] ``Force Lance``
    | [<JsonUnionCase(@"Plasma Lance")>] ``Plasma Lance``
    | [<JsonUnionCase(@"Enh. Force Lance")>] ``Enh_ Force Lance``
    | [<JsonUnionCase(@"Vortex Lance")>] ``Vortex Lance``
    | [<JsonUnionCase(@"CR-A16's Behemoth Slayer")>] ``CR-A16's Behemoth Slayer``
    | [<JsonUnionCase(@"Thermal Lance")>] ``Thermal Lance``
    | [<JsonUnionCase(@"Blade Trap")>] ``Blade Trap``
    | [<JsonUnionCase(@"Segregator Trap")>] ``Segregator Trap``
    | [<JsonUnionCase(@"Explosive Trap")>] ``Explosive Trap``
    | [<JsonUnionCase(@"Heavy Explosive Trap")>] ``Heavy Explosive Trap``
    | [<JsonUnionCase(@"Tiamat Bomb Trap")>] ``Tiamat Bomb Trap``
    | [<JsonUnionCase(@"Fusion Bomb Trap")>] ``Fusion Bomb Trap``
    | [<JsonUnionCase(@"Hellfire Trap")>] ``Hellfire Trap``
    | [<JsonUnionCase(@"Armageddon Trap")>] ``Armageddon Trap``
    | [<JsonUnionCase(@"Dirty Bomb Trap")>] ``Dirty Bomb Trap``
    | [<JsonUnionCase(@"EMP Trap")>] ``EMP Trap``
    | [<JsonUnionCase(@"Proton Bomb Trap")>] ``Proton Bomb Trap``
    | [<JsonUnionCase(@"Tesla Bomb Trap")>] ``Tesla Bomb Trap``
    | [<JsonUnionCase(@"Gamma Bomb Trap")>] ``Gamma Bomb Trap``
    | [<JsonUnionCase(@"Shrapnel Trap")>] ``Shrapnel Trap``
    | [<JsonUnionCase(@"Vortex Trap")>] ``Vortex Trap``
    | [<JsonUnionCase(@"Piercing Trap")>] ``Piercing Trap``
    | [<JsonUnionCase(@"Shock Trap")>] ``Shock Trap``
    | [<JsonUnionCase(@"EM Surge Trap")>] ``EM Surge Trap``
    | [<JsonUnionCase(@"Fire Trap")>] ``Fire Trap``
    | [<JsonUnionCase(@"Heat Bomb Trap")>] ``Heat Bomb Trap``
    | [<JsonUnionCase(@"Stasis Trap")>] ``Stasis Trap``
    | [<JsonUnionCase(@"Scrap Shield Fragment")>] ``Scrap Shield Fragment``
    | [<JsonUnionCase(@"SUBCON Basin")>] ``SUBCON Basin``
    | [<JsonUnionCase(@"Signal Generator")>] ``Signal Generator``
    | [<JsonUnionCase(@"Self-destruct Interrupter")>] ``Self-destruct Interrupter``
    | [<JsonUnionCase(@"DRS Beacon")>] ``DRS Beacon``
    | [<JsonUnionCase(@"Sapper Charge")>] ``Sapper Charge``
    | [<JsonUnionCase(@"Deploy-a-Sentry")>] ``Deploy-a-Sentry``
    | [<JsonUnionCase(@"Botcube")>] ``Botcube``
    | [<JsonUnionCase(@"Lrg. Botcube")>] ``Lrg_ Botcube``
    | [<JsonUnionCase(@"PL-3XN's Ring of Power")>] ``PL-3XN's Ring of Power``
    | [<JsonUnionCase(@"Disassembled Obliterator")>] ``Disassembled Obliterator``
    | [<JsonUnionCase(@"GAL Module")>] ``GAL Module``
    | [<JsonUnionCase(@"Portable AFG")>] ``Portable AFG``
    | [<JsonUnionCase(@"Zhirov Special")>] ``Zhirov Special``
    | [<JsonUnionCase(@"SGEMP Prototype")>] ``SGEMP Prototype``
    | [<JsonUnionCase(@"Terrabomb Derivative")>] ``Terrabomb Derivative``
    | [<JsonUnionCase(@"Sigix Containment Pod")>] ``Sigix Containment Pod``
    | [<JsonUnionCase(@"Sigix Corpse")>] ``Sigix Corpse``
    | [<JsonUnionCase(@"Meganuke")>] ``Meganuke``
    | [<JsonUnionCase(@"Gamma Refractor")>] ``Gamma Refractor``


let itemId =
    function
    | 0 -> Item.``Matter``
    | 1 -> Item.``Data Core``
    | 2 -> Item.``Derelict Log``
    | 3 -> Item.``Schematic Archive``
    | 4 -> Item.``Imprinter Data Core``
    | 5 -> Item.``A2 Data Core``
    | 6 -> Item.``A7 Data Core``
    | 7 -> Item.``MAIN_C Data Core``
    | 8 -> Item.``Architect Data Core``
    | 9 -> Item.``Scrap``
    | 10 -> Item.``Protomatter``
    | 11 -> Item.``Ion Engine``
    | 12 -> Item.``Lgt_ Ion Engine``
    | 13 -> Item.``Backup Power I``
    | 14 -> Item.``Imp_ Ion Engine``
    | 15 -> Item.``Rnf_ Ion Engine``
    | 16 -> Item.``Hvy_ Ion Engine``
    | 17 -> Item.``Cld_ Ion Engine``
    | 18 -> Item.``Sub_ Power Source``
    | 19 -> Item.``Deuterium Engine``
    | 20 -> Item.``Lgt_ Deuterium Engine``
    | 21 -> Item.``Backup Power III``
    | 22 -> Item.``Nuclear Core``
    | 23 -> Item.``Lgt_ Nuclear Core``
    | 24 -> Item.``Imp_ Deuterium Engine``
    | 25 -> Item.``Rnf_ Deuterium Engine``
    | 26 -> Item.``Hyb_ Deuterium Engine``
    | 27 -> Item.``Hvy_ Deuterium Engine``
    | 28 -> Item.``Cld_ Deuterium Engine``
    | 29 -> Item.``Enh_ Nuclear Core``
    | 30 -> Item.``Mic_ Nuclear Core``
    | 31 -> Item.``Mak_ Power Source``
    | 32 -> Item.``Angular Momentum Engine``
    | 33 -> Item.``Lgt_ Angular Momentum Engine``
    | 34 -> Item.``F-cell Engine``
    | 35 -> Item.``Fission Core``
    | 36 -> Item.``Lgt_ Fission Core``
    | 37 -> Item.``Hyb_ Fission Core``
    | 38 -> Item.``Fusion Compressor``
    | 39 -> Item.``Cold Fusion Reactor``
    | 40 -> Item.``Neutrino Core``
    | 41 -> Item.``Lgt_ Neutrino Core``
    | 42 -> Item.``Rnf_ Fission Core``
    | 43 -> Item.``Enh_ Fission Core``
    | 44 -> Item.``Cld_ Fission Core``
    | 45 -> Item.``Mic_ Fission Core``
    | 46 -> Item.``Fusion Reactor``
    | 47 -> Item.``Antimatter Reactor``
    | 48 -> Item.``Lgt_ Antimatter Reactor``
    | 49 -> Item.``Rnf_ Antimatter Reactor``
    | 50 -> Item.``Hyb_ Antimatter Reactor``
    | 51 -> Item.``Backup Power VII``
    | 52 -> Item.``MA-1KR's Cyclogen``
    | 53 -> Item.``Hvy_ Antimatter Reactor``
    | 54 -> Item.``Mni_ Fusion Reactor``
    | 55 -> Item.``Imp_ Fusion Compressor``
    | 56 -> Item.``Mic_ Neutrino Core``
    | 57 -> Item.``Zio_ Light DM Reactor``
    | 58 -> Item.``Zio_ Heavy DM Reactor``
    | 59 -> Item.``Particle Reactor``
    | 60 -> Item.``Lgt_ Particle Reactor``
    | 61 -> Item.``Mic_ Antimatter Reactor``
    | 62 -> Item.``Com_ Particle Reactor``
    | 63 -> Item.``Cld_ Antimatter Reactor``
    | 64 -> Item.``Graviton Reactor``
    | 65 -> Item.``Asb_ Flux Generator``
    | 66 -> Item.``Quantum Reactor``
    | 67 -> Item.``Lgt_ Quantum Reactor``
    | 68 -> Item.``Rnf_ Quantum Reactor``
    | 69 -> Item.``Imp_ Quantum Reactor``
    | 70 -> Item.``Zero-point Reactor``
    | 71 -> Item.``Vortex Chain Reactor``
    | 72 -> Item.``Singularity Reactor``
    | 73 -> Item.``Matter Drive``
    | 74 -> Item.``Meta Core``
    | 75 -> Item.``SE_PO1``
    | 76 -> Item.``Lgt_ Treads``
    | 77 -> Item.``Imp_ Treads``
    | 78 -> Item.``Spk_ Treads``
    | 79 -> Item.``Arm_ Treads``
    | 80 -> Item.``Adv_ Treads``
    | 81 -> Item.``Ovr_ Treads``
    | 82 -> Item.``Med_ Treads``
    | 83 -> Item.``Imp_ Medium Treads``
    | 84 -> Item.``Spk_ Medium Treads``
    | 85 -> Item.``Arm_ Medium Treads``
    | 86 -> Item.``Hvy_ Treads``
    | 87 -> Item.``Ovr_ Medium Treads``
    | 88 -> Item.``Tri-treads``
    | 89 -> Item.``Wartreads``
    | 90 -> Item.``Adv_ Medium Treads``
    | 91 -> Item.``Enh_ Armored Medium Treads``
    | 92 -> Item.``Imp_ Heavy Treads``
    | 93 -> Item.``Hvy_ Siege Treads``
    | 94 -> Item.``Spk_ Heavy Treads``
    | 95 -> Item.``Vmp_ Heavy Siege Treads``
    | 96 -> Item.``DD-05H's Wartreads``
    | 97 -> Item.``Biometal Medium Treads``
    | 98 -> Item.``Arm_ Heavy Treads``
    | 99 -> Item.``Adv_ Heavy Treads``
    | 100 -> Item.``Imp_ Heavy Siege Treads``
    | 101 -> Item.``Centrium Heavy Treads``
    | 102 -> Item.``Megatreads``
    | 103 -> Item.``Biometal Heavy Treads``
    | 104 -> Item.``Exp_ Biometal Heavy Treads``
    | 105 -> Item.``Enh_ Armored Heavy Treads``
    | 106 -> Item.``Adv_ Heavy Siege Treads``
    | 107 -> Item.``Hdn_ Centrium Heavy Treads``
    | 108 -> Item.``Exp_ Biometal Medium Treads``
    | 109 -> Item.``Aluminum Leg``
    | 110 -> Item.``Imp_ Aluminum Leg``
    | 111 -> Item.``Carbon-fiber Leg``
    | 112 -> Item.``Titanium Leg``
    | 113 -> Item.``Ovr_ Titanium Leg``
    | 114 -> Item.``VSS Leg``
    | 115 -> Item.``Imp_ Carbon-fiber Leg``
    | 116 -> Item.``Imp_ Titanium Leg``
    | 117 -> Item.``Lgt_ Armored Exoskeleton``
    | 118 -> Item.``Mak_ Leg``
    | 119 -> Item.``Flexi-carbon Leg``
    | 120 -> Item.``Arm_ Leg``
    | 121 -> Item.``Imp_ VSS Leg``
    | 122 -> Item.``Zio_ Composite Leg I``
    | 123 -> Item.``Med_ Armored Exoskeleton``
    | 124 -> Item.``Ovr_ Flexi-carbon Leg``
    | 125 -> Item.``Enh_ Flexi-carbon Leg``
    | 126 -> Item.``Enh_ Armored Leg``
    | 127 -> Item.``Arachnoskeleton``
    | 128 -> Item.``Myomer Leg``
    | 129 -> Item.``Adv_ VSS Leg``
    | 130 -> Item.``Adv_ Myomer Leg``
    | 131 -> Item.``Exp_ Flexi-carbon Leg``
    | 132 -> Item.``Zio_ Composite Leg II``
    | 133 -> Item.``Cargo Legs``
    | 134 -> Item.``Etherial Tendrils``
    | 135 -> Item.``Biometal Leg``
    | 136 -> Item.``Hvy_ Armored Exoskeleton``
    | 137 -> Item.``Enh_ Biometal Leg``
    | 138 -> Item.``Exp_ Myomer Leg``
    | 139 -> Item.``Tripod Weapons Platform``
    | 140 -> Item.``T_R_O_L_L_ Exoskeleton``
    | 141 -> Item.``Asb_ Alloy Leg``
    | 142 -> Item.``Centrium Leg``
    | 143 -> Item.``Hdn_ Centrium Leg``
    | 144 -> Item.``Exp_ Biometal Leg``
    | 145 -> Item.``Zio_ Supercomposite Leg``
    | 146 -> Item.``Potential Leg``
    | 147 -> Item.``Myomer Exoskeleton``
    | 148 -> Item.``Sigix Exoskeleton``
    | 149 -> Item.``SE_PR1``
    | 150 -> Item.``Wheel``
    | 151 -> Item.``Com_ Wheel``
    | 152 -> Item.``Arm_ Wheel``
    | 153 -> Item.``Sub_ Monowheel``
    | 154 -> Item.``Ovr_ Scrapsphere``
    | 155 -> Item.``Arm_ Huge Wheel``
    | 156 -> Item.``Ballwheel``
    | 157 -> Item.``Ovr_ Huge Scrapsphere``
    | 158 -> Item.``Centrium Wheel``
    | 159 -> Item.``Hdn_ Centrium Wheel``
    | 160 -> Item.``Hover Unit``
    | 161 -> Item.``Backup Propulsion I``
    | 162 -> Item.``Imp_ Hover Unit``
    | 163 -> Item.``Airjet``
    | 164 -> Item.``Aerolev Unit``
    | 165 -> Item.``Asb_ Hover Unit``
    | 166 -> Item.``Backup Propulsion III``
    | 167 -> Item.``Gravmag System``
    | 168 -> Item.``Asb_ Hover System``
    | 169 -> Item.``Imp_ Airjet``
    | 170 -> Item.``Cld_ Airjet``
    | 171 -> Item.``Imp_ Gravmag System``
    | 172 -> Item.``Cld_ Aerolev Unit``
    | 173 -> Item.``Cmb_ Airjet``
    | 174 -> Item.``Gravmag Array``
    | 175 -> Item.``Mak_ Hover Unit``
    | 176 -> Item.``Zio_ Glidesys I``
    | 177 -> Item.``Antigrav System``
    | 178 -> Item.``Gyrokinetic Inverter``
    | 179 -> Item.``Linear Gravjet``
    | 180 -> Item.``Cld_ Gravmag System``
    | 181 -> Item.``Cmb_ Gravmag System``
    | 182 -> Item.``Imp_ Antigrav System``
    | 183 -> Item.``Imp_ Gyrokinetic Inverter``
    | 184 -> Item.``Imp_ Linear Gravjet``
    | 185 -> Item.``Backup Propulsion VII``
    | 186 -> Item.``Zio_ Glidesys II``
    | 187 -> Item.``Cld_ Antigrav System``
    | 188 -> Item.``Cmb_ Antigrav System``
    | 189 -> Item.``Antigrav Array``
    | 190 -> Item.``Exp_ Gyrokinetic Inverter``
    | 191 -> Item.``Cld_ Linear Gravjet``
    | 192 -> Item.``Cmb_ Linear Gravjet``
    | 193 -> Item.``Flight Unit``
    | 194 -> Item.``VTOL Module``
    | 195 -> Item.``Imp_ Flight Unit``
    | 196 -> Item.``Cesium-ion Thruster``
    | 197 -> Item.``Surge Thruster``
    | 198 -> Item.``Imp_ VTOL Module``
    | 199 -> Item.``Xenon Bombardment Thruster``
    | 200 -> Item.``Imp_ Cesium-ion Thruster``
    | 201 -> Item.``Cld_ VTOL Module``
    | 202 -> Item.``Mak_ Flight Unit``
    | 203 -> Item.``Nuclear Pulse Thruster``
    | 204 -> Item.``Imp_ Surge Thruster``
    | 205 -> Item.``Mni_ Nuclear Pulse Thruster``
    | 206 -> Item.``Cld_ Cesium-ion Thruster``
    | 207 -> Item.``Biomechanical Wings``
    | 208 -> Item.``Field Propulsion Drive``
    | 209 -> Item.``Cld_ Nuclear Pulse Thruster``
    | 210 -> Item.``Exp_ Cesium-ion Thruster``
    | 211 -> Item.``Nuclear Pulse Array``
    | 212 -> Item.``Mak_ Microthruster``
    | 213 -> Item.``Impulse Thruster``
    | 214 -> Item.``Adv_ Surge Thruster``
    | 215 -> Item.``Cld_ Field Propulsion Drive``
    | 216 -> Item.``Field Propulsion Array``
    | 217 -> Item.``Diametric Drive``
    | 218 -> Item.``Flying Fortress v7``
    | 219 -> Item.``T-thruster``
    | 220 -> Item.``Integrated Tracker Drive``
    | 221 -> Item.``Etherial Propulsion``
    | 222 -> Item.``Q-thruster``
    | 223 -> Item.``Electron Diverter``
    | 224 -> Item.``Imp_ Diametric Drive``
    | 225 -> Item.``Cld_ Impulse Thruster``
    | 226 -> Item.``Impulse Thruster Array``
    | 227 -> Item.``Flightbrick``
    | 228 -> Item.``Imp_ Q-thruster``
    | 229 -> Item.``Cld_ Q-thruster``
    | 230 -> Item.``Exp_ Q-thruster``
    | 231 -> Item.``Scrap Engine``
    | 232 -> Item.``Arm_ Scrap Engine``
    | 233 -> Item.``Scrap Suit``
    | 234 -> Item.``Matter Focus``
    | 235 -> Item.``Desublimator``
    | 236 -> Item.``Power Amplifier``
    | 237 -> Item.``Adv_ Power Amplifier``
    | 238 -> Item.``Exp_ Power Amplifier``
    | 239 -> Item.``Thermal Generator``
    | 240 -> Item.``Imp_ Thermal Generator``
    | 241 -> Item.``Adv_ Thermal Generator``
    | 242 -> Item.``Exp_ Thermal Generator``
    | 243 -> Item.``Cryofiber Web``
    | 244 -> Item.``Imp_ Cryofiber Web``
    | 245 -> Item.``Adv_ Cryofiber Web``
    | 246 -> Item.``Exp_ Cryofiber Web``
    | 247 -> Item.``Heat Sink``
    | 248 -> Item.``Imp_ Heat Sink``
    | 249 -> Item.``Adv_ Heat Sink``
    | 250 -> Item.``Exp_ Heat Sink``
    | 251 -> Item.``Cooling System``
    | 252 -> Item.``Imp_ Cooling System``
    | 253 -> Item.``Adv_ Cooling System``
    | 254 -> Item.``Exp_ Cooling System``
    | 255 -> Item.``Mak_ Coolant Network``
    | 256 -> Item.``Coolant Network``
    | 257 -> Item.``Asb_ Nanovents``
    | 258 -> Item.``2N-1CE's Frost Array``
    | 259 -> Item.``Disposable Heat Sink``
    | 260 -> Item.``Coolant Injector``
    | 261 -> Item.``Imp_ Coolant Injector``
    | 262 -> Item.``Adv_ Coolant Injector``
    | 263 -> Item.``Exp_ Coolant Injector``
    | 264 -> Item.``Mak_ Microdissipator Network``
    | 265 -> Item.``Sml_ Storage Unit``
    | 266 -> Item.``Med_ Storage Unit``
    | 267 -> Item.``Lrg_ Storage Unit``
    | 268 -> Item.``Hcp_ Storage Unit``
    | 269 -> Item.``Huge Storage Unit``
    | 270 -> Item.``Cargo Storage Unit``
    | 271 -> Item.``Humpback``
    | 272 -> Item.``Vmp_ Humpback``
    | 273 -> Item.``Lightpack 2_0``
    | 274 -> Item.``Sml_ Battery``
    | 275 -> Item.``Med_ Battery``
    | 276 -> Item.``Lrg_ Battery``
    | 277 -> Item.``Hcp_ Battery``
    | 278 -> Item.``Com_ Battery``
    | 279 -> Item.``Energy Well``
    | 280 -> Item.``Imp_ Energy Well``
    | 281 -> Item.``Adv_ Energy Well``
    | 282 -> Item.``Exp_ Energy Well``
    | 283 -> Item.``Zio_ Biocell``
    | 284 -> Item.``Asb_ Biocell Array``
    | 285 -> Item.``Zio_ Biocell Array``
    | 286 -> Item.``Superbattery``
    | 287 -> Item.``Sml_ Matter Pod``
    | 288 -> Item.``Med_ Matter Pod``
    | 289 -> Item.``Lrg_ Matter Pod``
    | 290 -> Item.``Hcp_ Matter Pod``
    | 291 -> Item.``Com_ Matter Pod``
    | 292 -> Item.``Matter Compressor``
    | 293 -> Item.``Imp_ Matter Compressor``
    | 294 -> Item.``Adv_ Matter Compressor``
    | 295 -> Item.``Exp_ Matter Compressor``
    | 296 -> Item.``YI-UF0's Bottomless Matter Pit``
    | 297 -> Item.``Weight Redist_ System``
    | 298 -> Item.``Adv_ Weight Redist_ System``
    | 299 -> Item.``Gravity Neutralizer``
    | 300 -> Item.``Adv_ Gravity Neutralizer``
    | 301 -> Item.``Quantum Shading Machine``
    | 302 -> Item.``Asb_ Suspension Frame``
    | 303 -> Item.``Adv_ Quantum Shading Machine``
    | 304 -> Item.``Rocket Booster``
    | 305 -> Item.``Asb_ Metafiber Network``
    | 306 -> Item.``Zio_ Metafield Generator``
    | 307 -> Item.``ST Field Compressor``
    | 308 -> Item.``Siege Articulator``
    | 309 -> Item.``Structural Scanner``
    | 310 -> Item.``Deep Structural Scanner``
    | 311 -> Item.``Trap Scanner``
    | 312 -> Item.``Imp_ Trap Scanner``
    | 313 -> Item.``Mak_ Trap Scanner``
    | 314 -> Item.``Adv_ Trap Scanner``
    | 315 -> Item.``Machine Analyzer``
    | 316 -> Item.``Triangulator``
    | 317 -> Item.``Visual Processing Unit``
    | 318 -> Item.``Sub_ Optics``
    | 319 -> Item.``Adv_ Visual Processing Unit``
    | 320 -> Item.``Enh_ Optical Array``
    | 321 -> Item.``Exp_ Optical Array``
    | 322 -> Item.``Spectral Analyzer``
    | 323 -> Item.``Sensor Array``
    | 324 -> Item.``Imp_ Sensor Array``
    | 325 -> Item.``Adv_ Sensor Array``
    | 326 -> Item.``Lrn_ Sensor Array``
    | 327 -> Item.``Mak_ Sensor Array``
    | 328 -> Item.``Exp_ Sensor Array``
    | 329 -> Item.``Signal Interpreter``
    | 330 -> Item.``Imp_ Signal Interpreter``
    | 331 -> Item.``Adv_ Signal Interpreter``
    | 332 -> Item.``Exp_ Signal Interpreter``
    | 333 -> Item.``Active Sensor Suite``
    | 334 -> Item.``Terrain Scanner``
    | 335 -> Item.``Imp_ Terrain Scanner``
    | 336 -> Item.``Adv_ Terrain Scanner``
    | 337 -> Item.``Mak_ Terrain Scanner``
    | 338 -> Item.``Lrn_ Terrain Scanner``
    | 339 -> Item.``Exp_ Terrain Scanner``
    | 340 -> Item.``Surveybot 24 Scanner``
    | 341 -> Item.``Terrain Scan Processor``
    | 342 -> Item.``Imp_ Terrain Scan Processor``
    | 343 -> Item.``Mak_ Terrain Scan Processor``
    | 344 -> Item.``Adv_ Terrain Scan Processor``
    | 345 -> Item.``Exp_ Terrain Scan Processor``
    | 346 -> Item.``Surveybot 17 Chip``
    | 347 -> Item.``Surveybot 24 Chip``
    | 348 -> Item.``Seismic Detector``
    | 349 -> Item.``Transport Network Coupler``
    | 350 -> Item.``Modified TNC``
    | 351 -> Item.``Encrypted Comm Array``
    | 352 -> Item.``0b10 Decoder Chip _Generic_``
    | 353 -> Item.``0b10 Decoder Chip _Looter_``
    | 354 -> Item.``0b10 Decoder Chip _Scout_``
    | 355 -> Item.``0b10 Decoder Chip _Skirmisher_``
    | 356 -> Item.``0b10 Alert Chip``
    | 357 -> Item.``Salvage Targeting Computer``
    | 358 -> Item.``Imp_ Salvage Targeting Computer``
    | 359 -> Item.``Mak_ Salvage Targeting Computer``
    | 360 -> Item.``Adv_ Salvage Targeting Computer``
    | 361 -> Item.``Asb_ Combat Suite``
    | 362 -> Item.``Targeting Computer``
    | 363 -> Item.``Imp_ Targeting Computer``
    | 364 -> Item.``Mak_ Targeting Computer``
    | 365 -> Item.``Adv_ Targeting Computer``
    | 366 -> Item.``Exp_ Targeting Computer``
    | 367 -> Item.``Multitargeting Array``
    | 368 -> Item.``Tactical Coordination Suite``
    | 369 -> Item.``Melee Analysis Suite``
    | 370 -> Item.``Imp_ Melee Analysis Suite``
    | 371 -> Item.``Adv_ Melee Analysis Suite``
    | 372 -> Item.``Exp_ Melee Analysis Suite``
    | 373 -> Item.``Launcher Guidance Computer``
    | 374 -> Item.``Imp_ Launcher Guidance Computer``
    | 375 -> Item.``Adv_ Launcher Guidance Computer``
    | 376 -> Item.``Weapon Mount``
    | 377 -> Item.``Target Analyzer``
    | 378 -> Item.``Imp_ Target Analyzer``
    | 379 -> Item.``Adv_ Target Analyzer``
    | 380 -> Item.``Exp_ Target Analyzer``
    | 381 -> Item.``Core Analyzer``
    | 382 -> Item.``Exp_ Core Analyzer``
    | 383 -> Item.``Armor Integrity Analyzer``
    | 384 -> Item.``Imp_ Armor Integrity Analyzer``
    | 385 -> Item.``Exp_ Armor Integrity Analyzer``
    | 386 -> Item.``Recoil Stabilizer``
    | 387 -> Item.``Recoil Nullifier``
    | 388 -> Item.``Matter Filter``
    | 389 -> Item.``Prc_ Matter Filter``
    | 390 -> Item.``Energy Filter``
    | 391 -> Item.``Prc_ Energy Filter``
    | 392 -> Item.``Particle Charger``
    | 393 -> Item.``Imp_ Particle Charger``
    | 394 -> Item.``Adv_ Particle Charger``
    | 395 -> Item.``Particle Accelerator``
    | 396 -> Item.``Imp_ Particle Accelerator``
    | 397 -> Item.``Adv_ Particle Accelerator``
    | 398 -> Item.``Kinecellerator``
    | 399 -> Item.``Imp_ Kinecellerator``
    | 400 -> Item.``Adv_ Kinecellerator``
    | 401 -> Item.``Expert System``
    | 402 -> Item.``Heavy Servo Lattice``
    | 403 -> Item.``VL-GR5's Timing Chip``
    | 404 -> Item.``Launcher Loader``
    | 405 -> Item.``Quantum Capacitor``
    | 406 -> Item.``Weapon Cycler``
    | 407 -> Item.``Imp_ Weapon Cycler``
    | 408 -> Item.``Adv_ Weapon Cycler``
    | 409 -> Item.``Exp_ Weapon Cycler``
    | 410 -> Item.``Microactuators``
    | 411 -> Item.``Nanoactuators``
    | 412 -> Item.``Femtoactuators``
    | 413 -> Item.``Actuator Array``
    | 414 -> Item.``Imp_ Actuator Array``
    | 415 -> Item.``Adv_ Actuator Array``
    | 416 -> Item.``Exp_ Actuator Array``
    | 417 -> Item.``Force Booster``
    | 418 -> Item.``Imp_ Force Booster``
    | 419 -> Item.``Adv_ Force Booster``
    | 420 -> Item.``Stasis Canceller``
    | 421 -> Item.``Transmission Jammer``
    | 422 -> Item.``Mak_ Transmission Jammer``
    | 423 -> Item.``Imp_ Transmission Jammer``
    | 424 -> Item.``Adv_ Transmission Jammer``
    | 425 -> Item.``Exp_ Transmission Jammer``
    | 426 -> Item.``ECM Suite``
    | 427 -> Item.``Mak_ ECM Suite``
    | 428 -> Item.``Adv_ ECM Suite``
    | 429 -> Item.``Exp_ ECM Suite``
    | 430 -> Item.``Active Sensor Spoofer``
    | 431 -> Item.``Reaction Control System``
    | 432 -> Item.``Imp_ Reaction Control System``
    | 433 -> Item.``Adv_ Reaction Control System``
    | 434 -> Item.``Exp_ Reaction Control System``
    | 435 -> Item.``Phase Shifter``
    | 436 -> Item.``Imp_ Phase Shifter``
    | 437 -> Item.``Adv_ Phase Shifter``
    | 438 -> Item.``Exp_ Phase Shifter``
    | 439 -> Item.``Cloaking Device``
    | 440 -> Item.``Mak_ Cloaking Device``
    | 441 -> Item.``Imp_ Cloaking Device``
    | 442 -> Item.``Adv_ Cloaking Device``
    | 443 -> Item.``Exp_ Cloaking Device``
    | 444 -> Item.``Cloak of Protection``
    | 445 -> Item.``5H-AD0's Cloak``
    | 446 -> Item.``ID Mask``
    | 447 -> Item.``Core Shielding``
    | 448 -> Item.``Imp_ Core Shielding``
    | 449 -> Item.``Mak_ Core Shielding``
    | 450 -> Item.``Exp_ Core Shielding``
    | 451 -> Item.``Power Shielding``
    | 452 -> Item.``Imp_ Power Shielding``
    | 453 -> Item.``Mak_ Power Shielding``
    | 454 -> Item.``Exp_ Power Shielding``
    | 455 -> Item.``Propulsion Shielding``
    | 456 -> Item.``Imp_ Propulsion Shielding``
    | 457 -> Item.``Mak_ Propulsion Shielding``
    | 458 -> Item.``Exp_ Propulsion Shielding``
    | 459 -> Item.``Utility Shielding``
    | 460 -> Item.``Imp_ Utility Shielding``
    | 461 -> Item.``Mak_ Utility Shielding``
    | 462 -> Item.``Exp_ Utility Shielding``
    | 463 -> Item.``Weapon Shielding``
    | 464 -> Item.``Imp_ Weapon Shielding``
    | 465 -> Item.``Mak_ Weapon Shielding``
    | 466 -> Item.``Exp_ Weapon Shielding``
    | 467 -> Item.``Zio_ Weapon Casing``
    | 468 -> Item.``Backup Plating I``
    | 469 -> Item.``Backup Plating III``
    | 470 -> Item.``Backup Plating VII``
    | 471 -> Item.``Lgt_ Armor Plating``
    | 472 -> Item.``Med_ Armor Plating``
    | 473 -> Item.``Hvy_ Armor Plating``
    | 474 -> Item.``Zio_ Light Carapace``
    | 475 -> Item.``Zio_ Heavy Carapace``
    | 476 -> Item.``Hrd_ Light Armor Plating``
    | 477 -> Item.``Hrd_ Medium Armor Plating``
    | 478 -> Item.``Hrd_ Heavy Armor Plating``
    | 479 -> Item.``Imp_ Light Armor Plating``
    | 480 -> Item.``Imp_ Medium Armor Plating``
    | 481 -> Item.``Imp_ Heavy Armor Plating``
    | 482 -> Item.``Mak_ Light Armor Plating``
    | 483 -> Item.``Mak_ Medium Armor Plating``
    | 484 -> Item.``Mak_ Heavy Armor Plating``
    | 485 -> Item.``Lyr_ Light Armor Plating``
    | 486 -> Item.``Lyr_ Medium Armor Plating``
    | 487 -> Item.``Lyr_ Heavy Armor Plating``
    | 488 -> Item.``Gun Armor``
    | 489 -> Item.``Centrium Light Armor Plating``
    | 490 -> Item.``Centrium Medium Armor Plating``
    | 491 -> Item.``Centrium Heavy Armor Plating``
    | 492 -> Item.``Centrium Linked Plating``
    | 493 -> Item.``Reactive Plating``
    | 494 -> Item.``Med_ Reactive Plating``
    | 495 -> Item.``Mak_ Kinetic Plating``
    | 496 -> Item.``Hvy_ Reactive Plating``
    | 497 -> Item.``Superdense Plating``
    | 498 -> Item.``Reflective Plating``
    | 499 -> Item.``Med_ Reflective Plating``
    | 500 -> Item.``Mak_ Thermal Plating``
    | 501 -> Item.``Hvy_ Reflective Plating``
    | 502 -> Item.``8R-AWN's Armor_TH``
    | 503 -> Item.``8R-AWN's Armor_EX``
    | 504 -> Item.``Insulated Plating``
    | 505 -> Item.``Med_ Insulated Plating``
    | 506 -> Item.``Hvy_ Insulated Plating``
    | 507 -> Item.``Damper Plating``
    | 508 -> Item.``Zio_ Shade Carapace``
    | 509 -> Item.``Zio_ Shade Armor``
    | 510 -> Item.``Asb_ Alloy Armor``
    | 511 -> Item.``Mak_ Ablative Armor``
    | 512 -> Item.``Active Cooling Armor``
    | 513 -> Item.``Scrap Shield``
    | 514 -> Item.``Enh_ Scrap Shield``
    | 515 -> Item.``Powered Armor``
    | 516 -> Item.``Imp_ Powered Armor``
    | 517 -> Item.``Adv_ Powered Armor``
    | 518 -> Item.``Exp_ Powered Armor``
    | 519 -> Item.``1C-UTU's Buckler``
    | 520 -> Item.``Tower Shield``
    | 521 -> Item.``Lgt_ Regenerative Plating``
    | 522 -> Item.``Med_ Regenerative Plating``
    | 523 -> Item.``Hvy_ Regenerative Plating``
    | 524 -> Item.``SHELL Armor``
    | 525 -> Item.``Phase Armor``
    | 526 -> Item.``Vmp_ Brace Plating``
    | 527 -> Item.``Graphene Brace``
    | 528 -> Item.``Focal Shield``
    | 529 -> Item.``Imp_ Focal Shield``
    | 530 -> Item.``Adv_ Focal Shield``
    | 531 -> Item.``Exp_ Focal Shield``
    | 532 -> Item.``Thermal Shield``
    | 533 -> Item.``Imp_ Thermal Shield``
    | 534 -> Item.``Adv_ Thermal Shield``
    | 535 -> Item.``Exp_ Thermal Shield``
    | 536 -> Item.``Thermal Barrier``
    | 537 -> Item.``Beam Splitter``
    | 538 -> Item.``Thermal Defense Suite``
    | 539 -> Item.``Imp_ Thermal Defense Suite``
    | 540 -> Item.``Adv_ Thermal Defense Suite``
    | 541 -> Item.``Exp_ Thermal Defense Suite``
    | 542 -> Item.``Shock Absorption System``
    | 543 -> Item.``Imp_ Shock Absorption System``
    | 544 -> Item.``Exp_ Shock Absorption System``
    | 545 -> Item.``EM Disruption Field``
    | 546 -> Item.``Adv_ EM Disruption Field``
    | 547 -> Item.``Exp_ EM Disruption Field``
    | 548 -> Item.``ME-RLN's Chromatic Screen``
    | 549 -> Item.``Hardlight Generator``
    | 550 -> Item.``Imp_ Hardlight Generator``
    | 551 -> Item.``Adv_ Hardlight Generator``
    | 552 -> Item.``Exp_ Hardlight Generator``
    | 553 -> Item.``Shield Generator``
    | 554 -> Item.``Imp_ Shield Generator``
    | 555 -> Item.``Adv_ Shield Generator``
    | 556 -> Item.``Exp_ Shield Generator``
    | 557 -> Item.``Force Field``
    | 558 -> Item.``Imp_ Force Field``
    | 559 -> Item.``Adv_ Force Field``
    | 560 -> Item.``Exp_ Force Field``
    | 561 -> Item.``7V-RTL's Ultimate Field``
    | 562 -> Item.``Vortex Field Projector``
    | 563 -> Item.``Remote Shield``
    | 564 -> Item.``Imp_ Remote Shield``
    | 565 -> Item.``Adv_ Remote Shield``
    | 566 -> Item.``Remote Force Field``
    | 567 -> Item.``Imp_ Remote Force Field``
    | 568 -> Item.``Energy Mantle``
    | 569 -> Item.``Imp_ Energy Mantle``
    | 570 -> Item.``AEGIS Remote Shield``
    | 571 -> Item.``Phase Redirector``
    | 572 -> Item.``Field Manipulator``
    | 573 -> Item.``Energy Deflector``
    | 574 -> Item.``Point Defense System``
    | 575 -> Item.``Point Defense Array``
    | 576 -> Item.``Antimissile System``
    | 577 -> Item.``EX Chip 1``
    | 578 -> Item.``Hacking Suite``
    | 579 -> Item.``Mak_ Hacking Suite``
    | 580 -> Item.``Imp_ Hacking Suite``
    | 581 -> Item.``Adv_ Hacking Suite``
    | 582 -> Item.``Exp_ Hacking Suite``
    | 583 -> Item.``System Mapper``
    | 584 -> Item.``Deep Network Scanner``
    | 585 -> Item.``Architect God Chip A``
    | 586 -> Item.``EX Chip 2``
    | 587 -> Item.``System Shield``
    | 588 -> Item.``Mak_ System Shield``
    | 589 -> Item.``Imp_ System Shield``
    | 590 -> Item.``Adv_ System Shield``
    | 591 -> Item.``Exp_ System Shield``
    | 592 -> Item.``Ghost Barrier``
    | 593 -> Item.``Quantum Router``
    | 594 -> Item.``Architect God Chip D``
    | 595 -> Item.``Authchip _R_NC_``
    | 596 -> Item.``Authchip _R_Combat_``
    | 597 -> Item.``Authchip _Power_``
    | 598 -> Item.``Authchip _Propulsion_``
    | 599 -> Item.``Authchip _Device_``
    | 600 -> Item.``Authchip _Storage_``
    | 601 -> Item.``Authchip _Processor_``
    | 602 -> Item.``Authchip _Armor_``
    | 603 -> Item.``Authchip _Weapon_``
    | 604 -> Item.``Relay Coupler _NC_``
    | 605 -> Item.``Relay Coupler _C_``
    | 606 -> Item.``Relay Coupler _Swarmer_``
    | 607 -> Item.``Relay Coupler _Cutter_``
    | 608 -> Item.``Relay Coupler _Grunt_``
    | 609 -> Item.``Relay Coupler _Brawler_``
    | 610 -> Item.``Relay Coupler _Duelist_``
    | 611 -> Item.``Relay Coupler _Sentry_``
    | 612 -> Item.``Relay Coupler _Demolisher_``
    | 613 -> Item.``Relay Coupler _Specialist_``
    | 614 -> Item.``Relay Coupler _Hunter_``
    | 615 -> Item.``Relay Coupler _Heavy_``
    | 616 -> Item.``Relay Coupler _Behemoth_``
    | 617 -> Item.``Relay Coupler _Programmer_``
    | 618 -> Item.``Relay Coupler _Proto_``
    | 619 -> Item.``Skeleton Box``
    | 620 -> Item.``01-MTF's Autohacker``
    | 621 -> Item.``Component Analysis Suite``
    | 622 -> Item.``Imp_ Component Analysis Suite``
    | 623 -> Item.``Adv_ Component Analysis Suite``
    | 624 -> Item.``A0-MCA's Component Scanner``
    | 625 -> Item.``Tech Extrapolator``
    | 626 -> Item.``Dynamic Insulation System``
    | 627 -> Item.``Imp_ Dynamic Insulation System``
    | 628 -> Item.``Adv_ Dynamic Insulation System``
    | 629 -> Item.``System Guard``
    | 630 -> Item.``Imp_ System Guard``
    | 631 -> Item.``Exp_ System Guard``
    | 632 -> Item.``Corruption Screen``
    | 633 -> Item.``Imp_ Corruption Screen``
    | 634 -> Item.``Adv_ Corruption Screen``
    | 635 -> Item.``System Restoration Module``
    | 636 -> Item.``Mak_ System Restoration Module``
    | 637 -> Item.``Imp_ System Restoration Module``
    | 638 -> Item.``Adv_ System Restoration Module``
    | 639 -> Item.``System Purifier``
    | 640 -> Item.``Exp_ System Purifier``
    | 641 -> Item.``Tractor Beam``
    | 642 -> Item.``Hpw_ Tractor Beam``
    | 643 -> Item.``Lrn_ Tractor Beam``
    | 644 -> Item.``Mobile Refinery Mk_ CCLXVII``
    | 645 -> Item.``Trap Extractor``
    | 646 -> Item.``Imp_ Trap Extractor``
    | 647 -> Item.``Adv_ Trap Extractor``
    | 648 -> Item.``Trap Reconfigurator``
    | 649 -> Item.``Recalibrator``
    | 650 -> Item.``Imp_ Recalibrator``
    | 651 -> Item.``Adv_ Recalibrator``
    | 652 -> Item.``Exp_ Recalibrator``
    | 653 -> Item.``Field Recycling Unit``
    | 654 -> Item.``Imp_ Field Recycling Unit``
    | 655 -> Item.``Adv_ Field Recycling Unit``
    | 656 -> Item.``Exp_ Field Recycling Unit``
    | 657 -> Item.``Drone Bay``
    | 658 -> Item.``Z-Drone Bay``
    | 659 -> Item.``Mni_ Drone Bay``
    | 660 -> Item.``Mapping Drone Bay``
    | 661 -> Item.``Adv_ Drone Bay``
    | 662 -> Item.``Bomb Drone Bay``
    | 663 -> Item.``Thief Drone Bay``
    | 664 -> Item.``Decoy Drone Bay``
    | 665 -> Item.``Splice Drone Bay``
    | 666 -> Item.``Combat Drone Bay``
    | 667 -> Item.``Assault Drone Bay``
    | 668 -> Item.``Stealth Drone Bay``
    | 669 -> Item.``Swarm Drone Bay``
    | 670 -> Item.``Supersonic Drone Bay``
    | 671 -> Item.``Sensor Drone Bay``
    | 672 -> Item.``Hacking Drone Bay``
    | 673 -> Item.``Minesniffer Drone Bay``
    | 674 -> Item.``Army-in-a-Box``
    | 675 -> Item.``Master Drone Bay``
    | 676 -> Item.``Wardrone Bay``
    | 677 -> Item.``Cobbler Unit``
    | 678 -> Item.``Bomb Factory No_ 2``
    | 679 -> Item.``Mobile Assembly Unit``
    | 680 -> Item.``Heart of Steel``
    | 681 -> Item.``Scrapoid Pod``
    | 682 -> Item.``GOLEM Unit``
    | 683 -> Item.``PSU Rigger``
    | 684 -> Item.``Machine Rigger``
    | 685 -> Item.``Phasing AFG``
    | 686 -> Item.``AS-neutralizer No_ 17b``
    | 687 -> Item.``V3-11A's Pendant``
    | 688 -> Item.``Amulet of Y3-NDR``
    | 689 -> Item.``Chronowheel``
    | 690 -> Item.``Power Bank``
    | 691 -> Item.``Rainbow Chip``
    | 692 -> Item.``VL-GR5's Exoskeleton _Deathgrip_``
    | 693 -> Item.``Dimensional Node Initializer``
    | 694 -> Item.``Transdimensional Reconstructor``
    | 695 -> Item.``Hpw_ Transdimensional Reconstructor``
    | 696 -> Item.``Supercharged TR``
    | 697 -> Item.``Core Expander``
    | 698 -> Item.``Core Regenerator``
    | 699 -> Item.``Integrity Redistributor``
    | 700 -> Item.``Integrated Dissipator``
    | 701 -> Item.``Supercharged Integrated Dissipator``
    | 702 -> Item.``Integrated Thermoelectric Network``
    | 703 -> Item.``Integrated Reactor``
    | 704 -> Item.``Supercharged Integrated Reactor``
    | 705 -> Item.``Integrated Mediator``
    | 706 -> Item.``Core Membrane``
    | 707 -> Item.``Navigation Efficiency Matrix``
    | 708 -> Item.``Core Reset Matrix``
    | 709 -> Item.``Subatomic Replicator``
    | 710 -> Item.``Terrabomb``
    | 711 -> Item.``Core Physics Calibrator``
    | 712 -> Item.``Personal Teleporter v0_10``
    | 713 -> Item.``Telecube``
    | 714 -> Item.``Spacefold Activator``
    | 715 -> Item.``Microwarp Drive``
    | 716 -> Item.``LC Capacitor``
    | 717 -> Item.``LRC Armor``
    | 718 -> Item.``LRC Storage``
    | 719 -> Item.``LRC Energy Well``
    | 720 -> Item.``LRC Matter Compressor``
    | 721 -> Item.``LRC Inertial Stabilizer``
    | 722 -> Item.``LRC Insulator``
    | 723 -> Item.``EM Pulse Gun``
    | 724 -> Item.``Hvy_ EM Pulse Gun``
    | 725 -> Item.``EM Shotgun``
    | 726 -> Item.``Imp_ EM Shotgun``
    | 727 -> Item.``Shock Rifle``
    | 728 -> Item.``Riot Gun``
    | 729 -> Item.``Hvy_ EM Shotgun``
    | 730 -> Item.``Lightning Gun``
    | 731 -> Item.``Hvy_ Riot Gun``
    | 732 -> Item.``Arc Projector``
    | 733 -> Item.``Prc_ Shock Rifle``
    | 734 -> Item.``Hpw_ Shock Rifle``
    | 735 -> Item.``Arc Thrower``
    | 736 -> Item.``Imp_ Lightning Gun``
    | 737 -> Item.``Tesla Rifle``
    | 738 -> Item.``Imp_ Arc Projector``
    | 739 -> Item.``Hvy_ Tesla Rifle``
    | 740 -> Item.``Hyp_ EM Gauss Rifle``
    | 741 -> Item.``Imp_ Arc Thrower``
    | 742 -> Item.``01-MTF's Shockpuncher``
    | 743 -> Item.``Gamma Rifle``
    | 744 -> Item.``Tachyon Dispersion Ray``
    | 745 -> Item.``Immobilizer``
    | 746 -> Item.``Electrostorm Shotgun``
    | 747 -> Item.``Modified EM Gauss Rifle``
    | 748 -> Item.``AWS_EX-DEC``
    | 749 -> Item.``Enh_ Gamma Rifle``
    | 750 -> Item.``Med_ Laser``
    | 751 -> Item.``Sml_ Laser``
    | 752 -> Item.``Salvaging Laser``
    | 753 -> Item.``Backup Laser I``
    | 754 -> Item.``Beam Rifle``
    | 755 -> Item.``Particle Gun``
    | 756 -> Item.``Spread Laser``
    | 757 -> Item.``Imp_ Medium Laser``
    | 758 -> Item.``Sub_ Laser``
    | 759 -> Item.``Autobeam``
    | 760 -> Item.``Field Laser``
    | 761 -> Item.``Pulse Rifle``
    | 762 -> Item.``Ovr_ Pulse Rifle``
    | 763 -> Item.``Backup Laser III``
    | 764 -> Item.``Hvy_ Particle Gun``
    | 765 -> Item.``Prc_ Beam Rifle``
    | 766 -> Item.``Adv_ Beam Rifle``
    | 767 -> Item.``Hvy_ Laser``
    | 768 -> Item.``Gatling Laser``
    | 769 -> Item.``Cld_ Pulse Rifle``
    | 770 -> Item.``Hpw_ Field Laser``
    | 771 -> Item.``Imp_ Spread Laser``
    | 772 -> Item.``Mak_ Laser``
    | 773 -> Item.``Plasma Rifle``
    | 774 -> Item.``Thermic Laser``
    | 775 -> Item.``Beamcaster``
    | 776 -> Item.``Force Rifle``
    | 777 -> Item.``Imp_ Heavy Laser``
    | 778 -> Item.``Storm Laser``
    | 779 -> Item.``Zio_ Laser-S``
    | 780 -> Item.``Wave Gun``
    | 781 -> Item.``Variable Charge Gun``
    | 782 -> Item.``Hvy_ Beamcaster``
    | 783 -> Item.``Ovr_ Beamcaster``
    | 784 -> Item.``Cld_ Plasma Rifle``
    | 785 -> Item.``Enh_ Force Rifle``
    | 786 -> Item.``Hvy_ Gatling Laser``
    | 787 -> Item.``Zio_ Phaser-S``
    | 788 -> Item.``Phase Gun``
    | 789 -> Item.``Dispersion Rifle``
    | 790 -> Item.``Backup Laser VII``
    | 791 -> Item.``Plasma Storm``
    | 792 -> Item.``Adv_ Plasma Rifle``
    | 793 -> Item.``Hvy_ Wave Gun``
    | 794 -> Item.``Adv_ Variable Charge Gun``
    | 795 -> Item.``Cld_ Phase Gun``
    | 796 -> Item.``Lrn_ Gatling Laser``
    | 797 -> Item.``Warp Gun``
    | 798 -> Item.``Vortex Rifle``
    | 799 -> Item.``Zio_ Laser-M``
    | 800 -> Item.``AWS_Thermal``
    | 801 -> Item.``PD Laser``
    | 802 -> Item.``KN-7UR's Autopenetrator``
    | 803 -> Item.``Quantum Rifle``
    | 804 -> Item.``Ovr_ Quantum Rifle``
    | 805 -> Item.``Prc_ Phase Gun``
    | 806 -> Item.``Hvy_ Dispersion Rifle``
    | 807 -> Item.``Vortex Shotgun``
    | 808 -> Item.``Vortex Rail``
    | 809 -> Item.``Zio_ Phaser-M``
    | 810 -> Item.``Enh_ Quantum Rifle``
    | 811 -> Item.``Zio_ Laser-H``
    | 812 -> Item.``Hvy_ Quantum Rifle``
    | 813 -> Item.``Zio_ Phaser-H``
    | 814 -> Item.``Gatling Beam``
    | 815 -> Item.``Sigix Sheargun``
    | 816 -> Item.``Modified Sigix Sheargun``
    | 817 -> Item.``Lgt_ EM Pulse Cannon``
    | 818 -> Item.``EM Pulse Cannon``
    | 819 -> Item.``Imp_ EM Pulse Cannon``
    | 820 -> Item.``Proton Cannon``
    | 821 -> Item.``Lrn_ Proton Cannon``
    | 822 -> Item.``Disruptor Cannon``
    | 823 -> Item.``Hvy_ Proton Cannon``
    | 824 -> Item.``HERF Cannon``
    | 825 -> Item.``Hvy_ Disruptor Cannon``
    | 826 -> Item.``Cld_ Proton Cannon``
    | 827 -> Item.``Proton Burst Cannon``
    | 828 -> Item.``Com_ HERF Cannon``
    | 829 -> Item.``Latent Energy Streamer``
    | 830 -> Item.``NK-0LA's Tesla Doomcannon``
    | 831 -> Item.``EMDS``
    | 832 -> Item.``Hpw_ Disruptor Cannon``
    | 833 -> Item.``Beam Cannon``
    | 834 -> Item.``Particle Cannon``
    | 835 -> Item.``Adv_ Beam Cannon``
    | 836 -> Item.``Sub_ Beam Cannon``
    | 837 -> Item.``Hvy_ Particle Cannon``
    | 838 -> Item.``Ion Cannon``
    | 839 -> Item.``Plasma Cannon``
    | 840 -> Item.``Hvy_ Ion Cannon``
    | 841 -> Item.``Cld_ Particle Cannon``
    | 842 -> Item.``Phase Cannon``
    | 843 -> Item.``Hvy_ Plasma Cannon``
    | 844 -> Item.``Cld_ Plasma Cannon``
    | 845 -> Item.``Com_ Ion Cannon``
    | 846 -> Item.``Ion Burst Cannon``
    | 847 -> Item.``Adv_ Plasma Cannon``
    | 848 -> Item.``Hvy_ Phase Cannon``
    | 849 -> Item.``Neutron Cannon``
    | 850 -> Item.``Powered Cannon``
    | 851 -> Item.``Matter Neutralizer``
    | 852 -> Item.``Hvy_ Neutron Cannon``
    | 853 -> Item.``Lrn_ Phase Cannon``
    | 854 -> Item.``Cld_ Phase Cannon``
    | 855 -> Item.``Vortex Cannon``
    | 856 -> Item.``Gui_ Plasma Cannon``
    | 857 -> Item.``Nova Cannon``
    | 858 -> Item.``Imp_ Matter Neutralizer``
    | 859 -> Item.``Exp_ Thermic Cannon``
    | 860 -> Item.``Vortex Driver``
    | 861 -> Item.``Zio_ Alpha Cannon``
    | 862 -> Item.``Asb_ Focal Cannon``
    | 863 -> Item.``Enh_ Nova Cannon``
    | 864 -> Item.``Firepult``
    | 865 -> Item.``YOLO Cannon``
    | 866 -> Item.``Potential Cannon``
    | 867 -> Item.``Warp Cannon``
    | 868 -> Item.``Cld_ Nova Cannon``
    | 869 -> Item.``Null Cannon``
    | 870 -> Item.``Hyp_ Alpha Cannon``
    | 871 -> Item.``Zio_ Alpha Cannon Mk_ II``
    | 872 -> Item.``Imp_ Potential Cannon``
    | 873 -> Item.``Multinova Projection Cannon``
    | 874 -> Item.``Disintegrator``
    | 875 -> Item.``Core Cannon``
    | 876 -> Item.``Sigix Shearcannon``
    | 877 -> Item.``Drained L-Cannon``
    | 878 -> Item.``L-Cannon``
    | 879 -> Item.``BFG-9k Vortex Edition``
    | 880 -> Item.``Assault Rifle``
    | 881 -> Item.``Asb_ Rifle``
    | 882 -> Item.``Lgt_ Assault Rifle``
    | 883 -> Item.``Bolt Gun``
    | 884 -> Item.``Hvy_ Assault Rifle``
    | 885 -> Item.``Autogun``
    | 886 -> Item.``Shotgun``
    | 887 -> Item.``Battle Rifle``
    | 888 -> Item.``Asb_ Heavy Rifle``
    | 889 -> Item.``Sub_ Machine Gun``
    | 890 -> Item.``Imp_ Assault Rifle``
    | 891 -> Item.``Minigun``
    | 892 -> Item.``Hpw_ Shotgun``
    | 893 -> Item.``Asb_ Shotgun``
    | 894 -> Item.``Barrage Gun``
    | 895 -> Item.``Ovr_ Barrage Gun``
    | 896 -> Item.``Enh_ Autogun``
    | 897 -> Item.``Gauss Rifle``
    | 898 -> Item.``Asb_ Gauss Rifle``
    | 899 -> Item.``Flak Gun``
    | 900 -> Item.``Prc_ Assault Rifle``
    | 901 -> Item.``Hvy_ Battle Rifle``
    | 902 -> Item.``Mak_ Shrapnel Gun``
    | 903 -> Item.``Coil Gun``
    | 904 -> Item.``Hyp_ Gauss Rifle``
    | 905 -> Item.``Hvy_ Machine Gun``
    | 906 -> Item.``Imp_ Heavy Machine Gun``
    | 907 -> Item.``Com_ Gauss Rifle``
    | 908 -> Item.``XL Autogun Subcomponent``
    | 909 -> Item.``KE Penetrator``
    | 910 -> Item.``Hyp_ Coil Gun``
    | 911 -> Item.``Ovr_ Coil Gun``
    | 912 -> Item.``Imp_ KE Penetrator``
    | 913 -> Item.``Enh_ Coil Gun``
    | 914 -> Item.``Com_ Coil Gun``
    | 915 -> Item.``Railgun``
    | 916 -> Item.``Adv_ KE Penetrator``
    | 917 -> Item.``Linked Autogun``
    | 918 -> Item.``AWS_Gauss``
    | 919 -> Item.``Hyp_ Railgun``
    | 920 -> Item.``Ovr_ Railgun``
    | 921 -> Item.``Helical Railgun``
    | 922 -> Item.``Com_ Railgun``
    | 923 -> Item.``XL Autogun Array``
    | 924 -> Item.``12-ASH's Boomstick``
    | 925 -> Item.``8R-AWN's Boregun``
    | 926 -> Item.``Multirail``
    | 927 -> Item.``Hyp_ Multirail``
    | 928 -> Item.``5H-AD0's Sniper Rifle``
    | 929 -> Item.``A3's Sniper Rifle``
    | 930 -> Item.``Lgt_ Cannon``
    | 931 -> Item.``Imp_ Light Cannon``
    | 932 -> Item.``Battle Cannon``
    | 933 -> Item.``Assault Cannon``
    | 934 -> Item.``Hvy_ Assault Cannon``
    | 935 -> Item.``Flak Cannon``
    | 936 -> Item.``Adv_ Assault Cannon``
    | 937 -> Item.``Gauss Cannon``
    | 938 -> Item.``Slug Cannon``
    | 939 -> Item.``Mni_ Assault Cannon``
    | 940 -> Item.``Siege Cannon Replica``
    | 941 -> Item.``Magnetic Acceleration Cannon``
    | 942 -> Item.``Hvy_ Flak Cannon``
    | 943 -> Item.``Bore Cannon``
    | 944 -> Item.``Antimatter Cannon``
    | 945 -> Item.``Siege Cannon``
    | 946 -> Item.``Mass Driver``
    | 947 -> Item.``Hvy_ Mass Driver``
    | 948 -> Item.``Enh_ Gauss Cannon``
    | 949 -> Item.``Hyp_ Gauss Cannon``
    | 950 -> Item.``Tri-rail Accelerator``
    | 951 -> Item.``Hardcell Cannon``
    | 952 -> Item.``Hvy_ Gauss Cannon``
    | 953 -> Item.``Hyp_ Mass Driver``
    | 954 -> Item.``Hvy_ Autocannon``
    | 955 -> Item.``DAS Cannon``
    | 956 -> Item.``Lgt_ Antimatter Cannon``
    | 957 -> Item.``Linear Accelerator``
    | 958 -> Item.``Hvy_ Linear Accelerator``
    | 959 -> Item.``Com_ Mass Driver``
    | 960 -> Item.``Hvy_ Hardcell Cannon``
    | 961 -> Item.``Com_ Linear Accelerator``
    | 962 -> Item.``Hyp_ Linear Accelerator``
    | 963 -> Item.``Hcl_ Linear Accelerator``
    | 964 -> Item.``Graviton Cannon``
    | 965 -> Item.``Blast Cannon``
    | 966 -> Item.``P1-3CE's Gatling Flakker``
    | 967 -> Item.``AWS_Autocannon``
    | 968 -> Item.``Perforator``
    | 969 -> Item.``Omega Cannon``
    | 970 -> Item.``PL-3XN's Obliterator``
    | 971 -> Item.``EMP Blaster``
    | 972 -> Item.``Shock Bomb Launcher``
    | 973 -> Item.``Adv_ EMP Blaster``
    | 974 -> Item.``Proton Missile Launcher``
    | 975 -> Item.``Imp_ Proton Missile Launcher``
    | 976 -> Item.``Gui_ EMP Blaster``
    | 977 -> Item.``Hvy_ Shock Bomb Launcher``
    | 978 -> Item.``Tesla Bomb Launcher``
    | 979 -> Item.``Hvy_ Proton Missile Launcher``
    | 980 -> Item.``Com_ Tesla Bomb Launcher``
    | 981 -> Item.``Gamma Bomb Array``
    | 982 -> Item.``Enh_ Gamma Bomb Array``
    | 983 -> Item.``Grenade Launcher``
    | 984 -> Item.``Rocket Launcher``
    | 985 -> Item.``Mni_ Grenade Launcher``
    | 986 -> Item.``Sub_ Shrapnel Launcher``
    | 987 -> Item.``Imp_ Grenade Launcher``
    | 988 -> Item.``Missile Launcher``
    | 989 -> Item.``Concussive RPG``
    | 990 -> Item.``YI-UF0's Doublenader``
    | 991 -> Item.``Hvy_ Rocket Launcher``
    | 992 -> Item.``Hvy_ Missile Launcher``
    | 993 -> Item.``Gui_ Missile Launcher``
    | 994 -> Item.``Prc_ Grenade Launcher``
    | 995 -> Item.``Rocket Array``
    | 996 -> Item.``Lrn_ Missile Launcher``
    | 997 -> Item.``Imp_ Concussive RPG``
    | 998 -> Item.``Prc_ Rocket Launcher``
    | 999 -> Item.``Scatter Rocket Array``
    | 1000 -> Item.``Smartbomb Launcher``
    | 1001 -> Item.``Mni_ Smartbomb Launcher``
    | 1002 -> Item.``Tiamat Missile Launcher``
    | 1003 -> Item.``Thermoblaster``
    | 1004 -> Item.``Micro-nuke Launcher``
    | 1005 -> Item.``Adv_ Concussive RPG``
    | 1006 -> Item.``Neutron Missile Launcher``
    | 1007 -> Item.``Fusion Bomb Launcher``
    | 1008 -> Item.``Hellfire Missile Launcher``
    | 1009 -> Item.``Adv_ Micro-nuke Launcher``
    | 1010 -> Item.``Tactical Quantum Warhead``
    | 1011 -> Item.``Vortex Catalyst Activator``
    | 1012 -> Item.``Chain Missile Launcher``
    | 1013 -> Item.``Ragnarok Missile Launcher``
    | 1014 -> Item.``Point Singularity Launcher``
    | 1015 -> Item.``Gui_ Micro-nuke Launcher``
    | 1016 -> Item.``99-TNT's Nukerbomber``
    | 1017 -> Item.``Exp_ Neutron Missile Launcher``
    | 1018 -> Item.``Z-bomb Delivery System``
    | 1019 -> Item.``Sigix Terminator``
    | 1020 -> Item.``Supercharged Sigix Terminator``
    | 1021 -> Item.``Containment Facilitator``
    | 1022 -> Item.``Detonator``
    | 1023 -> Item.``Dirty Datajack``
    | 1024 -> Item.``Splice Injector``
    | 1025 -> Item.``Master Link``
    | 1026 -> Item.``Datajack``
    | 1027 -> Item.``Imp_ Datajack``
    | 1028 -> Item.``Adv_ Datajack``
    | 1029 -> Item.``Remote Datajack``
    | 1030 -> Item.``Imp_ Remote Datajack``
    | 1031 -> Item.``Adv_ Remote Datajack``
    | 1032 -> Item.``Exp_ Remote Datajack``
    | 1033 -> Item.``Gui_ Remote Datajack``
    | 1034 -> Item.``ME-RLN's Wand``
    | 1035 -> Item.``System Spiker``
    | 1036 -> Item.``Field Lobotomy Kit``
    | 1037 -> Item.``Mining Laser``
    | 1038 -> Item.``LU-1G1's Laser Shovel``
    | 1039 -> Item.``Welding Torch``
    | 1040 -> Item.``Plasma Cutter``
    | 1041 -> Item.``Imp_ Plasma Cutter``
    | 1042 -> Item.``Exp_ Plasma Cutter``
    | 1043 -> Item.``CPS Tube``
    | 1044 -> Item.``Multitool``
    | 1045 -> Item.``Flamer``
    | 1046 -> Item.``Asb_ F-torch``
    | 1047 -> Item.``Enh_ Flamer``
    | 1048 -> Item.``Plasma Flamer``
    | 1049 -> Item.``Asb_ P-torch``
    | 1050 -> Item.``RU-N14's Throwing Claymores``
    | 1051 -> Item.``RU-N14's Throwing Claymores v3``
    | 1052 -> Item.``Warlord Statue``
    | 1053 -> Item.``Voltaic Drivehammer``
    | 1054 -> Item.``AD-0RF's Magmablaster``
    | 1055 -> Item.``IN-MT5's Pitchfork _Insurrection_``
    | 1056 -> Item.``Shield Trident``
    | 1057 -> Item.``Junk Cannon``
    | 1058 -> Item.``Stasis Beam``
    | 1059 -> Item.``Stasis Projector``
    | 1060 -> Item.``Exp_ Stasis Projector``
    | 1061 -> Item.``Molecular Deconstructor``
    | 1062 -> Item.``SE_WE1``
    | 1063 -> Item.``SE_WE2``
    | 1064 -> Item.``SE_WE3``
    | 1065 -> Item.``SE_WE4``
    | 1066 -> Item.``SE_WE5``
    | 1067 -> Item.``Hammer``
    | 1068 -> Item.``Mace``
    | 1069 -> Item.``Flail``
    | 1070 -> Item.``Maul``
    | 1071 -> Item.``Asb_ Maul``
    | 1072 -> Item.``Hvy_ Hammer``
    | 1073 -> Item.``Hvy_ Mace``
    | 1074 -> Item.``Hvy_ Flail``
    | 1075 -> Item.``Great Maul``
    | 1076 -> Item.``Powered Hammer``
    | 1077 -> Item.``Mak_ Hammer``
    | 1078 -> Item.``Power Maul``
    | 1079 -> Item.``Asb_ P-maul``
    | 1080 -> Item.``Impact Mace``
    | 1081 -> Item.``Shock Maul``
    | 1082 -> Item.``Thunder Hammer``
    | 1083 -> Item.``Compactor``
    | 1084 -> Item.``Gravity Flail``
    | 1085 -> Item.``CL-ANK's Mallet``
    | 1086 -> Item.``Core Stripper``
    | 1087 -> Item.``Mining Claw``
    | 1088 -> Item.``EC_1``
    | 1089 -> Item.``Katana``
    | 1090 -> Item.``Asb_ Blade``
    | 1091 -> Item.``Scythe``
    | 1092 -> Item.``Axe``
    | 1093 -> Item.``Blade Saw``
    | 1094 -> Item.``EC_3``
    | 1095 -> Item.``Chainsword``
    | 1096 -> Item.``Ripper``
    | 1097 -> Item.``Mak_ Axe``
    | 1098 -> Item.``Mak_ Sword``
    | 1099 -> Item.``Great Axe``
    | 1100 -> Item.``Greatsword``
    | 1101 -> Item.``Ripteeth``
    | 1102 -> Item.``Power Sword``
    | 1103 -> Item.``Asb_ P-sword``
    | 1104 -> Item.``Falx``
    | 1105 -> Item.``Carbide Saw``
    | 1106 -> Item.``Segregator``
    | 1107 -> Item.``Tearclaws``
    | 1108 -> Item.``Companion Sword``
    | 1109 -> Item.``EC_5``
    | 1110 -> Item.``Phasing Sabre``
    | 1111 -> Item.``Plasma Sword``
    | 1112 -> Item.``Ionic Axe``
    | 1113 -> Item.``Mni_ Tearclaws``
    | 1114 -> Item.``Vmp_ Broadsword``
    | 1115 -> Item.``Dual-blade Saw``
    | 1116 -> Item.``Vibroblade``
    | 1117 -> Item.``Molecular Scythe``
    | 1118 -> Item.``Centrium Greatsword``
    | 1119 -> Item.``Master Tearclaws``
    | 1120 -> Item.``Longsword _1``
    | 1121 -> Item.``EC_7``
    | 1122 -> Item.``Nanosword``
    | 1123 -> Item.``Particle Cleaver``
    | 1124 -> Item.``Centrium Claws``
    | 1125 -> Item.``1C-UTU's Sword _Lootmaker_``
    | 1126 -> Item.``DM-GVY's Chainsaw``
    | 1127 -> Item.``Vortex Shredder``
    | 1128 -> Item.``EC_9``
    | 1129 -> Item.``1C-UTU's Sword _Choppy_``
    | 1130 -> Item.``Quantum Companion``
    | 1131 -> Item.``Superquantum Companion``
    | 1132 -> Item.``Quantum Blade``
    | 1133 -> Item.``Sigix Broadsword``
    | 1134 -> Item.``Spear``
    | 1135 -> Item.``Mak_ Spear``
    | 1136 -> Item.``CR-A16's Pointy Stick``
    | 1137 -> Item.``Hvy_ Pick``
    | 1138 -> Item.``Lance``
    | 1139 -> Item.``Kinetic Spear``
    | 1140 -> Item.``Force Lance``
    | 1141 -> Item.``Plasma Lance``
    | 1142 -> Item.``Enh_ Force Lance``
    | 1143 -> Item.``Vortex Lance``
    | 1144 -> Item.``CR-A16's Behemoth Slayer``
    | 1145 -> Item.``Thermal Lance``
    | 1146 -> Item.``Blade Trap``
    | 1147 -> Item.``Segregator Trap``
    | 1148 -> Item.``Explosive Trap``
    | 1149 -> Item.``Heavy Explosive Trap``
    | 1150 -> Item.``Tiamat Bomb Trap``
    | 1151 -> Item.``Fusion Bomb Trap``
    | 1152 -> Item.``Hellfire Trap``
    | 1153 -> Item.``Armageddon Trap``
    | 1154 -> Item.``Dirty Bomb Trap``
    | 1155 -> Item.``EMP Trap``
    | 1156 -> Item.``Proton Bomb Trap``
    | 1157 -> Item.``Tesla Bomb Trap``
    | 1158 -> Item.``Gamma Bomb Trap``
    | 1159 -> Item.``Shrapnel Trap``
    | 1160 -> Item.``Vortex Trap``
    | 1161 -> Item.``Piercing Trap``
    | 1162 -> Item.``Shock Trap``
    | 1163 -> Item.``EM Surge Trap``
    | 1164 -> Item.``Fire Trap``
    | 1165 -> Item.``Heat Bomb Trap``
    | 1166 -> Item.``Stasis Trap``
    | 1167 -> Item.``Scrap Shield Fragment``
    | 1168 -> Item.``SUBCON Basin``
    | 1169 -> Item.``Signal Generator``
    | 1170 -> Item.``Self-destruct Interrupter``
    | 1171 -> Item.``DRS Beacon``
    | 1172 -> Item.``Sapper Charge``
    | 1173 -> Item.``Deploy-a-Sentry``
    | 1174 -> Item.``Botcube``
    | 1175 -> Item.``Lrg_ Botcube``
    | 1176 -> Item.``PL-3XN's Ring of Power``
    | 1177 -> Item.``Disassembled Obliterator``
    | 1178 -> Item.``GAL Module``
    | 1179 -> Item.``Portable AFG``
    | 1180 -> Item.``Zhirov Special``
    | 1181 -> Item.``SGEMP Prototype``
    | 1182 -> Item.``Terrabomb Derivative``
    | 1183 -> Item.``Sigix Containment Pod``
    | 1184 -> Item.``Sigix Corpse``
    | 1185 -> Item.``Meganuke``
    | 1186 -> Item.``Gamma Refractor``
    | x -> raise (System.ArgumentException(sprintf "Invalid item id! %A" x))


let itemString =
    function
    | Item.``Matter`` -> "Matter"
    | Item.``Data Core`` -> "Data Core"
    | Item.``Derelict Log`` -> "Derelict Log"
    | Item.``Schematic Archive`` -> "Schematic Archive"
    | Item.``Imprinter Data Core`` -> "Imprinter Data Core"
    | Item.``A2 Data Core`` -> "A2 Data Core"
    | Item.``A7 Data Core`` -> "A7 Data Core"
    | Item.``MAIN_C Data Core`` -> "MAIN.C Data Core"
    | Item.``Architect Data Core`` -> "Architect Data Core"
    | Item.``Scrap`` -> "Scrap"
    | Item.``Protomatter`` -> "Protomatter"
    | Item.``Ion Engine`` -> "Ion Engine"
    | Item.``Lgt_ Ion Engine`` -> "Lgt. Ion Engine"
    | Item.``Backup Power I`` -> "Backup Power I"
    | Item.``Imp_ Ion Engine`` -> "Imp. Ion Engine"
    | Item.``Rnf_ Ion Engine`` -> "Rnf. Ion Engine"
    | Item.``Hvy_ Ion Engine`` -> "Hvy. Ion Engine"
    | Item.``Cld_ Ion Engine`` -> "Cld. Ion Engine"
    | Item.``Sub_ Power Source`` -> "Sub. Power Source"
    | Item.``Deuterium Engine`` -> "Deuterium Engine"
    | Item.``Lgt_ Deuterium Engine`` -> "Lgt. Deuterium Engine"
    | Item.``Backup Power III`` -> "Backup Power III"
    | Item.``Nuclear Core`` -> "Nuclear Core"
    | Item.``Lgt_ Nuclear Core`` -> "Lgt. Nuclear Core"
    | Item.``Imp_ Deuterium Engine`` -> "Imp. Deuterium Engine"
    | Item.``Rnf_ Deuterium Engine`` -> "Rnf. Deuterium Engine"
    | Item.``Hyb_ Deuterium Engine`` -> "Hyb. Deuterium Engine"
    | Item.``Hvy_ Deuterium Engine`` -> "Hvy. Deuterium Engine"
    | Item.``Cld_ Deuterium Engine`` -> "Cld. Deuterium Engine"
    | Item.``Enh_ Nuclear Core`` -> "Enh. Nuclear Core"
    | Item.``Mic_ Nuclear Core`` -> "Mic. Nuclear Core"
    | Item.``Mak_ Power Source`` -> "Mak. Power Source"
    | Item.``Angular Momentum Engine`` -> "Angular Momentum Engine"
    | Item.``Lgt_ Angular Momentum Engine`` -> "Lgt. Angular Momentum Engine"
    | Item.``F-cell Engine`` -> "F-cell Engine"
    | Item.``Fission Core`` -> "Fission Core"
    | Item.``Lgt_ Fission Core`` -> "Lgt. Fission Core"
    | Item.``Hyb_ Fission Core`` -> "Hyb. Fission Core"
    | Item.``Fusion Compressor`` -> "Fusion Compressor"
    | Item.``Cold Fusion Reactor`` -> "Cold Fusion Reactor"
    | Item.``Neutrino Core`` -> "Neutrino Core"
    | Item.``Lgt_ Neutrino Core`` -> "Lgt. Neutrino Core"
    | Item.``Rnf_ Fission Core`` -> "Rnf. Fission Core"
    | Item.``Enh_ Fission Core`` -> "Enh. Fission Core"
    | Item.``Cld_ Fission Core`` -> "Cld. Fission Core"
    | Item.``Mic_ Fission Core`` -> "Mic. Fission Core"
    | Item.``Fusion Reactor`` -> "Fusion Reactor"
    | Item.``Antimatter Reactor`` -> "Antimatter Reactor"
    | Item.``Lgt_ Antimatter Reactor`` -> "Lgt. Antimatter Reactor"
    | Item.``Rnf_ Antimatter Reactor`` -> "Rnf. Antimatter Reactor"
    | Item.``Hyb_ Antimatter Reactor`` -> "Hyb. Antimatter Reactor"
    | Item.``Backup Power VII`` -> "Backup Power VII"
    | Item.``MA-1KR's Cyclogen`` -> "MA-1KR's Cyclogen"
    | Item.``Hvy_ Antimatter Reactor`` -> "Hvy. Antimatter Reactor"
    | Item.``Mni_ Fusion Reactor`` -> "Mni. Fusion Reactor"
    | Item.``Imp_ Fusion Compressor`` -> "Imp. Fusion Compressor"
    | Item.``Mic_ Neutrino Core`` -> "Mic. Neutrino Core"
    | Item.``Zio_ Light DM Reactor`` -> "Zio. Light DM Reactor"
    | Item.``Zio_ Heavy DM Reactor`` -> "Zio. Heavy DM Reactor"
    | Item.``Particle Reactor`` -> "Particle Reactor"
    | Item.``Lgt_ Particle Reactor`` -> "Lgt. Particle Reactor"
    | Item.``Mic_ Antimatter Reactor`` -> "Mic. Antimatter Reactor"
    | Item.``Com_ Particle Reactor`` -> "Com. Particle Reactor"
    | Item.``Cld_ Antimatter Reactor`` -> "Cld. Antimatter Reactor"
    | Item.``Graviton Reactor`` -> "Graviton Reactor"
    | Item.``Asb_ Flux Generator`` -> "Asb. Flux Generator"
    | Item.``Quantum Reactor`` -> "Quantum Reactor"
    | Item.``Lgt_ Quantum Reactor`` -> "Lgt. Quantum Reactor"
    | Item.``Rnf_ Quantum Reactor`` -> "Rnf. Quantum Reactor"
    | Item.``Imp_ Quantum Reactor`` -> "Imp. Quantum Reactor"
    | Item.``Zero-point Reactor`` -> "Zero-point Reactor"
    | Item.``Vortex Chain Reactor`` -> "Vortex Chain Reactor"
    | Item.``Singularity Reactor`` -> "Singularity Reactor"
    | Item.``Matter Drive`` -> "Matter Drive"
    | Item.``Meta Core`` -> "Meta Core"
    | Item.``SE_PO1`` -> "SE_PO1"
    | Item.``Lgt_ Treads`` -> "Lgt. Treads"
    | Item.``Imp_ Treads`` -> "Imp. Treads"
    | Item.``Spk_ Treads`` -> "Spk. Treads"
    | Item.``Arm_ Treads`` -> "Arm. Treads"
    | Item.``Adv_ Treads`` -> "Adv. Treads"
    | Item.``Ovr_ Treads`` -> "Ovr. Treads"
    | Item.``Med_ Treads`` -> "Med. Treads"
    | Item.``Imp_ Medium Treads`` -> "Imp. Medium Treads"
    | Item.``Spk_ Medium Treads`` -> "Spk. Medium Treads"
    | Item.``Arm_ Medium Treads`` -> "Arm. Medium Treads"
    | Item.``Hvy_ Treads`` -> "Hvy. Treads"
    | Item.``Ovr_ Medium Treads`` -> "Ovr. Medium Treads"
    | Item.``Tri-treads`` -> "Tri-treads"
    | Item.``Wartreads`` -> "Wartreads"
    | Item.``Adv_ Medium Treads`` -> "Adv. Medium Treads"
    | Item.``Enh_ Armored Medium Treads`` -> "Enh. Armored Medium Treads"
    | Item.``Imp_ Heavy Treads`` -> "Imp. Heavy Treads"
    | Item.``Hvy_ Siege Treads`` -> "Hvy. Siege Treads"
    | Item.``Spk_ Heavy Treads`` -> "Spk. Heavy Treads"
    | Item.``Vmp_ Heavy Siege Treads`` -> "Vmp. Heavy Siege Treads"
    | Item.``DD-05H's Wartreads`` -> "DD-05H's Wartreads"
    | Item.``Biometal Medium Treads`` -> "Biometal Medium Treads"
    | Item.``Arm_ Heavy Treads`` -> "Arm. Heavy Treads"
    | Item.``Adv_ Heavy Treads`` -> "Adv. Heavy Treads"
    | Item.``Imp_ Heavy Siege Treads`` -> "Imp. Heavy Siege Treads"
    | Item.``Centrium Heavy Treads`` -> "Centrium Heavy Treads"
    | Item.``Megatreads`` -> "Megatreads"
    | Item.``Biometal Heavy Treads`` -> "Biometal Heavy Treads"
    | Item.``Exp_ Biometal Heavy Treads`` -> "Exp. Biometal Heavy Treads"
    | Item.``Enh_ Armored Heavy Treads`` -> "Enh. Armored Heavy Treads"
    | Item.``Adv_ Heavy Siege Treads`` -> "Adv. Heavy Siege Treads"
    | Item.``Hdn_ Centrium Heavy Treads`` -> "Hdn. Centrium Heavy Treads"
    | Item.``Exp_ Biometal Medium Treads`` -> "Exp. Biometal Medium Treads"
    | Item.``Aluminum Leg`` -> "Aluminum Leg"
    | Item.``Imp_ Aluminum Leg`` -> "Imp. Aluminum Leg"
    | Item.``Carbon-fiber Leg`` -> "Carbon-fiber Leg"
    | Item.``Titanium Leg`` -> "Titanium Leg"
    | Item.``Ovr_ Titanium Leg`` -> "Ovr. Titanium Leg"
    | Item.``VSS Leg`` -> "VSS Leg"
    | Item.``Imp_ Carbon-fiber Leg`` -> "Imp. Carbon-fiber Leg"
    | Item.``Imp_ Titanium Leg`` -> "Imp. Titanium Leg"
    | Item.``Lgt_ Armored Exoskeleton`` -> "Lgt. Armored Exoskeleton"
    | Item.``Mak_ Leg`` -> "Mak. Leg"
    | Item.``Flexi-carbon Leg`` -> "Flexi-carbon Leg"
    | Item.``Arm_ Leg`` -> "Arm. Leg"
    | Item.``Imp_ VSS Leg`` -> "Imp. VSS Leg"
    | Item.``Zio_ Composite Leg I`` -> "Zio. Composite Leg I"
    | Item.``Med_ Armored Exoskeleton`` -> "Med. Armored Exoskeleton"
    | Item.``Ovr_ Flexi-carbon Leg`` -> "Ovr. Flexi-carbon Leg"
    | Item.``Enh_ Flexi-carbon Leg`` -> "Enh. Flexi-carbon Leg"
    | Item.``Enh_ Armored Leg`` -> "Enh. Armored Leg"
    | Item.``Arachnoskeleton`` -> "Arachnoskeleton"
    | Item.``Myomer Leg`` -> "Myomer Leg"
    | Item.``Adv_ VSS Leg`` -> "Adv. VSS Leg"
    | Item.``Adv_ Myomer Leg`` -> "Adv. Myomer Leg"
    | Item.``Exp_ Flexi-carbon Leg`` -> "Exp. Flexi-carbon Leg"
    | Item.``Zio_ Composite Leg II`` -> "Zio. Composite Leg II"
    | Item.``Cargo Legs`` -> "Cargo Legs"
    | Item.``Etherial Tendrils`` -> "Etherial Tendrils"
    | Item.``Biometal Leg`` -> "Biometal Leg"
    | Item.``Hvy_ Armored Exoskeleton`` -> "Hvy. Armored Exoskeleton"
    | Item.``Enh_ Biometal Leg`` -> "Enh. Biometal Leg"
    | Item.``Exp_ Myomer Leg`` -> "Exp. Myomer Leg"
    | Item.``Tripod Weapons Platform`` -> "Tripod Weapons Platform"
    | Item.``T_R_O_L_L_ Exoskeleton`` -> "T.R.O.L.L. Exoskeleton"
    | Item.``Asb_ Alloy Leg`` -> "Asb. Alloy Leg"
    | Item.``Centrium Leg`` -> "Centrium Leg"
    | Item.``Hdn_ Centrium Leg`` -> "Hdn. Centrium Leg"
    | Item.``Exp_ Biometal Leg`` -> "Exp. Biometal Leg"
    | Item.``Zio_ Supercomposite Leg`` -> "Zio. Supercomposite Leg"
    | Item.``Potential Leg`` -> "Potential Leg"
    | Item.``Myomer Exoskeleton`` -> "Myomer Exoskeleton"
    | Item.``Sigix Exoskeleton`` -> "Sigix Exoskeleton"
    | Item.``SE_PR1`` -> "SE_PR1"
    | Item.``Wheel`` -> "Wheel"
    | Item.``Com_ Wheel`` -> "Com. Wheel"
    | Item.``Arm_ Wheel`` -> "Arm. Wheel"
    | Item.``Sub_ Monowheel`` -> "Sub. Monowheel"
    | Item.``Ovr_ Scrapsphere`` -> "Ovr. Scrapsphere"
    | Item.``Arm_ Huge Wheel`` -> "Arm. Huge Wheel"
    | Item.``Ballwheel`` -> "Ballwheel"
    | Item.``Ovr_ Huge Scrapsphere`` -> "Ovr. Huge Scrapsphere"
    | Item.``Centrium Wheel`` -> "Centrium Wheel"
    | Item.``Hdn_ Centrium Wheel`` -> "Hdn. Centrium Wheel"
    | Item.``Hover Unit`` -> "Hover Unit"
    | Item.``Backup Propulsion I`` -> "Backup Propulsion I"
    | Item.``Imp_ Hover Unit`` -> "Imp. Hover Unit"
    | Item.``Airjet`` -> "Airjet"
    | Item.``Aerolev Unit`` -> "Aerolev Unit"
    | Item.``Asb_ Hover Unit`` -> "Asb. Hover Unit"
    | Item.``Backup Propulsion III`` -> "Backup Propulsion III"
    | Item.``Gravmag System`` -> "Gravmag System"
    | Item.``Asb_ Hover System`` -> "Asb. Hover System"
    | Item.``Imp_ Airjet`` -> "Imp. Airjet"
    | Item.``Cld_ Airjet`` -> "Cld. Airjet"
    | Item.``Imp_ Gravmag System`` -> "Imp. Gravmag System"
    | Item.``Cld_ Aerolev Unit`` -> "Cld. Aerolev Unit"
    | Item.``Cmb_ Airjet`` -> "Cmb. Airjet"
    | Item.``Gravmag Array`` -> "Gravmag Array"
    | Item.``Mak_ Hover Unit`` -> "Mak. Hover Unit"
    | Item.``Zio_ Glidesys I`` -> "Zio. Glidesys I"
    | Item.``Antigrav System`` -> "Antigrav System"
    | Item.``Gyrokinetic Inverter`` -> "Gyrokinetic Inverter"
    | Item.``Linear Gravjet`` -> "Linear Gravjet"
    | Item.``Cld_ Gravmag System`` -> "Cld. Gravmag System"
    | Item.``Cmb_ Gravmag System`` -> "Cmb. Gravmag System"
    | Item.``Imp_ Antigrav System`` -> "Imp. Antigrav System"
    | Item.``Imp_ Gyrokinetic Inverter`` -> "Imp. Gyrokinetic Inverter"
    | Item.``Imp_ Linear Gravjet`` -> "Imp. Linear Gravjet"
    | Item.``Backup Propulsion VII`` -> "Backup Propulsion VII"
    | Item.``Zio_ Glidesys II`` -> "Zio. Glidesys II"
    | Item.``Cld_ Antigrav System`` -> "Cld. Antigrav System"
    | Item.``Cmb_ Antigrav System`` -> "Cmb. Antigrav System"
    | Item.``Antigrav Array`` -> "Antigrav Array"
    | Item.``Exp_ Gyrokinetic Inverter`` -> "Exp. Gyrokinetic Inverter"
    | Item.``Cld_ Linear Gravjet`` -> "Cld. Linear Gravjet"
    | Item.``Cmb_ Linear Gravjet`` -> "Cmb. Linear Gravjet"
    | Item.``Flight Unit`` -> "Flight Unit"
    | Item.``VTOL Module`` -> "VTOL Module"
    | Item.``Imp_ Flight Unit`` -> "Imp. Flight Unit"
    | Item.``Cesium-ion Thruster`` -> "Cesium-ion Thruster"
    | Item.``Surge Thruster`` -> "Surge Thruster"
    | Item.``Imp_ VTOL Module`` -> "Imp. VTOL Module"
    | Item.``Xenon Bombardment Thruster`` -> "Xenon Bombardment Thruster"
    | Item.``Imp_ Cesium-ion Thruster`` -> "Imp. Cesium-ion Thruster"
    | Item.``Cld_ VTOL Module`` -> "Cld. VTOL Module"
    | Item.``Mak_ Flight Unit`` -> "Mak. Flight Unit"
    | Item.``Nuclear Pulse Thruster`` -> "Nuclear Pulse Thruster"
    | Item.``Imp_ Surge Thruster`` -> "Imp. Surge Thruster"
    | Item.``Mni_ Nuclear Pulse Thruster`` -> "Mni. Nuclear Pulse Thruster"
    | Item.``Cld_ Cesium-ion Thruster`` -> "Cld. Cesium-ion Thruster"
    | Item.``Biomechanical Wings`` -> "Biomechanical Wings"
    | Item.``Field Propulsion Drive`` -> "Field Propulsion Drive"
    | Item.``Cld_ Nuclear Pulse Thruster`` -> "Cld. Nuclear Pulse Thruster"
    | Item.``Exp_ Cesium-ion Thruster`` -> "Exp. Cesium-ion Thruster"
    | Item.``Nuclear Pulse Array`` -> "Nuclear Pulse Array"
    | Item.``Mak_ Microthruster`` -> "Mak. Microthruster"
    | Item.``Impulse Thruster`` -> "Impulse Thruster"
    | Item.``Adv_ Surge Thruster`` -> "Adv. Surge Thruster"
    | Item.``Cld_ Field Propulsion Drive`` -> "Cld. Field Propulsion Drive"
    | Item.``Field Propulsion Array`` -> "Field Propulsion Array"
    | Item.``Diametric Drive`` -> "Diametric Drive"
    | Item.``Flying Fortress v7`` -> "Flying Fortress v7"
    | Item.``T-thruster`` -> "T-thruster"
    | Item.``Integrated Tracker Drive`` -> "Integrated Tracker Drive"
    | Item.``Etherial Propulsion`` -> "Etherial Propulsion"
    | Item.``Q-thruster`` -> "Q-thruster"
    | Item.``Electron Diverter`` -> "Electron Diverter"
    | Item.``Imp_ Diametric Drive`` -> "Imp. Diametric Drive"
    | Item.``Cld_ Impulse Thruster`` -> "Cld. Impulse Thruster"
    | Item.``Impulse Thruster Array`` -> "Impulse Thruster Array"
    | Item.``Flightbrick`` -> "Flightbrick"
    | Item.``Imp_ Q-thruster`` -> "Imp. Q-thruster"
    | Item.``Cld_ Q-thruster`` -> "Cld. Q-thruster"
    | Item.``Exp_ Q-thruster`` -> "Exp. Q-thruster"
    | Item.``Scrap Engine`` -> "Scrap Engine"
    | Item.``Arm_ Scrap Engine`` -> "Arm. Scrap Engine"
    | Item.``Scrap Suit`` -> "Scrap Suit"
    | Item.``Matter Focus`` -> "Matter Focus"
    | Item.``Desublimator`` -> "Desublimator"
    | Item.``Power Amplifier`` -> "Power Amplifier"
    | Item.``Adv_ Power Amplifier`` -> "Adv. Power Amplifier"
    | Item.``Exp_ Power Amplifier`` -> "Exp. Power Amplifier"
    | Item.``Thermal Generator`` -> "Thermal Generator"
    | Item.``Imp_ Thermal Generator`` -> "Imp. Thermal Generator"
    | Item.``Adv_ Thermal Generator`` -> "Adv. Thermal Generator"
    | Item.``Exp_ Thermal Generator`` -> "Exp. Thermal Generator"
    | Item.``Cryofiber Web`` -> "Cryofiber Web"
    | Item.``Imp_ Cryofiber Web`` -> "Imp. Cryofiber Web"
    | Item.``Adv_ Cryofiber Web`` -> "Adv. Cryofiber Web"
    | Item.``Exp_ Cryofiber Web`` -> "Exp. Cryofiber Web"
    | Item.``Heat Sink`` -> "Heat Sink"
    | Item.``Imp_ Heat Sink`` -> "Imp. Heat Sink"
    | Item.``Adv_ Heat Sink`` -> "Adv. Heat Sink"
    | Item.``Exp_ Heat Sink`` -> "Exp. Heat Sink"
    | Item.``Cooling System`` -> "Cooling System"
    | Item.``Imp_ Cooling System`` -> "Imp. Cooling System"
    | Item.``Adv_ Cooling System`` -> "Adv. Cooling System"
    | Item.``Exp_ Cooling System`` -> "Exp. Cooling System"
    | Item.``Mak_ Coolant Network`` -> "Mak. Coolant Network"
    | Item.``Coolant Network`` -> "Coolant Network"
    | Item.``Asb_ Nanovents`` -> "Asb. Nanovents"
    | Item.``2N-1CE's Frost Array`` -> "2N-1CE's Frost Array"
    | Item.``Disposable Heat Sink`` -> "Disposable Heat Sink"
    | Item.``Coolant Injector`` -> "Coolant Injector"
    | Item.``Imp_ Coolant Injector`` -> "Imp. Coolant Injector"
    | Item.``Adv_ Coolant Injector`` -> "Adv. Coolant Injector"
    | Item.``Exp_ Coolant Injector`` -> "Exp. Coolant Injector"
    | Item.``Mak_ Microdissipator Network`` -> "Mak. Microdissipator Network"
    | Item.``Sml_ Storage Unit`` -> "Sml. Storage Unit"
    | Item.``Med_ Storage Unit`` -> "Med. Storage Unit"
    | Item.``Lrg_ Storage Unit`` -> "Lrg. Storage Unit"
    | Item.``Hcp_ Storage Unit`` -> "Hcp. Storage Unit"
    | Item.``Huge Storage Unit`` -> "Huge Storage Unit"
    | Item.``Cargo Storage Unit`` -> "Cargo Storage Unit"
    | Item.``Humpback`` -> "Humpback"
    | Item.``Vmp_ Humpback`` -> "Vmp. Humpback"
    | Item.``Lightpack 2_0`` -> "Lightpack 2.0"
    | Item.``Sml_ Battery`` -> "Sml. Battery"
    | Item.``Med_ Battery`` -> "Med. Battery"
    | Item.``Lrg_ Battery`` -> "Lrg. Battery"
    | Item.``Hcp_ Battery`` -> "Hcp. Battery"
    | Item.``Com_ Battery`` -> "Com. Battery"
    | Item.``Energy Well`` -> "Energy Well"
    | Item.``Imp_ Energy Well`` -> "Imp. Energy Well"
    | Item.``Adv_ Energy Well`` -> "Adv. Energy Well"
    | Item.``Exp_ Energy Well`` -> "Exp. Energy Well"
    | Item.``Zio_ Biocell`` -> "Zio. Biocell"
    | Item.``Asb_ Biocell Array`` -> "Asb. Biocell Array"
    | Item.``Zio_ Biocell Array`` -> "Zio. Biocell Array"
    | Item.``Superbattery`` -> "Superbattery"
    | Item.``Sml_ Matter Pod`` -> "Sml. Matter Pod"
    | Item.``Med_ Matter Pod`` -> "Med. Matter Pod"
    | Item.``Lrg_ Matter Pod`` -> "Lrg. Matter Pod"
    | Item.``Hcp_ Matter Pod`` -> "Hcp. Matter Pod"
    | Item.``Com_ Matter Pod`` -> "Com. Matter Pod"
    | Item.``Matter Compressor`` -> "Matter Compressor"
    | Item.``Imp_ Matter Compressor`` -> "Imp. Matter Compressor"
    | Item.``Adv_ Matter Compressor`` -> "Adv. Matter Compressor"
    | Item.``Exp_ Matter Compressor`` -> "Exp. Matter Compressor"
    | Item.``YI-UF0's Bottomless Matter Pit`` -> "YI-UF0's Bottomless Matter Pit"
    | Item.``Weight Redist_ System`` -> "Weight Redist. System"
    | Item.``Adv_ Weight Redist_ System`` -> "Adv. Weight Redist. System"
    | Item.``Gravity Neutralizer`` -> "Gravity Neutralizer"
    | Item.``Adv_ Gravity Neutralizer`` -> "Adv. Gravity Neutralizer"
    | Item.``Quantum Shading Machine`` -> "Quantum Shading Machine"
    | Item.``Asb_ Suspension Frame`` -> "Asb. Suspension Frame"
    | Item.``Adv_ Quantum Shading Machine`` -> "Adv. Quantum Shading Machine"
    | Item.``Rocket Booster`` -> "Rocket Booster"
    | Item.``Asb_ Metafiber Network`` -> "Asb. Metafiber Network"
    | Item.``Zio_ Metafield Generator`` -> "Zio. Metafield Generator"
    | Item.``ST Field Compressor`` -> "ST Field Compressor"
    | Item.``Siege Articulator`` -> "Siege Articulator"
    | Item.``Structural Scanner`` -> "Structural Scanner"
    | Item.``Deep Structural Scanner`` -> "Deep Structural Scanner"
    | Item.``Trap Scanner`` -> "Trap Scanner"
    | Item.``Imp_ Trap Scanner`` -> "Imp. Trap Scanner"
    | Item.``Mak_ Trap Scanner`` -> "Mak. Trap Scanner"
    | Item.``Adv_ Trap Scanner`` -> "Adv. Trap Scanner"
    | Item.``Machine Analyzer`` -> "Machine Analyzer"
    | Item.``Triangulator`` -> "Triangulator"
    | Item.``Visual Processing Unit`` -> "Visual Processing Unit"
    | Item.``Sub_ Optics`` -> "Sub. Optics"
    | Item.``Adv_ Visual Processing Unit`` -> "Adv. Visual Processing Unit"
    | Item.``Enh_ Optical Array`` -> "Enh. Optical Array"
    | Item.``Exp_ Optical Array`` -> "Exp. Optical Array"
    | Item.``Spectral Analyzer`` -> "Spectral Analyzer"
    | Item.``Sensor Array`` -> "Sensor Array"
    | Item.``Imp_ Sensor Array`` -> "Imp. Sensor Array"
    | Item.``Adv_ Sensor Array`` -> "Adv. Sensor Array"
    | Item.``Lrn_ Sensor Array`` -> "Lrn. Sensor Array"
    | Item.``Mak_ Sensor Array`` -> "Mak. Sensor Array"
    | Item.``Exp_ Sensor Array`` -> "Exp. Sensor Array"
    | Item.``Signal Interpreter`` -> "Signal Interpreter"
    | Item.``Imp_ Signal Interpreter`` -> "Imp. Signal Interpreter"
    | Item.``Adv_ Signal Interpreter`` -> "Adv. Signal Interpreter"
    | Item.``Exp_ Signal Interpreter`` -> "Exp. Signal Interpreter"
    | Item.``Active Sensor Suite`` -> "Active Sensor Suite"
    | Item.``Terrain Scanner`` -> "Terrain Scanner"
    | Item.``Imp_ Terrain Scanner`` -> "Imp. Terrain Scanner"
    | Item.``Adv_ Terrain Scanner`` -> "Adv. Terrain Scanner"
    | Item.``Mak_ Terrain Scanner`` -> "Mak. Terrain Scanner"
    | Item.``Lrn_ Terrain Scanner`` -> "Lrn. Terrain Scanner"
    | Item.``Exp_ Terrain Scanner`` -> "Exp. Terrain Scanner"
    | Item.``Surveybot 24 Scanner`` -> "Surveybot 24 Scanner"
    | Item.``Terrain Scan Processor`` -> "Terrain Scan Processor"
    | Item.``Imp_ Terrain Scan Processor`` -> "Imp. Terrain Scan Processor"
    | Item.``Mak_ Terrain Scan Processor`` -> "Mak. Terrain Scan Processor"
    | Item.``Adv_ Terrain Scan Processor`` -> "Adv. Terrain Scan Processor"
    | Item.``Exp_ Terrain Scan Processor`` -> "Exp. Terrain Scan Processor"
    | Item.``Surveybot 17 Chip`` -> "Surveybot 17 Chip"
    | Item.``Surveybot 24 Chip`` -> "Surveybot 24 Chip"
    | Item.``Seismic Detector`` -> "Seismic Detector"
    | Item.``Transport Network Coupler`` -> "Transport Network Coupler"
    | Item.``Modified TNC`` -> "Modified TNC"
    | Item.``Encrypted Comm Array`` -> "Encrypted Comm Array"
    | Item.``0b10 Decoder Chip _Generic_`` -> "0b10 Decoder Chip [Generic]"
    | Item.``0b10 Decoder Chip _Looter_`` -> "0b10 Decoder Chip [Looter]"
    | Item.``0b10 Decoder Chip _Scout_`` -> "0b10 Decoder Chip [Scout]"
    | Item.``0b10 Decoder Chip _Skirmisher_`` -> "0b10 Decoder Chip [Skirmisher]"
    | Item.``0b10 Alert Chip`` -> "0b10 Alert Chip"
    | Item.``Salvage Targeting Computer`` -> "Salvage Targeting Computer"
    | Item.``Imp_ Salvage Targeting Computer`` -> "Imp. Salvage Targeting Computer"
    | Item.``Mak_ Salvage Targeting Computer`` -> "Mak. Salvage Targeting Computer"
    | Item.``Adv_ Salvage Targeting Computer`` -> "Adv. Salvage Targeting Computer"
    | Item.``Asb_ Combat Suite`` -> "Asb. Combat Suite"
    | Item.``Targeting Computer`` -> "Targeting Computer"
    | Item.``Imp_ Targeting Computer`` -> "Imp. Targeting Computer"
    | Item.``Mak_ Targeting Computer`` -> "Mak. Targeting Computer"
    | Item.``Adv_ Targeting Computer`` -> "Adv. Targeting Computer"
    | Item.``Exp_ Targeting Computer`` -> "Exp. Targeting Computer"
    | Item.``Multitargeting Array`` -> "Multitargeting Array"
    | Item.``Tactical Coordination Suite`` -> "Tactical Coordination Suite"
    | Item.``Melee Analysis Suite`` -> "Melee Analysis Suite"
    | Item.``Imp_ Melee Analysis Suite`` -> "Imp. Melee Analysis Suite"
    | Item.``Adv_ Melee Analysis Suite`` -> "Adv. Melee Analysis Suite"
    | Item.``Exp_ Melee Analysis Suite`` -> "Exp. Melee Analysis Suite"
    | Item.``Launcher Guidance Computer`` -> "Launcher Guidance Computer"
    | Item.``Imp_ Launcher Guidance Computer`` -> "Imp. Launcher Guidance Computer"
    | Item.``Adv_ Launcher Guidance Computer`` -> "Adv. Launcher Guidance Computer"
    | Item.``Weapon Mount`` -> "Weapon Mount"
    | Item.``Target Analyzer`` -> "Target Analyzer"
    | Item.``Imp_ Target Analyzer`` -> "Imp. Target Analyzer"
    | Item.``Adv_ Target Analyzer`` -> "Adv. Target Analyzer"
    | Item.``Exp_ Target Analyzer`` -> "Exp. Target Analyzer"
    | Item.``Core Analyzer`` -> "Core Analyzer"
    | Item.``Exp_ Core Analyzer`` -> "Exp. Core Analyzer"
    | Item.``Armor Integrity Analyzer`` -> "Armor Integrity Analyzer"
    | Item.``Imp_ Armor Integrity Analyzer`` -> "Imp. Armor Integrity Analyzer"
    | Item.``Exp_ Armor Integrity Analyzer`` -> "Exp. Armor Integrity Analyzer"
    | Item.``Recoil Stabilizer`` -> "Recoil Stabilizer"
    | Item.``Recoil Nullifier`` -> "Recoil Nullifier"
    | Item.``Matter Filter`` -> "Matter Filter"
    | Item.``Prc_ Matter Filter`` -> "Prc. Matter Filter"
    | Item.``Energy Filter`` -> "Energy Filter"
    | Item.``Prc_ Energy Filter`` -> "Prc. Energy Filter"
    | Item.``Particle Charger`` -> "Particle Charger"
    | Item.``Imp_ Particle Charger`` -> "Imp. Particle Charger"
    | Item.``Adv_ Particle Charger`` -> "Adv. Particle Charger"
    | Item.``Particle Accelerator`` -> "Particle Accelerator"
    | Item.``Imp_ Particle Accelerator`` -> "Imp. Particle Accelerator"
    | Item.``Adv_ Particle Accelerator`` -> "Adv. Particle Accelerator"
    | Item.``Kinecellerator`` -> "Kinecellerator"
    | Item.``Imp_ Kinecellerator`` -> "Imp. Kinecellerator"
    | Item.``Adv_ Kinecellerator`` -> "Adv. Kinecellerator"
    | Item.``Expert System`` -> "Expert System"
    | Item.``Heavy Servo Lattice`` -> "Heavy Servo Lattice"
    | Item.``VL-GR5's Timing Chip`` -> "VL-GR5's Timing Chip"
    | Item.``Launcher Loader`` -> "Launcher Loader"
    | Item.``Quantum Capacitor`` -> "Quantum Capacitor"
    | Item.``Weapon Cycler`` -> "Weapon Cycler"
    | Item.``Imp_ Weapon Cycler`` -> "Imp. Weapon Cycler"
    | Item.``Adv_ Weapon Cycler`` -> "Adv. Weapon Cycler"
    | Item.``Exp_ Weapon Cycler`` -> "Exp. Weapon Cycler"
    | Item.``Microactuators`` -> "Microactuators"
    | Item.``Nanoactuators`` -> "Nanoactuators"
    | Item.``Femtoactuators`` -> "Femtoactuators"
    | Item.``Actuator Array`` -> "Actuator Array"
    | Item.``Imp_ Actuator Array`` -> "Imp. Actuator Array"
    | Item.``Adv_ Actuator Array`` -> "Adv. Actuator Array"
    | Item.``Exp_ Actuator Array`` -> "Exp. Actuator Array"
    | Item.``Force Booster`` -> "Force Booster"
    | Item.``Imp_ Force Booster`` -> "Imp. Force Booster"
    | Item.``Adv_ Force Booster`` -> "Adv. Force Booster"
    | Item.``Stasis Canceller`` -> "Stasis Canceller"
    | Item.``Transmission Jammer`` -> "Transmission Jammer"
    | Item.``Mak_ Transmission Jammer`` -> "Mak. Transmission Jammer"
    | Item.``Imp_ Transmission Jammer`` -> "Imp. Transmission Jammer"
    | Item.``Adv_ Transmission Jammer`` -> "Adv. Transmission Jammer"
    | Item.``Exp_ Transmission Jammer`` -> "Exp. Transmission Jammer"
    | Item.``ECM Suite`` -> "ECM Suite"
    | Item.``Mak_ ECM Suite`` -> "Mak. ECM Suite"
    | Item.``Adv_ ECM Suite`` -> "Adv. ECM Suite"
    | Item.``Exp_ ECM Suite`` -> "Exp. ECM Suite"
    | Item.``Active Sensor Spoofer`` -> "Active Sensor Spoofer"
    | Item.``Reaction Control System`` -> "Reaction Control System"
    | Item.``Imp_ Reaction Control System`` -> "Imp. Reaction Control System"
    | Item.``Adv_ Reaction Control System`` -> "Adv. Reaction Control System"
    | Item.``Exp_ Reaction Control System`` -> "Exp. Reaction Control System"
    | Item.``Phase Shifter`` -> "Phase Shifter"
    | Item.``Imp_ Phase Shifter`` -> "Imp. Phase Shifter"
    | Item.``Adv_ Phase Shifter`` -> "Adv. Phase Shifter"
    | Item.``Exp_ Phase Shifter`` -> "Exp. Phase Shifter"
    | Item.``Cloaking Device`` -> "Cloaking Device"
    | Item.``Mak_ Cloaking Device`` -> "Mak. Cloaking Device"
    | Item.``Imp_ Cloaking Device`` -> "Imp. Cloaking Device"
    | Item.``Adv_ Cloaking Device`` -> "Adv. Cloaking Device"
    | Item.``Exp_ Cloaking Device`` -> "Exp. Cloaking Device"
    | Item.``Cloak of Protection`` -> "Cloak of Protection"
    | Item.``5H-AD0's Cloak`` -> "5H-AD0's Cloak"
    | Item.``ID Mask`` -> "ID Mask"
    | Item.``Core Shielding`` -> "Core Shielding"
    | Item.``Imp_ Core Shielding`` -> "Imp. Core Shielding"
    | Item.``Mak_ Core Shielding`` -> "Mak. Core Shielding"
    | Item.``Exp_ Core Shielding`` -> "Exp. Core Shielding"
    | Item.``Power Shielding`` -> "Power Shielding"
    | Item.``Imp_ Power Shielding`` -> "Imp. Power Shielding"
    | Item.``Mak_ Power Shielding`` -> "Mak. Power Shielding"
    | Item.``Exp_ Power Shielding`` -> "Exp. Power Shielding"
    | Item.``Propulsion Shielding`` -> "Propulsion Shielding"
    | Item.``Imp_ Propulsion Shielding`` -> "Imp. Propulsion Shielding"
    | Item.``Mak_ Propulsion Shielding`` -> "Mak. Propulsion Shielding"
    | Item.``Exp_ Propulsion Shielding`` -> "Exp. Propulsion Shielding"
    | Item.``Utility Shielding`` -> "Utility Shielding"
    | Item.``Imp_ Utility Shielding`` -> "Imp. Utility Shielding"
    | Item.``Mak_ Utility Shielding`` -> "Mak. Utility Shielding"
    | Item.``Exp_ Utility Shielding`` -> "Exp. Utility Shielding"
    | Item.``Weapon Shielding`` -> "Weapon Shielding"
    | Item.``Imp_ Weapon Shielding`` -> "Imp. Weapon Shielding"
    | Item.``Mak_ Weapon Shielding`` -> "Mak. Weapon Shielding"
    | Item.``Exp_ Weapon Shielding`` -> "Exp. Weapon Shielding"
    | Item.``Zio_ Weapon Casing`` -> "Zio. Weapon Casing"
    | Item.``Backup Plating I`` -> "Backup Plating I"
    | Item.``Backup Plating III`` -> "Backup Plating III"
    | Item.``Backup Plating VII`` -> "Backup Plating VII"
    | Item.``Lgt_ Armor Plating`` -> "Lgt. Armor Plating"
    | Item.``Med_ Armor Plating`` -> "Med. Armor Plating"
    | Item.``Hvy_ Armor Plating`` -> "Hvy. Armor Plating"
    | Item.``Zio_ Light Carapace`` -> "Zio. Light Carapace"
    | Item.``Zio_ Heavy Carapace`` -> "Zio. Heavy Carapace"
    | Item.``Hrd_ Light Armor Plating`` -> "Hrd. Light Armor Plating"
    | Item.``Hrd_ Medium Armor Plating`` -> "Hrd. Medium Armor Plating"
    | Item.``Hrd_ Heavy Armor Plating`` -> "Hrd. Heavy Armor Plating"
    | Item.``Imp_ Light Armor Plating`` -> "Imp. Light Armor Plating"
    | Item.``Imp_ Medium Armor Plating`` -> "Imp. Medium Armor Plating"
    | Item.``Imp_ Heavy Armor Plating`` -> "Imp. Heavy Armor Plating"
    | Item.``Mak_ Light Armor Plating`` -> "Mak. Light Armor Plating"
    | Item.``Mak_ Medium Armor Plating`` -> "Mak. Medium Armor Plating"
    | Item.``Mak_ Heavy Armor Plating`` -> "Mak. Heavy Armor Plating"
    | Item.``Lyr_ Light Armor Plating`` -> "Lyr. Light Armor Plating"
    | Item.``Lyr_ Medium Armor Plating`` -> "Lyr. Medium Armor Plating"
    | Item.``Lyr_ Heavy Armor Plating`` -> "Lyr. Heavy Armor Plating"
    | Item.``Gun Armor`` -> "Gun Armor"
    | Item.``Centrium Light Armor Plating`` -> "Centrium Light Armor Plating"
    | Item.``Centrium Medium Armor Plating`` -> "Centrium Medium Armor Plating"
    | Item.``Centrium Heavy Armor Plating`` -> "Centrium Heavy Armor Plating"
    | Item.``Centrium Linked Plating`` -> "Centrium Linked Plating"
    | Item.``Reactive Plating`` -> "Reactive Plating"
    | Item.``Med_ Reactive Plating`` -> "Med. Reactive Plating"
    | Item.``Mak_ Kinetic Plating`` -> "Mak. Kinetic Plating"
    | Item.``Hvy_ Reactive Plating`` -> "Hvy. Reactive Plating"
    | Item.``Superdense Plating`` -> "Superdense Plating"
    | Item.``Reflective Plating`` -> "Reflective Plating"
    | Item.``Med_ Reflective Plating`` -> "Med. Reflective Plating"
    | Item.``Mak_ Thermal Plating`` -> "Mak. Thermal Plating"
    | Item.``Hvy_ Reflective Plating`` -> "Hvy. Reflective Plating"
    | Item.``8R-AWN's Armor_TH`` -> "8R-AWN's Armor/TH"
    | Item.``8R-AWN's Armor_EX`` -> "8R-AWN's Armor/EX"
    | Item.``Insulated Plating`` -> "Insulated Plating"
    | Item.``Med_ Insulated Plating`` -> "Med. Insulated Plating"
    | Item.``Hvy_ Insulated Plating`` -> "Hvy. Insulated Plating"
    | Item.``Damper Plating`` -> "Damper Plating"
    | Item.``Zio_ Shade Carapace`` -> "Zio. Shade Carapace"
    | Item.``Zio_ Shade Armor`` -> "Zio. Shade Armor"
    | Item.``Asb_ Alloy Armor`` -> "Asb. Alloy Armor"
    | Item.``Mak_ Ablative Armor`` -> "Mak. Ablative Armor"
    | Item.``Active Cooling Armor`` -> "Active Cooling Armor"
    | Item.``Scrap Shield`` -> "Scrap Shield"
    | Item.``Enh_ Scrap Shield`` -> "Enh. Scrap Shield"
    | Item.``Powered Armor`` -> "Powered Armor"
    | Item.``Imp_ Powered Armor`` -> "Imp. Powered Armor"
    | Item.``Adv_ Powered Armor`` -> "Adv. Powered Armor"
    | Item.``Exp_ Powered Armor`` -> "Exp. Powered Armor"
    | Item.``1C-UTU's Buckler`` -> "1C-UTU's Buckler"
    | Item.``Tower Shield`` -> "Tower Shield"
    | Item.``Lgt_ Regenerative Plating`` -> "Lgt. Regenerative Plating"
    | Item.``Med_ Regenerative Plating`` -> "Med. Regenerative Plating"
    | Item.``Hvy_ Regenerative Plating`` -> "Hvy. Regenerative Plating"
    | Item.``SHELL Armor`` -> "SHELL Armor"
    | Item.``Phase Armor`` -> "Phase Armor"
    | Item.``Vmp_ Brace Plating`` -> "Vmp. Brace Plating"
    | Item.``Graphene Brace`` -> "Graphene Brace"
    | Item.``Focal Shield`` -> "Focal Shield"
    | Item.``Imp_ Focal Shield`` -> "Imp. Focal Shield"
    | Item.``Adv_ Focal Shield`` -> "Adv. Focal Shield"
    | Item.``Exp_ Focal Shield`` -> "Exp. Focal Shield"
    | Item.``Thermal Shield`` -> "Thermal Shield"
    | Item.``Imp_ Thermal Shield`` -> "Imp. Thermal Shield"
    | Item.``Adv_ Thermal Shield`` -> "Adv. Thermal Shield"
    | Item.``Exp_ Thermal Shield`` -> "Exp. Thermal Shield"
    | Item.``Thermal Barrier`` -> "Thermal Barrier"
    | Item.``Beam Splitter`` -> "Beam Splitter"
    | Item.``Thermal Defense Suite`` -> "Thermal Defense Suite"
    | Item.``Imp_ Thermal Defense Suite`` -> "Imp. Thermal Defense Suite"
    | Item.``Adv_ Thermal Defense Suite`` -> "Adv. Thermal Defense Suite"
    | Item.``Exp_ Thermal Defense Suite`` -> "Exp. Thermal Defense Suite"
    | Item.``Shock Absorption System`` -> "Shock Absorption System"
    | Item.``Imp_ Shock Absorption System`` -> "Imp. Shock Absorption System"
    | Item.``Exp_ Shock Absorption System`` -> "Exp. Shock Absorption System"
    | Item.``EM Disruption Field`` -> "EM Disruption Field"
    | Item.``Adv_ EM Disruption Field`` -> "Adv. EM Disruption Field"
    | Item.``Exp_ EM Disruption Field`` -> "Exp. EM Disruption Field"
    | Item.``ME-RLN's Chromatic Screen`` -> "ME-RLN's Chromatic Screen"
    | Item.``Hardlight Generator`` -> "Hardlight Generator"
    | Item.``Imp_ Hardlight Generator`` -> "Imp. Hardlight Generator"
    | Item.``Adv_ Hardlight Generator`` -> "Adv. Hardlight Generator"
    | Item.``Exp_ Hardlight Generator`` -> "Exp. Hardlight Generator"
    | Item.``Shield Generator`` -> "Shield Generator"
    | Item.``Imp_ Shield Generator`` -> "Imp. Shield Generator"
    | Item.``Adv_ Shield Generator`` -> "Adv. Shield Generator"
    | Item.``Exp_ Shield Generator`` -> "Exp. Shield Generator"
    | Item.``Force Field`` -> "Force Field"
    | Item.``Imp_ Force Field`` -> "Imp. Force Field"
    | Item.``Adv_ Force Field`` -> "Adv. Force Field"
    | Item.``Exp_ Force Field`` -> "Exp. Force Field"
    | Item.``7V-RTL's Ultimate Field`` -> "7V-RTL's Ultimate Field"
    | Item.``Vortex Field Projector`` -> "Vortex Field Projector"
    | Item.``Remote Shield`` -> "Remote Shield"
    | Item.``Imp_ Remote Shield`` -> "Imp. Remote Shield"
    | Item.``Adv_ Remote Shield`` -> "Adv. Remote Shield"
    | Item.``Remote Force Field`` -> "Remote Force Field"
    | Item.``Imp_ Remote Force Field`` -> "Imp. Remote Force Field"
    | Item.``Energy Mantle`` -> "Energy Mantle"
    | Item.``Imp_ Energy Mantle`` -> "Imp. Energy Mantle"
    | Item.``AEGIS Remote Shield`` -> "AEGIS Remote Shield"
    | Item.``Phase Redirector`` -> "Phase Redirector"
    | Item.``Field Manipulator`` -> "Field Manipulator"
    | Item.``Energy Deflector`` -> "Energy Deflector"
    | Item.``Point Defense System`` -> "Point Defense System"
    | Item.``Point Defense Array`` -> "Point Defense Array"
    | Item.``Antimissile System`` -> "Antimissile System"
    | Item.``EX Chip 1`` -> "EX Chip 1"
    | Item.``Hacking Suite`` -> "Hacking Suite"
    | Item.``Mak_ Hacking Suite`` -> "Mak. Hacking Suite"
    | Item.``Imp_ Hacking Suite`` -> "Imp. Hacking Suite"
    | Item.``Adv_ Hacking Suite`` -> "Adv. Hacking Suite"
    | Item.``Exp_ Hacking Suite`` -> "Exp. Hacking Suite"
    | Item.``System Mapper`` -> "System Mapper"
    | Item.``Deep Network Scanner`` -> "Deep Network Scanner"
    | Item.``Architect God Chip A`` -> "Architect God Chip A"
    | Item.``EX Chip 2`` -> "EX Chip 2"
    | Item.``System Shield`` -> "System Shield"
    | Item.``Mak_ System Shield`` -> "Mak. System Shield"
    | Item.``Imp_ System Shield`` -> "Imp. System Shield"
    | Item.``Adv_ System Shield`` -> "Adv. System Shield"
    | Item.``Exp_ System Shield`` -> "Exp. System Shield"
    | Item.``Ghost Barrier`` -> "Ghost Barrier"
    | Item.``Quantum Router`` -> "Quantum Router"
    | Item.``Architect God Chip D`` -> "Architect God Chip D"
    | Item.``Authchip _R_NC_`` -> "Authchip [R/NC]"
    | Item.``Authchip _R_Combat_`` -> "Authchip [R/Combat]"
    | Item.``Authchip _Power_`` -> "Authchip [Power]"
    | Item.``Authchip _Propulsion_`` -> "Authchip [Propulsion]"
    | Item.``Authchip _Device_`` -> "Authchip [Device]"
    | Item.``Authchip _Storage_`` -> "Authchip [Storage]"
    | Item.``Authchip _Processor_`` -> "Authchip [Processor]"
    | Item.``Authchip _Armor_`` -> "Authchip [Armor]"
    | Item.``Authchip _Weapon_`` -> "Authchip [Weapon]"
    | Item.``Relay Coupler _NC_`` -> "Relay Coupler [NC]"
    | Item.``Relay Coupler _C_`` -> "Relay Coupler [C]"
    | Item.``Relay Coupler _Swarmer_`` -> "Relay Coupler [Swarmer]"
    | Item.``Relay Coupler _Cutter_`` -> "Relay Coupler [Cutter]"
    | Item.``Relay Coupler _Grunt_`` -> "Relay Coupler [Grunt]"
    | Item.``Relay Coupler _Brawler_`` -> "Relay Coupler [Brawler]"
    | Item.``Relay Coupler _Duelist_`` -> "Relay Coupler [Duelist]"
    | Item.``Relay Coupler _Sentry_`` -> "Relay Coupler [Sentry]"
    | Item.``Relay Coupler _Demolisher_`` -> "Relay Coupler [Demolisher]"
    | Item.``Relay Coupler _Specialist_`` -> "Relay Coupler [Specialist]"
    | Item.``Relay Coupler _Hunter_`` -> "Relay Coupler [Hunter]"
    | Item.``Relay Coupler _Heavy_`` -> "Relay Coupler [Heavy]"
    | Item.``Relay Coupler _Behemoth_`` -> "Relay Coupler [Behemoth]"
    | Item.``Relay Coupler _Programmer_`` -> "Relay Coupler [Programmer]"
    | Item.``Relay Coupler _Proto_`` -> "Relay Coupler [Proto]"
    | Item.``Skeleton Box`` -> "Skeleton Box"
    | Item.``01-MTF's Autohacker`` -> "01-MTF's Autohacker"
    | Item.``Component Analysis Suite`` -> "Component Analysis Suite"
    | Item.``Imp_ Component Analysis Suite`` -> "Imp. Component Analysis Suite"
    | Item.``Adv_ Component Analysis Suite`` -> "Adv. Component Analysis Suite"
    | Item.``A0-MCA's Component Scanner`` -> "A0-MCA's Component Scanner"
    | Item.``Tech Extrapolator`` -> "Tech Extrapolator"
    | Item.``Dynamic Insulation System`` -> "Dynamic Insulation System"
    | Item.``Imp_ Dynamic Insulation System`` -> "Imp. Dynamic Insulation System"
    | Item.``Adv_ Dynamic Insulation System`` -> "Adv. Dynamic Insulation System"
    | Item.``System Guard`` -> "System Guard"
    | Item.``Imp_ System Guard`` -> "Imp. System Guard"
    | Item.``Exp_ System Guard`` -> "Exp. System Guard"
    | Item.``Corruption Screen`` -> "Corruption Screen"
    | Item.``Imp_ Corruption Screen`` -> "Imp. Corruption Screen"
    | Item.``Adv_ Corruption Screen`` -> "Adv. Corruption Screen"
    | Item.``System Restoration Module`` -> "System Restoration Module"
    | Item.``Mak_ System Restoration Module`` -> "Mak. System Restoration Module"
    | Item.``Imp_ System Restoration Module`` -> "Imp. System Restoration Module"
    | Item.``Adv_ System Restoration Module`` -> "Adv. System Restoration Module"
    | Item.``System Purifier`` -> "System Purifier"
    | Item.``Exp_ System Purifier`` -> "Exp. System Purifier"
    | Item.``Tractor Beam`` -> "Tractor Beam"
    | Item.``Hpw_ Tractor Beam`` -> "Hpw. Tractor Beam"
    | Item.``Lrn_ Tractor Beam`` -> "Lrn. Tractor Beam"
    | Item.``Mobile Refinery Mk_ CCLXVII`` -> "Mobile Refinery Mk. CCLXVII"
    | Item.``Trap Extractor`` -> "Trap Extractor"
    | Item.``Imp_ Trap Extractor`` -> "Imp. Trap Extractor"
    | Item.``Adv_ Trap Extractor`` -> "Adv. Trap Extractor"
    | Item.``Trap Reconfigurator`` -> "Trap Reconfigurator"
    | Item.``Recalibrator`` -> "Recalibrator"
    | Item.``Imp_ Recalibrator`` -> "Imp. Recalibrator"
    | Item.``Adv_ Recalibrator`` -> "Adv. Recalibrator"
    | Item.``Exp_ Recalibrator`` -> "Exp. Recalibrator"
    | Item.``Field Recycling Unit`` -> "Field Recycling Unit"
    | Item.``Imp_ Field Recycling Unit`` -> "Imp. Field Recycling Unit"
    | Item.``Adv_ Field Recycling Unit`` -> "Adv. Field Recycling Unit"
    | Item.``Exp_ Field Recycling Unit`` -> "Exp. Field Recycling Unit"
    | Item.``Drone Bay`` -> "Drone Bay"
    | Item.``Z-Drone Bay`` -> "Z-Drone Bay"
    | Item.``Mni_ Drone Bay`` -> "Mni. Drone Bay"
    | Item.``Mapping Drone Bay`` -> "Mapping Drone Bay"
    | Item.``Adv_ Drone Bay`` -> "Adv. Drone Bay"
    | Item.``Bomb Drone Bay`` -> "Bomb Drone Bay"
    | Item.``Thief Drone Bay`` -> "Thief Drone Bay"
    | Item.``Decoy Drone Bay`` -> "Decoy Drone Bay"
    | Item.``Splice Drone Bay`` -> "Splice Drone Bay"
    | Item.``Combat Drone Bay`` -> "Combat Drone Bay"
    | Item.``Assault Drone Bay`` -> "Assault Drone Bay"
    | Item.``Stealth Drone Bay`` -> "Stealth Drone Bay"
    | Item.``Swarm Drone Bay`` -> "Swarm Drone Bay"
    | Item.``Supersonic Drone Bay`` -> "Supersonic Drone Bay"
    | Item.``Sensor Drone Bay`` -> "Sensor Drone Bay"
    | Item.``Hacking Drone Bay`` -> "Hacking Drone Bay"
    | Item.``Minesniffer Drone Bay`` -> "Minesniffer Drone Bay"
    | Item.``Army-in-a-Box`` -> "Army-in-a-Box"
    | Item.``Master Drone Bay`` -> "Master Drone Bay"
    | Item.``Wardrone Bay`` -> "Wardrone Bay"
    | Item.``Cobbler Unit`` -> "Cobbler Unit"
    | Item.``Bomb Factory No_ 2`` -> "Bomb Factory No. 2"
    | Item.``Mobile Assembly Unit`` -> "Mobile Assembly Unit"
    | Item.``Heart of Steel`` -> "Heart of Steel"
    | Item.``Scrapoid Pod`` -> "Scrapoid Pod"
    | Item.``GOLEM Unit`` -> "GOLEM Unit"
    | Item.``PSU Rigger`` -> "PSU Rigger"
    | Item.``Machine Rigger`` -> "Machine Rigger"
    | Item.``Phasing AFG`` -> "Phasing AFG"
    | Item.``AS-neutralizer No_ 17b`` -> "AS-neutralizer No. 17b"
    | Item.``V3-11A's Pendant`` -> "V3-11A's Pendant"
    | Item.``Amulet of Y3-NDR`` -> "Amulet of Y3-NDR"
    | Item.``Chronowheel`` -> "Chronowheel"
    | Item.``Power Bank`` -> "Power Bank"
    | Item.``Rainbow Chip`` -> "Rainbow Chip"
    | Item.``VL-GR5's Exoskeleton _Deathgrip_`` -> "VL-GR5's Exoskeleton 'Deathgrip'"
    | Item.``Dimensional Node Initializer`` -> "Dimensional Node Initializer"
    | Item.``Transdimensional Reconstructor`` -> "Transdimensional Reconstructor"
    | Item.``Hpw_ Transdimensional Reconstructor`` -> "Hpw. Transdimensional Reconstructor"
    | Item.``Supercharged TR`` -> "Supercharged TR"
    | Item.``Core Expander`` -> "Core Expander"
    | Item.``Core Regenerator`` -> "Core Regenerator"
    | Item.``Integrity Redistributor`` -> "Integrity Redistributor"
    | Item.``Integrated Dissipator`` -> "Integrated Dissipator"
    | Item.``Supercharged Integrated Dissipator`` -> "Supercharged Integrated Dissipator"
    | Item.``Integrated Thermoelectric Network`` -> "Integrated Thermoelectric Network"
    | Item.``Integrated Reactor`` -> "Integrated Reactor"
    | Item.``Supercharged Integrated Reactor`` -> "Supercharged Integrated Reactor"
    | Item.``Integrated Mediator`` -> "Integrated Mediator"
    | Item.``Core Membrane`` -> "Core Membrane"
    | Item.``Navigation Efficiency Matrix`` -> "Navigation Efficiency Matrix"
    | Item.``Core Reset Matrix`` -> "Core Reset Matrix"
    | Item.``Subatomic Replicator`` -> "Subatomic Replicator"
    | Item.``Terrabomb`` -> "Terrabomb"
    | Item.``Core Physics Calibrator`` -> "Core Physics Calibrator"
    | Item.``Personal Teleporter v0_10`` -> "Personal Teleporter v0.10"
    | Item.``Telecube`` -> "Telecube"
    | Item.``Spacefold Activator`` -> "Spacefold Activator"
    | Item.``Microwarp Drive`` -> "Microwarp Drive"
    | Item.``LC Capacitor`` -> "LC Capacitor"
    | Item.``LRC Armor`` -> "LRC Armor"
    | Item.``LRC Storage`` -> "LRC Storage"
    | Item.``LRC Energy Well`` -> "LRC Energy Well"
    | Item.``LRC Matter Compressor`` -> "LRC Matter Compressor"
    | Item.``LRC Inertial Stabilizer`` -> "LRC Inertial Stabilizer"
    | Item.``LRC Insulator`` -> "LRC Insulator"
    | Item.``EM Pulse Gun`` -> "EM Pulse Gun"
    | Item.``Hvy_ EM Pulse Gun`` -> "Hvy. EM Pulse Gun"
    | Item.``EM Shotgun`` -> "EM Shotgun"
    | Item.``Imp_ EM Shotgun`` -> "Imp. EM Shotgun"
    | Item.``Shock Rifle`` -> "Shock Rifle"
    | Item.``Riot Gun`` -> "Riot Gun"
    | Item.``Hvy_ EM Shotgun`` -> "Hvy. EM Shotgun"
    | Item.``Lightning Gun`` -> "Lightning Gun"
    | Item.``Hvy_ Riot Gun`` -> "Hvy. Riot Gun"
    | Item.``Arc Projector`` -> "Arc Projector"
    | Item.``Prc_ Shock Rifle`` -> "Prc. Shock Rifle"
    | Item.``Hpw_ Shock Rifle`` -> "Hpw. Shock Rifle"
    | Item.``Arc Thrower`` -> "Arc Thrower"
    | Item.``Imp_ Lightning Gun`` -> "Imp. Lightning Gun"
    | Item.``Tesla Rifle`` -> "Tesla Rifle"
    | Item.``Imp_ Arc Projector`` -> "Imp. Arc Projector"
    | Item.``Hvy_ Tesla Rifle`` -> "Hvy. Tesla Rifle"
    | Item.``Hyp_ EM Gauss Rifle`` -> "Hyp. EM Gauss Rifle"
    | Item.``Imp_ Arc Thrower`` -> "Imp. Arc Thrower"
    | Item.``01-MTF's Shockpuncher`` -> "01-MTF's Shockpuncher"
    | Item.``Gamma Rifle`` -> "Gamma Rifle"
    | Item.``Tachyon Dispersion Ray`` -> "Tachyon Dispersion Ray"
    | Item.``Immobilizer`` -> "Immobilizer"
    | Item.``Electrostorm Shotgun`` -> "Electrostorm Shotgun"
    | Item.``Modified EM Gauss Rifle`` -> "Modified EM Gauss Rifle"
    | Item.``AWS_EX-DEC`` -> "AWS/EX-DEC"
    | Item.``Enh_ Gamma Rifle`` -> "Enh. Gamma Rifle"
    | Item.``Med_ Laser`` -> "Med. Laser"
    | Item.``Sml_ Laser`` -> "Sml. Laser"
    | Item.``Salvaging Laser`` -> "Salvaging Laser"
    | Item.``Backup Laser I`` -> "Backup Laser I"
    | Item.``Beam Rifle`` -> "Beam Rifle"
    | Item.``Particle Gun`` -> "Particle Gun"
    | Item.``Spread Laser`` -> "Spread Laser"
    | Item.``Imp_ Medium Laser`` -> "Imp. Medium Laser"
    | Item.``Sub_ Laser`` -> "Sub. Laser"
    | Item.``Autobeam`` -> "Autobeam"
    | Item.``Field Laser`` -> "Field Laser"
    | Item.``Pulse Rifle`` -> "Pulse Rifle"
    | Item.``Ovr_ Pulse Rifle`` -> "Ovr. Pulse Rifle"
    | Item.``Backup Laser III`` -> "Backup Laser III"
    | Item.``Hvy_ Particle Gun`` -> "Hvy. Particle Gun"
    | Item.``Prc_ Beam Rifle`` -> "Prc. Beam Rifle"
    | Item.``Adv_ Beam Rifle`` -> "Adv. Beam Rifle"
    | Item.``Hvy_ Laser`` -> "Hvy. Laser"
    | Item.``Gatling Laser`` -> "Gatling Laser"
    | Item.``Cld_ Pulse Rifle`` -> "Cld. Pulse Rifle"
    | Item.``Hpw_ Field Laser`` -> "Hpw. Field Laser"
    | Item.``Imp_ Spread Laser`` -> "Imp. Spread Laser"
    | Item.``Mak_ Laser`` -> "Mak. Laser"
    | Item.``Plasma Rifle`` -> "Plasma Rifle"
    | Item.``Thermic Laser`` -> "Thermic Laser"
    | Item.``Beamcaster`` -> "Beamcaster"
    | Item.``Force Rifle`` -> "Force Rifle"
    | Item.``Imp_ Heavy Laser`` -> "Imp. Heavy Laser"
    | Item.``Storm Laser`` -> "Storm Laser"
    | Item.``Zio_ Laser-S`` -> "Zio. Laser-S"
    | Item.``Wave Gun`` -> "Wave Gun"
    | Item.``Variable Charge Gun`` -> "Variable Charge Gun"
    | Item.``Hvy_ Beamcaster`` -> "Hvy. Beamcaster"
    | Item.``Ovr_ Beamcaster`` -> "Ovr. Beamcaster"
    | Item.``Cld_ Plasma Rifle`` -> "Cld. Plasma Rifle"
    | Item.``Enh_ Force Rifle`` -> "Enh. Force Rifle"
    | Item.``Hvy_ Gatling Laser`` -> "Hvy. Gatling Laser"
    | Item.``Zio_ Phaser-S`` -> "Zio. Phaser-S"
    | Item.``Phase Gun`` -> "Phase Gun"
    | Item.``Dispersion Rifle`` -> "Dispersion Rifle"
    | Item.``Backup Laser VII`` -> "Backup Laser VII"
    | Item.``Plasma Storm`` -> "Plasma Storm"
    | Item.``Adv_ Plasma Rifle`` -> "Adv. Plasma Rifle"
    | Item.``Hvy_ Wave Gun`` -> "Hvy. Wave Gun"
    | Item.``Adv_ Variable Charge Gun`` -> "Adv. Variable Charge Gun"
    | Item.``Cld_ Phase Gun`` -> "Cld. Phase Gun"
    | Item.``Lrn_ Gatling Laser`` -> "Lrn. Gatling Laser"
    | Item.``Warp Gun`` -> "Warp Gun"
    | Item.``Vortex Rifle`` -> "Vortex Rifle"
    | Item.``Zio_ Laser-M`` -> "Zio. Laser-M"
    | Item.``AWS_Thermal`` -> "AWS/Thermal"
    | Item.``PD Laser`` -> "PD Laser"
    | Item.``KN-7UR's Autopenetrator`` -> "KN-7UR's Autopenetrator"
    | Item.``Quantum Rifle`` -> "Quantum Rifle"
    | Item.``Ovr_ Quantum Rifle`` -> "Ovr. Quantum Rifle"
    | Item.``Prc_ Phase Gun`` -> "Prc. Phase Gun"
    | Item.``Hvy_ Dispersion Rifle`` -> "Hvy. Dispersion Rifle"
    | Item.``Vortex Shotgun`` -> "Vortex Shotgun"
    | Item.``Vortex Rail`` -> "Vortex Rail"
    | Item.``Zio_ Phaser-M`` -> "Zio. Phaser-M"
    | Item.``Enh_ Quantum Rifle`` -> "Enh. Quantum Rifle"
    | Item.``Zio_ Laser-H`` -> "Zio. Laser-H"
    | Item.``Hvy_ Quantum Rifle`` -> "Hvy. Quantum Rifle"
    | Item.``Zio_ Phaser-H`` -> "Zio. Phaser-H"
    | Item.``Gatling Beam`` -> "Gatling Beam"
    | Item.``Sigix Sheargun`` -> "Sigix Sheargun"
    | Item.``Modified Sigix Sheargun`` -> "Modified Sigix Sheargun"
    | Item.``Lgt_ EM Pulse Cannon`` -> "Lgt. EM Pulse Cannon"
    | Item.``EM Pulse Cannon`` -> "EM Pulse Cannon"
    | Item.``Imp_ EM Pulse Cannon`` -> "Imp. EM Pulse Cannon"
    | Item.``Proton Cannon`` -> "Proton Cannon"
    | Item.``Lrn_ Proton Cannon`` -> "Lrn. Proton Cannon"
    | Item.``Disruptor Cannon`` -> "Disruptor Cannon"
    | Item.``Hvy_ Proton Cannon`` -> "Hvy. Proton Cannon"
    | Item.``HERF Cannon`` -> "HERF Cannon"
    | Item.``Hvy_ Disruptor Cannon`` -> "Hvy. Disruptor Cannon"
    | Item.``Cld_ Proton Cannon`` -> "Cld. Proton Cannon"
    | Item.``Proton Burst Cannon`` -> "Proton Burst Cannon"
    | Item.``Com_ HERF Cannon`` -> "Com. HERF Cannon"
    | Item.``Latent Energy Streamer`` -> "Latent Energy Streamer"
    | Item.``NK-0LA's Tesla Doomcannon`` -> "NK-0LA's Tesla Doomcannon"
    | Item.``EMDS`` -> "EMDS"
    | Item.``Hpw_ Disruptor Cannon`` -> "Hpw. Disruptor Cannon"
    | Item.``Beam Cannon`` -> "Beam Cannon"
    | Item.``Particle Cannon`` -> "Particle Cannon"
    | Item.``Adv_ Beam Cannon`` -> "Adv. Beam Cannon"
    | Item.``Sub_ Beam Cannon`` -> "Sub. Beam Cannon"
    | Item.``Hvy_ Particle Cannon`` -> "Hvy. Particle Cannon"
    | Item.``Ion Cannon`` -> "Ion Cannon"
    | Item.``Plasma Cannon`` -> "Plasma Cannon"
    | Item.``Hvy_ Ion Cannon`` -> "Hvy. Ion Cannon"
    | Item.``Cld_ Particle Cannon`` -> "Cld. Particle Cannon"
    | Item.``Phase Cannon`` -> "Phase Cannon"
    | Item.``Hvy_ Plasma Cannon`` -> "Hvy. Plasma Cannon"
    | Item.``Cld_ Plasma Cannon`` -> "Cld. Plasma Cannon"
    | Item.``Com_ Ion Cannon`` -> "Com. Ion Cannon"
    | Item.``Ion Burst Cannon`` -> "Ion Burst Cannon"
    | Item.``Adv_ Plasma Cannon`` -> "Adv. Plasma Cannon"
    | Item.``Hvy_ Phase Cannon`` -> "Hvy. Phase Cannon"
    | Item.``Neutron Cannon`` -> "Neutron Cannon"
    | Item.``Powered Cannon`` -> "Powered Cannon"
    | Item.``Matter Neutralizer`` -> "Matter Neutralizer"
    | Item.``Hvy_ Neutron Cannon`` -> "Hvy. Neutron Cannon"
    | Item.``Lrn_ Phase Cannon`` -> "Lrn. Phase Cannon"
    | Item.``Cld_ Phase Cannon`` -> "Cld. Phase Cannon"
    | Item.``Vortex Cannon`` -> "Vortex Cannon"
    | Item.``Gui_ Plasma Cannon`` -> "Gui. Plasma Cannon"
    | Item.``Nova Cannon`` -> "Nova Cannon"
    | Item.``Imp_ Matter Neutralizer`` -> "Imp. Matter Neutralizer"
    | Item.``Exp_ Thermic Cannon`` -> "Exp. Thermic Cannon"
    | Item.``Vortex Driver`` -> "Vortex Driver"
    | Item.``Zio_ Alpha Cannon`` -> "Zio. Alpha Cannon"
    | Item.``Asb_ Focal Cannon`` -> "Asb. Focal Cannon"
    | Item.``Enh_ Nova Cannon`` -> "Enh. Nova Cannon"
    | Item.``Firepult`` -> "Firepult"
    | Item.``YOLO Cannon`` -> "YOLO Cannon"
    | Item.``Potential Cannon`` -> "Potential Cannon"
    | Item.``Warp Cannon`` -> "Warp Cannon"
    | Item.``Cld_ Nova Cannon`` -> "Cld. Nova Cannon"
    | Item.``Null Cannon`` -> "Null Cannon"
    | Item.``Hyp_ Alpha Cannon`` -> "Hyp. Alpha Cannon"
    | Item.``Zio_ Alpha Cannon Mk_ II`` -> "Zio. Alpha Cannon Mk. II"
    | Item.``Imp_ Potential Cannon`` -> "Imp. Potential Cannon"
    | Item.``Multinova Projection Cannon`` -> "Multinova Projection Cannon"
    | Item.``Disintegrator`` -> "Disintegrator"
    | Item.``Core Cannon`` -> "Core Cannon"
    | Item.``Sigix Shearcannon`` -> "Sigix Shearcannon"
    | Item.``Drained L-Cannon`` -> "Drained L-Cannon"
    | Item.``L-Cannon`` -> "L-Cannon"
    | Item.``BFG-9k Vortex Edition`` -> "BFG-9k Vortex Edition"
    | Item.``Assault Rifle`` -> "Assault Rifle"
    | Item.``Asb_ Rifle`` -> "Asb. Rifle"
    | Item.``Lgt_ Assault Rifle`` -> "Lgt. Assault Rifle"
    | Item.``Bolt Gun`` -> "Bolt Gun"
    | Item.``Hvy_ Assault Rifle`` -> "Hvy. Assault Rifle"
    | Item.``Autogun`` -> "Autogun"
    | Item.``Shotgun`` -> "Shotgun"
    | Item.``Battle Rifle`` -> "Battle Rifle"
    | Item.``Asb_ Heavy Rifle`` -> "Asb. Heavy Rifle"
    | Item.``Sub_ Machine Gun`` -> "Sub. Machine Gun"
    | Item.``Imp_ Assault Rifle`` -> "Imp. Assault Rifle"
    | Item.``Minigun`` -> "Minigun"
    | Item.``Hpw_ Shotgun`` -> "Hpw. Shotgun"
    | Item.``Asb_ Shotgun`` -> "Asb. Shotgun"
    | Item.``Barrage Gun`` -> "Barrage Gun"
    | Item.``Ovr_ Barrage Gun`` -> "Ovr. Barrage Gun"
    | Item.``Enh_ Autogun`` -> "Enh. Autogun"
    | Item.``Gauss Rifle`` -> "Gauss Rifle"
    | Item.``Asb_ Gauss Rifle`` -> "Asb. Gauss Rifle"
    | Item.``Flak Gun`` -> "Flak Gun"
    | Item.``Prc_ Assault Rifle`` -> "Prc. Assault Rifle"
    | Item.``Hvy_ Battle Rifle`` -> "Hvy. Battle Rifle"
    | Item.``Mak_ Shrapnel Gun`` -> "Mak. Shrapnel Gun"
    | Item.``Coil Gun`` -> "Coil Gun"
    | Item.``Hyp_ Gauss Rifle`` -> "Hyp. Gauss Rifle"
    | Item.``Hvy_ Machine Gun`` -> "Hvy. Machine Gun"
    | Item.``Imp_ Heavy Machine Gun`` -> "Imp. Heavy Machine Gun"
    | Item.``Com_ Gauss Rifle`` -> "Com. Gauss Rifle"
    | Item.``XL Autogun Subcomponent`` -> "XL Autogun Subcomponent"
    | Item.``KE Penetrator`` -> "KE Penetrator"
    | Item.``Hyp_ Coil Gun`` -> "Hyp. Coil Gun"
    | Item.``Ovr_ Coil Gun`` -> "Ovr. Coil Gun"
    | Item.``Imp_ KE Penetrator`` -> "Imp. KE Penetrator"
    | Item.``Enh_ Coil Gun`` -> "Enh. Coil Gun"
    | Item.``Com_ Coil Gun`` -> "Com. Coil Gun"
    | Item.``Railgun`` -> "Railgun"
    | Item.``Adv_ KE Penetrator`` -> "Adv. KE Penetrator"
    | Item.``Linked Autogun`` -> "Linked Autogun"
    | Item.``AWS_Gauss`` -> "AWS/Gauss"
    | Item.``Hyp_ Railgun`` -> "Hyp. Railgun"
    | Item.``Ovr_ Railgun`` -> "Ovr. Railgun"
    | Item.``Helical Railgun`` -> "Helical Railgun"
    | Item.``Com_ Railgun`` -> "Com. Railgun"
    | Item.``XL Autogun Array`` -> "XL Autogun Array"
    | Item.``12-ASH's Boomstick`` -> "12-ASH's Boomstick"
    | Item.``8R-AWN's Boregun`` -> "8R-AWN's Boregun"
    | Item.``Multirail`` -> "Multirail"
    | Item.``Hyp_ Multirail`` -> "Hyp. Multirail"
    | Item.``5H-AD0's Sniper Rifle`` -> "5H-AD0's Sniper Rifle"
    | Item.``A3's Sniper Rifle`` -> "A3's Sniper Rifle"
    | Item.``Lgt_ Cannon`` -> "Lgt. Cannon"
    | Item.``Imp_ Light Cannon`` -> "Imp. Light Cannon"
    | Item.``Battle Cannon`` -> "Battle Cannon"
    | Item.``Assault Cannon`` -> "Assault Cannon"
    | Item.``Hvy_ Assault Cannon`` -> "Hvy. Assault Cannon"
    | Item.``Flak Cannon`` -> "Flak Cannon"
    | Item.``Adv_ Assault Cannon`` -> "Adv. Assault Cannon"
    | Item.``Gauss Cannon`` -> "Gauss Cannon"
    | Item.``Slug Cannon`` -> "Slug Cannon"
    | Item.``Mni_ Assault Cannon`` -> "Mni. Assault Cannon"
    | Item.``Siege Cannon Replica`` -> "Siege Cannon Replica"
    | Item.``Magnetic Acceleration Cannon`` -> "Magnetic Acceleration Cannon"
    | Item.``Hvy_ Flak Cannon`` -> "Hvy. Flak Cannon"
    | Item.``Bore Cannon`` -> "Bore Cannon"
    | Item.``Antimatter Cannon`` -> "Antimatter Cannon"
    | Item.``Siege Cannon`` -> "Siege Cannon"
    | Item.``Mass Driver`` -> "Mass Driver"
    | Item.``Hvy_ Mass Driver`` -> "Hvy. Mass Driver"
    | Item.``Enh_ Gauss Cannon`` -> "Enh. Gauss Cannon"
    | Item.``Hyp_ Gauss Cannon`` -> "Hyp. Gauss Cannon"
    | Item.``Tri-rail Accelerator`` -> "Tri-rail Accelerator"
    | Item.``Hardcell Cannon`` -> "Hardcell Cannon"
    | Item.``Hvy_ Gauss Cannon`` -> "Hvy. Gauss Cannon"
    | Item.``Hyp_ Mass Driver`` -> "Hyp. Mass Driver"
    | Item.``Hvy_ Autocannon`` -> "Hvy. Autocannon"
    | Item.``DAS Cannon`` -> "DAS Cannon"
    | Item.``Lgt_ Antimatter Cannon`` -> "Lgt. Antimatter Cannon"
    | Item.``Linear Accelerator`` -> "Linear Accelerator"
    | Item.``Hvy_ Linear Accelerator`` -> "Hvy. Linear Accelerator"
    | Item.``Com_ Mass Driver`` -> "Com. Mass Driver"
    | Item.``Hvy_ Hardcell Cannon`` -> "Hvy. Hardcell Cannon"
    | Item.``Com_ Linear Accelerator`` -> "Com. Linear Accelerator"
    | Item.``Hyp_ Linear Accelerator`` -> "Hyp. Linear Accelerator"
    | Item.``Hcl_ Linear Accelerator`` -> "Hcl. Linear Accelerator"
    | Item.``Graviton Cannon`` -> "Graviton Cannon"
    | Item.``Blast Cannon`` -> "Blast Cannon"
    | Item.``P1-3CE's Gatling Flakker`` -> "P1-3CE's Gatling Flakker"
    | Item.``AWS_Autocannon`` -> "AWS/Autocannon"
    | Item.``Perforator`` -> "Perforator"
    | Item.``Omega Cannon`` -> "Omega Cannon"
    | Item.``PL-3XN's Obliterator`` -> "PL-3XN's Obliterator"
    | Item.``EMP Blaster`` -> "EMP Blaster"
    | Item.``Shock Bomb Launcher`` -> "Shock Bomb Launcher"
    | Item.``Adv_ EMP Blaster`` -> "Adv. EMP Blaster"
    | Item.``Proton Missile Launcher`` -> "Proton Missile Launcher"
    | Item.``Imp_ Proton Missile Launcher`` -> "Imp. Proton Missile Launcher"
    | Item.``Gui_ EMP Blaster`` -> "Gui. EMP Blaster"
    | Item.``Hvy_ Shock Bomb Launcher`` -> "Hvy. Shock Bomb Launcher"
    | Item.``Tesla Bomb Launcher`` -> "Tesla Bomb Launcher"
    | Item.``Hvy_ Proton Missile Launcher`` -> "Hvy. Proton Missile Launcher"
    | Item.``Com_ Tesla Bomb Launcher`` -> "Com. Tesla Bomb Launcher"
    | Item.``Gamma Bomb Array`` -> "Gamma Bomb Array"
    | Item.``Enh_ Gamma Bomb Array`` -> "Enh. Gamma Bomb Array"
    | Item.``Grenade Launcher`` -> "Grenade Launcher"
    | Item.``Rocket Launcher`` -> "Rocket Launcher"
    | Item.``Mni_ Grenade Launcher`` -> "Mni. Grenade Launcher"
    | Item.``Sub_ Shrapnel Launcher`` -> "Sub. Shrapnel Launcher"
    | Item.``Imp_ Grenade Launcher`` -> "Imp. Grenade Launcher"
    | Item.``Missile Launcher`` -> "Missile Launcher"
    | Item.``Concussive RPG`` -> "Concussive RPG"
    | Item.``YI-UF0's Doublenader`` -> "YI-UF0's Doublenader"
    | Item.``Hvy_ Rocket Launcher`` -> "Hvy. Rocket Launcher"
    | Item.``Hvy_ Missile Launcher`` -> "Hvy. Missile Launcher"
    | Item.``Gui_ Missile Launcher`` -> "Gui. Missile Launcher"
    | Item.``Prc_ Grenade Launcher`` -> "Prc. Grenade Launcher"
    | Item.``Rocket Array`` -> "Rocket Array"
    | Item.``Lrn_ Missile Launcher`` -> "Lrn. Missile Launcher"
    | Item.``Imp_ Concussive RPG`` -> "Imp. Concussive RPG"
    | Item.``Prc_ Rocket Launcher`` -> "Prc. Rocket Launcher"
    | Item.``Scatter Rocket Array`` -> "Scatter Rocket Array"
    | Item.``Smartbomb Launcher`` -> "Smartbomb Launcher"
    | Item.``Mni_ Smartbomb Launcher`` -> "Mni. Smartbomb Launcher"
    | Item.``Tiamat Missile Launcher`` -> "Tiamat Missile Launcher"
    | Item.``Thermoblaster`` -> "Thermoblaster"
    | Item.``Micro-nuke Launcher`` -> "Micro-nuke Launcher"
    | Item.``Adv_ Concussive RPG`` -> "Adv. Concussive RPG"
    | Item.``Neutron Missile Launcher`` -> "Neutron Missile Launcher"
    | Item.``Fusion Bomb Launcher`` -> "Fusion Bomb Launcher"
    | Item.``Hellfire Missile Launcher`` -> "Hellfire Missile Launcher"
    | Item.``Adv_ Micro-nuke Launcher`` -> "Adv. Micro-nuke Launcher"
    | Item.``Tactical Quantum Warhead`` -> "Tactical Quantum Warhead"
    | Item.``Vortex Catalyst Activator`` -> "Vortex Catalyst Activator"
    | Item.``Chain Missile Launcher`` -> "Chain Missile Launcher"
    | Item.``Ragnarok Missile Launcher`` -> "Ragnarok Missile Launcher"
    | Item.``Point Singularity Launcher`` -> "Point Singularity Launcher"
    | Item.``Gui_ Micro-nuke Launcher`` -> "Gui. Micro-nuke Launcher"
    | Item.``99-TNT's Nukerbomber`` -> "99-TNT's Nukerbomber"
    | Item.``Exp_ Neutron Missile Launcher`` -> "Exp. Neutron Missile Launcher"
    | Item.``Z-bomb Delivery System`` -> "Z-bomb Delivery System"
    | Item.``Sigix Terminator`` -> "Sigix Terminator"
    | Item.``Supercharged Sigix Terminator`` -> "Supercharged Sigix Terminator"
    | Item.``Containment Facilitator`` -> "Containment Facilitator"
    | Item.``Detonator`` -> "Detonator"
    | Item.``Dirty Datajack`` -> "Dirty Datajack"
    | Item.``Splice Injector`` -> "Splice Injector"
    | Item.``Master Link`` -> "Master Link"
    | Item.``Datajack`` -> "Datajack"
    | Item.``Imp_ Datajack`` -> "Imp. Datajack"
    | Item.``Adv_ Datajack`` -> "Adv. Datajack"
    | Item.``Remote Datajack`` -> "Remote Datajack"
    | Item.``Imp_ Remote Datajack`` -> "Imp. Remote Datajack"
    | Item.``Adv_ Remote Datajack`` -> "Adv. Remote Datajack"
    | Item.``Exp_ Remote Datajack`` -> "Exp. Remote Datajack"
    | Item.``Gui_ Remote Datajack`` -> "Gui. Remote Datajack"
    | Item.``ME-RLN's Wand`` -> "ME-RLN's Wand"
    | Item.``System Spiker`` -> "System Spiker"
    | Item.``Field Lobotomy Kit`` -> "Field Lobotomy Kit"
    | Item.``Mining Laser`` -> "Mining Laser"
    | Item.``LU-1G1's Laser Shovel`` -> "LU-1G1's Laser Shovel"
    | Item.``Welding Torch`` -> "Welding Torch"
    | Item.``Plasma Cutter`` -> "Plasma Cutter"
    | Item.``Imp_ Plasma Cutter`` -> "Imp. Plasma Cutter"
    | Item.``Exp_ Plasma Cutter`` -> "Exp. Plasma Cutter"
    | Item.``CPS Tube`` -> "CPS Tube"
    | Item.``Multitool`` -> "Multitool"
    | Item.``Flamer`` -> "Flamer"
    | Item.``Asb_ F-torch`` -> "Asb. F-torch"
    | Item.``Enh_ Flamer`` -> "Enh. Flamer"
    | Item.``Plasma Flamer`` -> "Plasma Flamer"
    | Item.``Asb_ P-torch`` -> "Asb. P-torch"
    | Item.``RU-N14's Throwing Claymores`` -> "RU-N14's Throwing Claymores"
    | Item.``RU-N14's Throwing Claymores v3`` -> "RU-N14's Throwing Claymores v3"
    | Item.``Warlord Statue`` -> "Warlord Statue"
    | Item.``Voltaic Drivehammer`` -> "Voltaic Drivehammer"
    | Item.``AD-0RF's Magmablaster`` -> "AD-0RF's Magmablaster"
    | Item.``IN-MT5's Pitchfork _Insurrection_`` -> "IN-MT5's Pitchfork 'Insurrection'"
    | Item.``Shield Trident`` -> "Shield Trident"
    | Item.``Junk Cannon`` -> "Junk Cannon"
    | Item.``Stasis Beam`` -> "Stasis Beam"
    | Item.``Stasis Projector`` -> "Stasis Projector"
    | Item.``Exp_ Stasis Projector`` -> "Exp. Stasis Projector"
    | Item.``Molecular Deconstructor`` -> "Molecular Deconstructor"
    | Item.``SE_WE1`` -> "SE_WE1"
    | Item.``SE_WE2`` -> "SE_WE2"
    | Item.``SE_WE3`` -> "SE_WE3"
    | Item.``SE_WE4`` -> "SE_WE4"
    | Item.``SE_WE5`` -> "SE_WE5"
    | Item.``Hammer`` -> "Hammer"
    | Item.``Mace`` -> "Mace"
    | Item.``Flail`` -> "Flail"
    | Item.``Maul`` -> "Maul"
    | Item.``Asb_ Maul`` -> "Asb. Maul"
    | Item.``Hvy_ Hammer`` -> "Hvy. Hammer"
    | Item.``Hvy_ Mace`` -> "Hvy. Mace"
    | Item.``Hvy_ Flail`` -> "Hvy. Flail"
    | Item.``Great Maul`` -> "Great Maul"
    | Item.``Powered Hammer`` -> "Powered Hammer"
    | Item.``Mak_ Hammer`` -> "Mak. Hammer"
    | Item.``Power Maul`` -> "Power Maul"
    | Item.``Asb_ P-maul`` -> "Asb. P-maul"
    | Item.``Impact Mace`` -> "Impact Mace"
    | Item.``Shock Maul`` -> "Shock Maul"
    | Item.``Thunder Hammer`` -> "Thunder Hammer"
    | Item.``Compactor`` -> "Compactor"
    | Item.``Gravity Flail`` -> "Gravity Flail"
    | Item.``CL-ANK's Mallet`` -> "CL-ANK's Mallet"
    | Item.``Core Stripper`` -> "Core Stripper"
    | Item.``Mining Claw`` -> "Mining Claw"
    | Item.``EC_1`` -> "EC_1"
    | Item.``Katana`` -> "Katana"
    | Item.``Asb_ Blade`` -> "Asb. Blade"
    | Item.``Scythe`` -> "Scythe"
    | Item.``Axe`` -> "Axe"
    | Item.``Blade Saw`` -> "Blade Saw"
    | Item.``EC_3`` -> "EC_3"
    | Item.``Chainsword`` -> "Chainsword"
    | Item.``Ripper`` -> "Ripper"
    | Item.``Mak_ Axe`` -> "Mak. Axe"
    | Item.``Mak_ Sword`` -> "Mak. Sword"
    | Item.``Great Axe`` -> "Great Axe"
    | Item.``Greatsword`` -> "Greatsword"
    | Item.``Ripteeth`` -> "Ripteeth"
    | Item.``Power Sword`` -> "Power Sword"
    | Item.``Asb_ P-sword`` -> "Asb. P-sword"
    | Item.``Falx`` -> "Falx"
    | Item.``Carbide Saw`` -> "Carbide Saw"
    | Item.``Segregator`` -> "Segregator"
    | Item.``Tearclaws`` -> "Tearclaws"
    | Item.``Companion Sword`` -> "Companion Sword"
    | Item.``EC_5`` -> "EC_5"
    | Item.``Phasing Sabre`` -> "Phasing Sabre"
    | Item.``Plasma Sword`` -> "Plasma Sword"
    | Item.``Ionic Axe`` -> "Ionic Axe"
    | Item.``Mni_ Tearclaws`` -> "Mni. Tearclaws"
    | Item.``Vmp_ Broadsword`` -> "Vmp. Broadsword"
    | Item.``Dual-blade Saw`` -> "Dual-blade Saw"
    | Item.``Vibroblade`` -> "Vibroblade"
    | Item.``Molecular Scythe`` -> "Molecular Scythe"
    | Item.``Centrium Greatsword`` -> "Centrium Greatsword"
    | Item.``Master Tearclaws`` -> "Master Tearclaws"
    | Item.``Longsword _1`` -> "Longsword +1"
    | Item.``EC_7`` -> "EC_7"
    | Item.``Nanosword`` -> "Nanosword"
    | Item.``Particle Cleaver`` -> "Particle Cleaver"
    | Item.``Centrium Claws`` -> "Centrium Claws"
    | Item.``1C-UTU's Sword _Lootmaker_`` -> "1C-UTU's Sword 'Lootmaker'"
    | Item.``DM-GVY's Chainsaw`` -> "DM-GVY's Chainsaw"
    | Item.``Vortex Shredder`` -> "Vortex Shredder"
    | Item.``EC_9`` -> "EC_9"
    | Item.``1C-UTU's Sword _Choppy_`` -> "1C-UTU's Sword 'Choppy'"
    | Item.``Quantum Companion`` -> "Quantum Companion"
    | Item.``Superquantum Companion`` -> "Superquantum Companion"
    | Item.``Quantum Blade`` -> "Quantum Blade"
    | Item.``Sigix Broadsword`` -> "Sigix Broadsword"
    | Item.``Spear`` -> "Spear"
    | Item.``Mak_ Spear`` -> "Mak. Spear"
    | Item.``CR-A16's Pointy Stick`` -> "CR-A16's Pointy Stick"
    | Item.``Hvy_ Pick`` -> "Hvy. Pick"
    | Item.``Lance`` -> "Lance"
    | Item.``Kinetic Spear`` -> "Kinetic Spear"
    | Item.``Force Lance`` -> "Force Lance"
    | Item.``Plasma Lance`` -> "Plasma Lance"
    | Item.``Enh_ Force Lance`` -> "Enh. Force Lance"
    | Item.``Vortex Lance`` -> "Vortex Lance"
    | Item.``CR-A16's Behemoth Slayer`` -> "CR-A16's Behemoth Slayer"
    | Item.``Thermal Lance`` -> "Thermal Lance"
    | Item.``Blade Trap`` -> "Blade Trap"
    | Item.``Segregator Trap`` -> "Segregator Trap"
    | Item.``Explosive Trap`` -> "Explosive Trap"
    | Item.``Heavy Explosive Trap`` -> "Heavy Explosive Trap"
    | Item.``Tiamat Bomb Trap`` -> "Tiamat Bomb Trap"
    | Item.``Fusion Bomb Trap`` -> "Fusion Bomb Trap"
    | Item.``Hellfire Trap`` -> "Hellfire Trap"
    | Item.``Armageddon Trap`` -> "Armageddon Trap"
    | Item.``Dirty Bomb Trap`` -> "Dirty Bomb Trap"
    | Item.``EMP Trap`` -> "EMP Trap"
    | Item.``Proton Bomb Trap`` -> "Proton Bomb Trap"
    | Item.``Tesla Bomb Trap`` -> "Tesla Bomb Trap"
    | Item.``Gamma Bomb Trap`` -> "Gamma Bomb Trap"
    | Item.``Shrapnel Trap`` -> "Shrapnel Trap"
    | Item.``Vortex Trap`` -> "Vortex Trap"
    | Item.``Piercing Trap`` -> "Piercing Trap"
    | Item.``Shock Trap`` -> "Shock Trap"
    | Item.``EM Surge Trap`` -> "EM Surge Trap"
    | Item.``Fire Trap`` -> "Fire Trap"
    | Item.``Heat Bomb Trap`` -> "Heat Bomb Trap"
    | Item.``Stasis Trap`` -> "Stasis Trap"
    | Item.``Scrap Shield Fragment`` -> "Scrap Shield Fragment"
    | Item.``SUBCON Basin`` -> "SUBCON Basin"
    | Item.``Signal Generator`` -> "Signal Generator"
    | Item.``Self-destruct Interrupter`` -> "Self-destruct Interrupter"
    | Item.``DRS Beacon`` -> "DRS Beacon"
    | Item.``Sapper Charge`` -> "Sapper Charge"
    | Item.``Deploy-a-Sentry`` -> "Deploy-a-Sentry"
    | Item.``Botcube`` -> "Botcube"
    | Item.``Lrg_ Botcube`` -> "Lrg. Botcube"
    | Item.``PL-3XN's Ring of Power`` -> "PL-3XN's Ring of Power"
    | Item.``Disassembled Obliterator`` -> "Disassembled Obliterator"
    | Item.``GAL Module`` -> "GAL Module"
    | Item.``Portable AFG`` -> "Portable AFG"
    | Item.``Zhirov Special`` -> "Zhirov Special"
    | Item.``SGEMP Prototype`` -> "SGEMP Prototype"
    | Item.``Terrabomb Derivative`` -> "Terrabomb Derivative"
    | Item.``Sigix Containment Pod`` -> "Sigix Containment Pod"
    | Item.``Sigix Corpse`` -> "Sigix Corpse"
    | Item.``Meganuke`` -> "Meganuke"
    | Item.``Gamma Refractor`` -> "Gamma Refractor"
    | x -> raise (System.ArgumentException(sprintf "Invalid item id! %A" x))


[<RequireQualifiedAccess>]
type Prop =
    | ``Concrete Rubble``
    | ``Metal Rubble``
    | ``Unfinished Machinery``
    | ``GENERIC_MACHINE_10``
    | ``GENERIC_MACHINE_9``
    | ``GENERIC_MACHINE_8``
    | ``GENERIC_MACHINE_7``
    | ``GENERIC_MACHINE_6``
    | ``GENERIC_MACHINE_5``
    | ``GENERIC_MACHINE_4``
    | ``GENERIC_MACHINE_3``
    | ``GENERIC_MACHINE_2``
    | ``GENERIC_MACHINE_1``
    | ``Terminal vFe_01a``
    | ``Terminal vNi_03a``
    | ``Terminal vCu_03a``
    | ``Terminal vZn_06a``
    | ``Terminal vAg_06a``
    | ``Terminal vTi_06n``
    | ``Terminal vCo_08n``
    | ``Terminal vMn_10n``
    | ``Terminal vMo_07n``
    | ``Terminal vPd_10n``
    | ``Terminal vCd_08n``
    | ``Terminal vZr_10n``
    | ``Terminal vY_10n``
    | ``Terminal vW_10x``
    | ``Terminal vIr_12x``
    | ``Terminal vPt_12x``
    | ``Terminal vAu_13x``
    | ``Terminal vHg_20x``
    | ``Terminal vRh_10x``
    | ``Fabricator vLi_07a``
    | ``Fabricator vNa_07a``
    | ``Fabricator vK_08a``
    | ``Fabricator vCs_10n``
    | ``Fabricator vBe_12n``
    | ``Fabricator vMg_13n``
    | ``Fabricator vCa_14x``
    | ``Fabricator vSr_14x``
    | ``Fabricator vBa_16x``
    | ``Fabricator vRa_19x``
    | ``Repair vAl_08a``
    | ``Repair vGa_08a``
    | ``Repair vIn_08a``
    | ``Repair vSn_08n``
    | ``Repair vTl_10n``
    | ``Repair vPb_11n``
    | ``Repair vBi_12x``
    | ``Repair vPo_13x``
    | ``Recycling vH_06a``
    | ``Recycling vN_06a``
    | ``Recycling vO_08n``
    | ``Recycling vF_08n``
    | ``Recycling vP_10x``
    | ``Recycling vI_14x``
    | ``Scanalyzer vHe_07a``
    | ``Scanalyzer vNe_13n``
    | ``Scanalyzer vAr_15x``
    | ``Scanalyzer vXe_13x``
    | ``Garrison vCe_6a``
    | ``Garrison vPr_8a``
    | ``Garrison vNd_9n``
    | ``Garrison vPm_7n``
    | ``Garrison vSm_13x``
    | ``Garrison vEu_9x``
    | ``T1``
    | ``Core Extractor``
    | ``Pulverizer``
    | ``Laser Drill``
    | ``Plasma Injector``
    | ``Seismic Survey Station``
    | ``Matter Pump``
    | ``Pressure Siphon``
    | ``Nuclear Reactor``
    | ``Neutrino Reactor``
    | ``Fusion Modulator``
    | ``Quantum Generator``
    | ``Dark Matter Chamber``
    | ``Hypermatter Reactor``
    | ``Compression Vault``
    | ``Component Storage``
    | ``Holding Depot``
    | ``Packing Station``
    | ``Arsenal Racks``
    | ``Extraspacial Lockers``
    | ``Energy Cycler``
    | ``Transport Mainframe``
    | ``Transfer Shaft``
    | ``Hadron Collector``
    | ``Electrolysis Chamber``
    | ``Processing Tank``
    | ``Atomic Centrifuge``
    | ``Purification Channel``
    | ``Integration Channel``
    | ``Material Processor``
    | ``Material Compactor``
    | ``Matter Filter``
    | ``Manufacturing Mainframe``
    | ``Construction Platform``
    | ``Assembly Bed``
    | ``Megafabricator``
    | ``Subcomponent Replicator``
    | ``Power Conduit``
    | ``Research Mainframe``
    | ``Antiparticle Reservoir``
    | ``Reaction Chamber``
    | ``Vacuum Chamber``
    | ``Subatomic Condenser``
    | ``Catalytron``
    | ``Meson Extractor``
    | ``Antimatter Diverter``
    | ``Field Manipulator``
    | ``Particle Synthesizer``
    | ``Quantum Separator``
    | ``Wave Intensifier``
    | ``Proton Scatter Basin``
    | ``Ion Accelerator``
    | ``Magnetic Photon System``
    | ``Hypercollider``
    | ``Graviton Restrictor``
    | ``Potential Refractor``
    | ``Prototyping Station``
    | ``Engineering Station``
    | ``Biostasis Chamber``
    | ``Organic Neutralizer``
    | ``Containment Shield``
    | ``Testing Mainframe``
    | ``Sonic Impulse Analyzer``
    | ``Field Warper``
    | ``Gravity Sphere``
    | ``Quantum Transformer``
    | ``Focalizer``
    | ``Phase Constrictor``
    | ``Resonance Scanner``
    | ``Tau Charger``
    | ``Harmonic Fracturing Unit``
    | ``Antiparticle Suffusor``
    | ``Thermocompressor Array``
    | ``Cryocooling Duct``
    | ``Artifact Storage``
    | ``Cryopreservation Unit``
    | ``Biostim Tank``
    | ``Quarantine Pod``
    | ``Aeration Cycler``
    | ``Deconstruction Unit``
    | ``Anatomizer``
    | ``Cloning Tubes``
    | ``Cell Assembler``
    | ``Molecular Binding Bank``
    | ``Anti-Ion Cluster``
    | ``Deuterium Array``
    | ``Mainframe``
    | ``Storage``
    | ``Retrofitting Station``
    | ``Signal Jammer``
    | ``Cloak Generator``
    | ``Decryption Engine``
    | ``Backup Mainframe``
    | ``Archive Unit``
    | ``Control Node``
    | ``Operations Mainframe``
    | ``Quantum Router``
    | ``Hyperwave Decoder``
    | ``Sealed Freight Elevator``
    | ``Radio-Gravity Array``
    | ``Anti-Orbital Battery``
    | ``Spectral Interrupter``
    | ``Wave Collapse Detector``
    | ``Signal Shield``
    | ``Longscan Aggregator``
    | ``Blade Trap``
    | ``Segregator Trap``
    | ``Explosive Trap``
    | ``Heavy Explosive Trap``
    | ``Tiamat Bomb Trap``
    | ``Fusion Bomb Trap``
    | ``Hellfire Trap``
    | ``Armageddon Trap``
    | ``Dirty Bomb Trap``
    | ``EMP Trap``
    | ``Proton Bomb Trap``
    | ``Tesla Bomb Trap``
    | ``Gamma Bomb Trap``
    | ``Shrapnel Trap``
    | ``Vortex Trap``
    | ``Piercing Trap``
    | ``Shock Trap``
    | ``EM Surge Trap``
    | ``Fire Trap``
    | ``Heat Bomb Trap``
    | ``Stasis Trap``
    | ``Alarm Trap``
    | ``Ambush Trap``
    | ``Chute Trap``
    | ``Collapsed Tunnel``
    | ``Door Terminal``
    | ``DSF Access``
    | ``Broken Shaft Lining``
    | ``XXX_Blast_Door_Open``
    | ``XXX_Blast_Door_Hackable``
    | ``ACC_Door_Shootable_SUR``
    | ``ACC_Door_Shootable_COM``
    | ``ACC_Door_Hackable``
    | ``ACC_Shell_Shootable``
    | ``Main Access Lift``
    | ``STO_Door_Open``
    | ``STO_Door_Hackable``
    | ``STO_Shell_Shootable``
    | ``Scraplab SEP``
    | ``Scrap Engine Manual``
    | ``Supplies``
    | ``C-Scrubber``
    | ``UFD Members``
    | ``UFD Registry``
    | ``UFD Projects``
    | ``0bPrime Members Only``
    | ``UFD Mainframe``
    | ``UFD HQ Gate``
    | ``Triangle Research``
    | ``SCR_Reading_Room_Door``
    | ``UFD Synopsis``
    | ``Book of Scrap``
    | ``Soloparser's Compendium``
    | ``General History``
    | ``Subcaves Research``
    | ``Sights of 0b1``
    | ``Notable Derelicts``
    | ``Western Derelicts``
    | ``Miscellany``
    | ``SCR_Enclosure``
    | ``Comm Apparatus``
    | ``Model Spaceship``
    | ``SCR_SOTW_Speaker``
    | ``SCR_Mechanic``
    | ``Lifeworm Database``
    | ``Replica Nuclear Reactor``
    | ``CP Mission Status``
    | ``Latest Submissions``
    | ``Demos``
    | ``Operating Theater``
    | ``SG-Prototypes Database``
    | ``0bJail``
    | ``IN-MT5's Safe``
    | ``0b10 Analyses``
    | ``JC Pilot Fab``
    | ``Cannon Storage``
    | ``SS Performance Data``
    | ``Super Scrap Suits``
    | ``Modified UFD Components``
    | ``Botcube Storage``
    | ``Sword Access``
    | ``GAR_Door_Shootable``
    | ``GAR_Relay``
    | ``GAR_Generator``
    | ``GAR_RIF_Installer``
    | ``Garrison Terminal``
    | ``GAR_Heavy_Assembler``
    | ``GAR_QS_Assembler``
    | ``SHOP_Sys``
    | ``MIN_Door_Hackable_Weak``
    | ``Assembled Analyzer``
    | ``Components``
    | ``Testing Chamber Shield``
    | ``Testing Apparatus``
    | ``EX-Generator``
    | ``BIN's Workstation``
    | ``DEC's Workstation``
    | ``HEX's Workstation``
    | ``BIN's Terminal``
    | ``DEC's Terminal``
    | ``HEX's Terminal``
    | ``EXI_Farcom``
    | ``EX-Vault Access``
    | ``EX-Prototypes Database``
    | ``EX-Message Board``
    | ``Repaired_Machine_T``
    | ``Repaired_Machine_F``
    | ``Repaired_Machine_R``
    | ``Repaired_Machine_Y``
    | ``Repaired_Machine_S``
    | ``Testing Chamber``
    | ``4L-MR0's Prototype Logs``
    | ``SUB_Autodoor``
    | ``Clippyterm``
    | ``Triangle-emblazoned Door``
    | ``UFD SUBCON Station``
    | ``Subatomizer Accumulator``
    | ``SUBCON Basin Controls``
    | ``WAR_Sys``
    | ``Prototyping Terminal``
    | ``CAV_Door_Hackable``
    | ``Outpost Terminal``
    | ``CAV_Base_Generator``
    | ``CAV_Junk_Machine``
    | ``CAV_Reinforcement``
    | ``CAV_Door_Shootable``
    | ``CAV_Door_No_Terminal``
    | ``Private``
    | ``CAV_Thief_Den``
    | ``W-Fans Enter Here``
    | ``LOW_Warlord_Fan_Stuff``
    | ``PRO_Base_Generator``
    | ``PRO_Target_Dispatcher``
    | ``PRO_Test_Aggregator``
    | ``PRO_Data_Receptor``
    | ``Matter Repository``
    | ``Twisting Tunnel``
    | ``DAT_Data_Conduit``
    | ``ORACLE Interface``
    | ``ZHI_Cloak_Generator``
    | ``ZHI_Main_Door``
    | ``Zhirov's Terminal``
    | ``Quantum Analyzer``
    | ``Zhirov's Workstation``
    | ``WAR_Door_Hackable``
    | ``Vortex Lab Terminal``
    | ``Hacking Lab Terminal``
    | ``Relay Lab Terminal``
    | ``Fabnet Lab Terminal``
    | ``Intel Room Terminal``
    | ``WAR_Staging_Area``
    | ``RES_Staging_Area``
    | ``WAR_Mainc_Tunnel``
    | ``ZIO_Machinery``
    | ``Deep Containment System``
    | ``ZIOWAR_Quarantine_Array``
    | ``ZIO_Cloak_Generator``
    | ``ZIO_Stockpile_Wall``
    | ``ZIO_Prototype_Hold``
    | ``ZIO_Lab_Wall``
    | ``ZIO_Repair_Shop_Wall``
    | ``Zion Terminal``
    | ``ZIO_Machinery_Fake``
    | ``Conduit Teleporter``
    | ``ZIO_Memory_Banks``
    | ``ZIO_Imprinter``
    | ``DEE_Z_Facility``
    | ``Z-Power``
    | ``DEE_Sigix_Wall``
    | ``DEE_Sigix_Gate``
    | ``DEE_Wall_Chamber``
    | ``DEE_Survey_Way_Station``
    | ``EXT_Door_Hackable``
    | ``EXT_Transfer_Station``
    | ``Cetus Terminal``
    | ``Cetus Manufacturing Controls``
    | ``CET_Door_Hackable``
    | ``Doors``
    | ``Bed``
    | ``Lockers``
    | ``Table``
    | ``Lab Station``
    | ``Research Interface``
    | ``Cetus Mainframe``
    | ``Cetus Manufacturing Module``
    | ``Archive Terminal``
    | ``Archive Hub``
    | ``HUB_Transfer_Station``
    | ``HUB_Network_Hub``
    | ``ARM_Door_Hackable``
    | ``ARM_Blast_Door_Hackable``
    | ``ARM_Shell_Shootable``
    | ``Derelict Superweapon?``
    | ``ARM_Dimension_Slip_Node``
    | ``NO ENTRY``
    | ``LAB_Door_Hackable``
    | ``Active System Cloaker``
    | ``A0 Command``
    | ``hN 3sDk7Qc``
    | ``A0 Storage 04-B``
    | ``UC xVqbSdU M7q4``
    | ``Suspension Chamber``
    | ``Blast Barrier``
    | ``TES_Door_Hackable``
    | ``TES_Shell_Shootable``
    | ``Regeneration Lab``
    | ``TES_Terrabomb``
    | ``QUA_Door_Hackable``
    | ``QUA_Door_Hackable_Hard``
    | ``Sigix Lab``
    | ``Sigix Quarantine Controls``
    | ``Sigix Quarantine Chamber``
    | ``Teleportation Lab``
    | ``Autopsy Lab``
    | ``Research Terminal``
    | ``SEC_Door_Hackable``
    | ``L2 Monitoring Station``
    | ``Power Cell Monitoring``
    | ``Thrusters``
    | ``SEC_L2_Power_Cell``
    | ``Wing Frame``
    | ``FTL Facilitator``
    | ``Core Housing``
    | ``Hull``
    | ``Armor Plating``
    | ``Navigation``
    | ``Construction Supplies``
    | ``L2 Fabricator``
    | ``Exoskeleton Controls``
    | ``Cave Seal Controls``
    | ``COM_Cave_Spawn``
    | ``COM_Shell_Shootable``
    | ``Access Lift``
    | ``COM_Teleport_Inhibitor``
    | ``COM_Door_Hackable``
    | ``COM_0b10_Conduit``
    | ``COM_Alternative_Access``
    | ``COM_Cache_Door``
    | ``AC0_Singularity_Gate``
    | ``Gate Controls``
    | ``AC0_Subspace_Node``
    | ``AC0_Subspace_Node_Mid``
    | ``AC0_Architect_Shell``
    | ``Architect Logs``
    | ``AC0_Abandoned_Machinery``
    | ``AC0_Shell_Shootable``
    | ``Analysis Chamber``
    | ``AC0_Workstation``
    | ``YRD_Black_Space``
    | ``YRD_New_Year_City``


let getProp =
    function
    | 0 -> Prop.``Concrete Rubble``
    | 1 -> Prop.``Metal Rubble``
    | 2 -> Prop.``Unfinished Machinery``
    | 3 -> Prop.``GENERIC_MACHINE_10``
    | 4 -> Prop.``GENERIC_MACHINE_9``
    | 5 -> Prop.``GENERIC_MACHINE_8``
    | 6 -> Prop.``GENERIC_MACHINE_7``
    | 7 -> Prop.``GENERIC_MACHINE_6``
    | 8 -> Prop.``GENERIC_MACHINE_5``
    | 9 -> Prop.``GENERIC_MACHINE_4``
    | 10 -> Prop.``GENERIC_MACHINE_3``
    | 11 -> Prop.``GENERIC_MACHINE_2``
    | 12 -> Prop.``GENERIC_MACHINE_1``
    | 13 -> Prop.``Terminal vFe_01a``
    | 14 -> Prop.``Terminal vNi_03a``
    | 15 -> Prop.``Terminal vCu_03a``
    | 16 -> Prop.``Terminal vZn_06a``
    | 17 -> Prop.``Terminal vAg_06a``
    | 18 -> Prop.``Terminal vTi_06n``
    | 19 -> Prop.``Terminal vCo_08n``
    | 20 -> Prop.``Terminal vMn_10n``
    | 21 -> Prop.``Terminal vMo_07n``
    | 22 -> Prop.``Terminal vPd_10n``
    | 23 -> Prop.``Terminal vCd_08n``
    | 24 -> Prop.``Terminal vZr_10n``
    | 25 -> Prop.``Terminal vY_10n``
    | 26 -> Prop.``Terminal vW_10x``
    | 27 -> Prop.``Terminal vIr_12x``
    | 28 -> Prop.``Terminal vPt_12x``
    | 29 -> Prop.``Terminal vAu_13x``
    | 30 -> Prop.``Terminal vHg_20x``
    | 31 -> Prop.``Terminal vRh_10x``
    | 32 -> Prop.``Fabricator vLi_07a``
    | 33 -> Prop.``Fabricator vNa_07a``
    | 34 -> Prop.``Fabricator vK_08a``
    | 35 -> Prop.``Fabricator vCs_10n``
    | 36 -> Prop.``Fabricator vBe_12n``
    | 37 -> Prop.``Fabricator vMg_13n``
    | 38 -> Prop.``Fabricator vCa_14x``
    | 39 -> Prop.``Fabricator vSr_14x``
    | 40 -> Prop.``Fabricator vBa_16x``
    | 41 -> Prop.``Fabricator vRa_19x``
    | 42 -> Prop.``Repair vAl_08a``
    | 43 -> Prop.``Repair vGa_08a``
    | 44 -> Prop.``Repair vIn_08a``
    | 45 -> Prop.``Repair vSn_08n``
    | 46 -> Prop.``Repair vTl_10n``
    | 47 -> Prop.``Repair vPb_11n``
    | 48 -> Prop.``Repair vBi_12x``
    | 49 -> Prop.``Repair vPo_13x``
    | 50 -> Prop.``Recycling vH_06a``
    | 51 -> Prop.``Recycling vN_06a``
    | 52 -> Prop.``Recycling vO_08n``
    | 53 -> Prop.``Recycling vF_08n``
    | 54 -> Prop.``Recycling vP_10x``
    | 55 -> Prop.``Recycling vI_14x``
    | 56 -> Prop.``Scanalyzer vHe_07a``
    | 57 -> Prop.``Scanalyzer vNe_13n``
    | 58 -> Prop.``Scanalyzer vAr_15x``
    | 59 -> Prop.``Scanalyzer vXe_13x``
    | 60 -> Prop.``Garrison vCe_6a``
    | 61 -> Prop.``Garrison vPr_8a``
    | 62 -> Prop.``Garrison vNd_9n``
    | 63 -> Prop.``Garrison vPm_7n``
    | 64 -> Prop.``Garrison vSm_13x``
    | 65 -> Prop.``Garrison vEu_9x``
    | 66 -> Prop.``T1``
    | 67 -> Prop.``Core Extractor``
    | 68 -> Prop.``Pulverizer``
    | 69 -> Prop.``Laser Drill``
    | 70 -> Prop.``Plasma Injector``
    | 71 -> Prop.``Seismic Survey Station``
    | 72 -> Prop.``Matter Pump``
    | 73 -> Prop.``Pressure Siphon``
    | 74 -> Prop.``Nuclear Reactor``
    | 75 -> Prop.``Neutrino Reactor``
    | 76 -> Prop.``Fusion Modulator``
    | 77 -> Prop.``Quantum Generator``
    | 78 -> Prop.``Dark Matter Chamber``
    | 79 -> Prop.``Hypermatter Reactor``
    | 80 -> Prop.``Compression Vault``
    | 81 -> Prop.``Component Storage``
    | 82 -> Prop.``Holding Depot``
    | 83 -> Prop.``Packing Station``
    | 84 -> Prop.``Arsenal Racks``
    | 85 -> Prop.``Extraspacial Lockers``
    | 86 -> Prop.``Energy Cycler``
    | 87 -> Prop.``Transport Mainframe``
    | 88 -> Prop.``Transfer Shaft``
    | 89 -> Prop.``Hadron Collector``
    | 90 -> Prop.``Electrolysis Chamber``
    | 91 -> Prop.``Processing Tank``
    | 92 -> Prop.``Atomic Centrifuge``
    | 93 -> Prop.``Purification Channel``
    | 94 -> Prop.``Integration Channel``
    | 95 -> Prop.``Material Processor``
    | 96 -> Prop.``Material Compactor``
    | 97 -> Prop.``Matter Filter``
    | 98 -> Prop.``Manufacturing Mainframe``
    | 99 -> Prop.``Construction Platform``
    | 100 -> Prop.``Assembly Bed``
    | 101 -> Prop.``Megafabricator``
    | 102 -> Prop.``Subcomponent Replicator``
    | 103 -> Prop.``Power Conduit``
    | 104 -> Prop.``Research Mainframe``
    | 105 -> Prop.``Antiparticle Reservoir``
    | 106 -> Prop.``Reaction Chamber``
    | 107 -> Prop.``Vacuum Chamber``
    | 108 -> Prop.``Subatomic Condenser``
    | 109 -> Prop.``Catalytron``
    | 110 -> Prop.``Meson Extractor``
    | 111 -> Prop.``Antimatter Diverter``
    | 112 -> Prop.``Field Manipulator``
    | 113 -> Prop.``Particle Synthesizer``
    | 114 -> Prop.``Quantum Separator``
    | 115 -> Prop.``Wave Intensifier``
    | 116 -> Prop.``Proton Scatter Basin``
    | 117 -> Prop.``Ion Accelerator``
    | 118 -> Prop.``Magnetic Photon System``
    | 119 -> Prop.``Hypercollider``
    | 120 -> Prop.``Graviton Restrictor``
    | 121 -> Prop.``Potential Refractor``
    | 122 -> Prop.``Prototyping Station``
    | 123 -> Prop.``Engineering Station``
    | 124 -> Prop.``Biostasis Chamber``
    | 125 -> Prop.``Organic Neutralizer``
    | 126 -> Prop.``Containment Shield``
    | 127 -> Prop.``Testing Mainframe``
    | 128 -> Prop.``Sonic Impulse Analyzer``
    | 129 -> Prop.``Field Warper``
    | 130 -> Prop.``Gravity Sphere``
    | 131 -> Prop.``Quantum Transformer``
    | 132 -> Prop.``Focalizer``
    | 133 -> Prop.``Phase Constrictor``
    | 134 -> Prop.``Resonance Scanner``
    | 135 -> Prop.``Tau Charger``
    | 136 -> Prop.``Harmonic Fracturing Unit``
    | 137 -> Prop.``Antiparticle Suffusor``
    | 138 -> Prop.``Thermocompressor Array``
    | 139 -> Prop.``Cryocooling Duct``
    | 140 -> Prop.``Artifact Storage``
    | 141 -> Prop.``Cryopreservation Unit``
    | 142 -> Prop.``Biostim Tank``
    | 143 -> Prop.``Quarantine Pod``
    | 144 -> Prop.``Aeration Cycler``
    | 145 -> Prop.``Deconstruction Unit``
    | 146 -> Prop.``Anatomizer``
    | 147 -> Prop.``Cloning Tubes``
    | 148 -> Prop.``Cell Assembler``
    | 149 -> Prop.``Molecular Binding Bank``
    | 150 -> Prop.``Anti-Ion Cluster``
    | 151 -> Prop.``Deuterium Array``
    | 152 -> Prop.``Mainframe``
    | 153 -> Prop.``Storage``
    | 154 -> Prop.``Retrofitting Station``
    | 155 -> Prop.``Signal Jammer``
    | 156 -> Prop.``Cloak Generator``
    | 157 -> Prop.``Decryption Engine``
    | 158 -> Prop.``Backup Mainframe``
    | 159 -> Prop.``Archive Unit``
    | 160 -> Prop.``Control Node``
    | 161 -> Prop.``Operations Mainframe``
    | 162 -> Prop.``Quantum Router``
    | 163 -> Prop.``Hyperwave Decoder``
    | 164 -> Prop.``Sealed Freight Elevator``
    | 165 -> Prop.``Radio-Gravity Array``
    | 166 -> Prop.``Anti-Orbital Battery``
    | 167 -> Prop.``Spectral Interrupter``
    | 168 -> Prop.``Wave Collapse Detector``
    | 169 -> Prop.``Signal Shield``
    | 170 -> Prop.``Longscan Aggregator``
    | 171 -> Prop.``Blade Trap``
    | 172 -> Prop.``Segregator Trap``
    | 173 -> Prop.``Explosive Trap``
    | 174 -> Prop.``Heavy Explosive Trap``
    | 175 -> Prop.``Tiamat Bomb Trap``
    | 176 -> Prop.``Fusion Bomb Trap``
    | 177 -> Prop.``Hellfire Trap``
    | 178 -> Prop.``Armageddon Trap``
    | 179 -> Prop.``Dirty Bomb Trap``
    | 180 -> Prop.``EMP Trap``
    | 181 -> Prop.``Proton Bomb Trap``
    | 182 -> Prop.``Tesla Bomb Trap``
    | 183 -> Prop.``Gamma Bomb Trap``
    | 184 -> Prop.``Shrapnel Trap``
    | 185 -> Prop.``Vortex Trap``
    | 186 -> Prop.``Piercing Trap``
    | 187 -> Prop.``Shock Trap``
    | 188 -> Prop.``EM Surge Trap``
    | 189 -> Prop.``Fire Trap``
    | 190 -> Prop.``Heat Bomb Trap``
    | 191 -> Prop.``Stasis Trap``
    | 192 -> Prop.``Alarm Trap``
    | 193 -> Prop.``Ambush Trap``
    | 194 -> Prop.``Chute Trap``
    | 195 -> Prop.``Collapsed Tunnel``
    | 197 -> Prop.``Door Terminal``
    | 198 -> Prop.``DSF Access``
    | 199 -> Prop.``Broken Shaft Lining``
    | 200 -> Prop.``XXX_Blast_Door_Open``
    | 201 -> Prop.``XXX_Blast_Door_Hackable``
    | 202 -> Prop.``ACC_Door_Shootable_SUR``
    | 203 -> Prop.``ACC_Door_Shootable_COM``
    | 204 -> Prop.``ACC_Door_Hackable``
    | 205 -> Prop.``ACC_Shell_Shootable``
    | 206 -> Prop.``Main Access Lift``
    | 208 -> Prop.``STO_Door_Open``
    | 209 -> Prop.``STO_Door_Hackable``
    | 210 -> Prop.``STO_Shell_Shootable``
    | 211 -> Prop.``Scraplab SEP``
    | 212 -> Prop.``Scrap Engine Manual``
    | 213 -> Prop.``Supplies``
    | 214 -> Prop.``C-Scrubber``
    | 215 -> Prop.``UFD Members``
    | 216 -> Prop.``UFD Registry``
    | 217 -> Prop.``UFD Projects``
    | 218 -> Prop.``0bPrime Members Only``
    | 219 -> Prop.``UFD Mainframe``
    | 220 -> Prop.``UFD HQ Gate``
    | 221 -> Prop.``Triangle Research``
    | 222 -> Prop.``SCR_Reading_Room_Door``
    | 223 -> Prop.``UFD Synopsis``
    | 224 -> Prop.``Book of Scrap``
    | 225 -> Prop.``Soloparser's Compendium``
    | 226 -> Prop.``General History``
    | 227 -> Prop.``Subcaves Research``
    | 228 -> Prop.``Sights of 0b1``
    | 229 -> Prop.``Notable Derelicts``
    | 230 -> Prop.``Western Derelicts``
    | 231 -> Prop.``Miscellany``
    | 232 -> Prop.``SCR_Enclosure``
    | 233 -> Prop.``Comm Apparatus``
    | 234 -> Prop.``Model Spaceship``
    | 235 -> Prop.``SCR_SOTW_Speaker``
    | 236 -> Prop.``SCR_Mechanic``
    | 237 -> Prop.``Lifeworm Database``
    | 238 -> Prop.``Replica Nuclear Reactor``
    | 239 -> Prop.``CP Mission Status``
    | 240 -> Prop.``Latest Submissions``
    | 241 -> Prop.``Demos``
    | 243 -> Prop.``Operating Theater``
    | 244 -> Prop.``SG-Prototypes Database``
    | 245 -> Prop.``0bJail``
    | 246 -> Prop.``IN-MT5's Safe``
    | 247 -> Prop.``0b10 Analyses``
    | 248 -> Prop.``JC Pilot Fab``
    | 249 -> Prop.``Cannon Storage``
    | 250 -> Prop.``SS Performance Data``
    | 251 -> Prop.``Super Scrap Suits``
    | 252 -> Prop.``Modified UFD Components``
    | 253 -> Prop.``Botcube Storage``
    | 254 -> Prop.``Sword Access``
    | 255 -> Prop.``GAR_Door_Shootable``
    | 256 -> Prop.``GAR_Relay``
    | 257 -> Prop.``GAR_Generator``
    | 258 -> Prop.``GAR_RIF_Installer``
    | 259 -> Prop.``Garrison Terminal``
    | 260 -> Prop.``GAR_Heavy_Assembler``
    | 261 -> Prop.``GAR_QS_Assembler``
    | 262 -> Prop.``SHOP_Sys``
    | 263 -> Prop.``MIN_Door_Hackable_Weak``
    | 264 -> Prop.``Assembled Analyzer``
    | 265 -> Prop.``Components``
    | 266 -> Prop.``Testing Chamber Shield``
    | 267 -> Prop.``Testing Apparatus``
    | 268 -> Prop.``EX-Generator``
    | 269 -> Prop.``BIN's Workstation``
    | 270 -> Prop.``DEC's Workstation``
    | 271 -> Prop.``HEX's Workstation``
    | 272 -> Prop.``BIN's Terminal``
    | 273 -> Prop.``DEC's Terminal``
    | 274 -> Prop.``HEX's Terminal``
    | 275 -> Prop.``EXI_Farcom``
    | 276 -> Prop.``EX-Vault Access``
    | 277 -> Prop.``EX-Prototypes Database``
    | 278 -> Prop.``EX-Message Board``
    | 279 -> Prop.``Repaired_Machine_T``
    | 280 -> Prop.``Repaired_Machine_F``
    | 281 -> Prop.``Repaired_Machine_R``
    | 282 -> Prop.``Repaired_Machine_Y``
    | 283 -> Prop.``Repaired_Machine_S``
    | 284 -> Prop.``Testing Chamber``
    | 285 -> Prop.``4L-MR0's Prototype Logs``
    | 286 -> Prop.``SUB_Autodoor``
    | 287 -> Prop.``Clippyterm``
    | 288 -> Prop.``Triangle-emblazoned Door``
    | 289 -> Prop.``UFD SUBCON Station``
    | 290 -> Prop.``Subatomizer Accumulator``
    | 291 -> Prop.``SUBCON Basin Controls``
    | 292 -> Prop.``WAR_Sys``
    | 293 -> Prop.``Prototyping Terminal``
    | 294 -> Prop.``CAV_Door_Hackable``
    | 295 -> Prop.``Outpost Terminal``
    | 296 -> Prop.``CAV_Base_Generator``
    | 297 -> Prop.``CAV_Junk_Machine``
    | 298 -> Prop.``CAV_Reinforcement``
    | 299 -> Prop.``CAV_Door_Shootable``
    | 300 -> Prop.``CAV_Door_No_Terminal``
    | 301 -> Prop.``Private``
    | 302 -> Prop.``CAV_Thief_Den``
    | 303 -> Prop.``W-Fans Enter Here``
    | 304 -> Prop.``LOW_Warlord_Fan_Stuff``
    | 305 -> Prop.``PRO_Base_Generator``
    | 306 -> Prop.``PRO_Target_Dispatcher``
    | 307 -> Prop.``PRO_Test_Aggregator``
    | 308 -> Prop.``PRO_Data_Receptor``
    | 309 -> Prop.``Matter Repository``
    | 310 -> Prop.``Twisting Tunnel``
    | 311 -> Prop.``DAT_Data_Conduit``
    | 312 -> Prop.``ORACLE Interface``
    | 313 -> Prop.``ZHI_Cloak_Generator``
    | 315 -> Prop.``ZHI_Main_Door``
    | 316 -> Prop.``Zhirov's Terminal``
    | 317 -> Prop.``Quantum Analyzer``
    | 318 -> Prop.``Zhirov's Workstation``
    | 319 -> Prop.``WAR_Door_Hackable``
    | 320 -> Prop.``Vortex Lab Terminal``
    | 321 -> Prop.``Hacking Lab Terminal``
    | 322 -> Prop.``Relay Lab Terminal``
    | 323 -> Prop.``Fabnet Lab Terminal``
    | 324 -> Prop.``Intel Room Terminal``
    | 325 -> Prop.``WAR_Staging_Area``
    | 326 -> Prop.``RES_Staging_Area``
    | 327 -> Prop.``WAR_Mainc_Tunnel``
    | 328 -> Prop.``ZIO_Machinery``
    | 329 -> Prop.``Deep Containment System``
    | 330 -> Prop.``ZIOWAR_Quarantine_Array``
    | 331 -> Prop.``ZIO_Cloak_Generator``
    | 332 -> Prop.``ZIO_Stockpile_Wall``
    | 333 -> Prop.``ZIO_Prototype_Hold``
    | 334 -> Prop.``ZIO_Lab_Wall``
    | 335 -> Prop.``ZIO_Repair_Shop_Wall``
    | 336 -> Prop.``Zion Terminal``
    | 337 -> Prop.``ZIO_Machinery_Fake``
    | 338 -> Prop.``Conduit Teleporter``
    | 339 -> Prop.``ZIO_Memory_Banks``
    | 340 -> Prop.``ZIO_Imprinter``
    | 341 -> Prop.``DEE_Z_Facility``
    | 342 -> Prop.``Z-Power``
    | 344 -> Prop.``DEE_Sigix_Wall``
    | 345 -> Prop.``DEE_Sigix_Gate``
    | 346 -> Prop.``DEE_Wall_Chamber``
    | 347 -> Prop.``DEE_Survey_Way_Station``
    | 348 -> Prop.``EXT_Door_Hackable``
    | 350 -> Prop.``EXT_Transfer_Station``
    | 351 -> Prop.``Cetus Terminal``
    | 352 -> Prop.``Cetus Manufacturing Controls``
    | 353 -> Prop.``CET_Door_Hackable``
    | 354 -> Prop.``Doors``
    | 355 -> Prop.``Bed``
    | 356 -> Prop.``Lockers``
    | 357 -> Prop.``Table``
    | 358 -> Prop.``Lab Station``
    | 359 -> Prop.``Research Interface``
    | 360 -> Prop.``Cetus Mainframe``
    | 361 -> Prop.``Cetus Manufacturing Module``
    | 362 -> Prop.``Archive Terminal``
    | 363 -> Prop.``Archive Hub``
    | 364 -> Prop.``HUB_Transfer_Station``
    | 365 -> Prop.``HUB_Network_Hub``
    | 366 -> Prop.``ARM_Door_Hackable``
    | 367 -> Prop.``ARM_Blast_Door_Hackable``
    | 368 -> Prop.``ARM_Shell_Shootable``
    | 369 -> Prop.``Derelict Superweapon?``
    | 370 -> Prop.``ARM_Dimension_Slip_Node``
    | 371 -> Prop.``NO ENTRY``
    | 372 -> Prop.``LAB_Door_Hackable``
    | 373 -> Prop.``Active System Cloaker``
    | 374 -> Prop.``A0 Command``
    | 375 -> Prop.``hN 3sDk7Qc``
    | 376 -> Prop.``A0 Storage 04-B``
    | 377 -> Prop.``UC xVqbSdU M7q4``
    | 378 -> Prop.``Suspension Chamber``
    | 380 -> Prop.``Blast Barrier``
    | 381 -> Prop.``TES_Door_Hackable``
    | 382 -> Prop.``TES_Shell_Shootable``
    | 383 -> Prop.``Regeneration Lab``
    | 384 -> Prop.``TES_Terrabomb``
    | 385 -> Prop.``QUA_Door_Hackable``
    | 386 -> Prop.``QUA_Door_Hackable_Hard``
    | 387 -> Prop.``Sigix Lab``
    | 388 -> Prop.``Sigix Quarantine Controls``
    | 389 -> Prop.``Sigix Quarantine Chamber``
    | 390 -> Prop.``Teleportation Lab``
    | 391 -> Prop.``Autopsy Lab``
    | 392 -> Prop.``Research Terminal``
    | 393 -> Prop.``SEC_Door_Hackable``
    | 394 -> Prop.``L2 Monitoring Station``
    | 395 -> Prop.``Power Cell Monitoring``
    | 396 -> Prop.``Thrusters``
    | 397 -> Prop.``SEC_L2_Power_Cell``
    | 398 -> Prop.``Wing Frame``
    | 399 -> Prop.``FTL Facilitator``
    | 400 -> Prop.``Core Housing``
    | 401 -> Prop.``Hull``
    | 402 -> Prop.``Armor Plating``
    | 403 -> Prop.``Navigation``
    | 404 -> Prop.``Construction Supplies``
    | 405 -> Prop.``L2 Fabricator``
    | 406 -> Prop.``Exoskeleton Controls``
    | 407 -> Prop.``Cave Seal Controls``
    | 408 -> Prop.``COM_Cave_Spawn``
    | 409 -> Prop.``COM_Shell_Shootable``
    | 410 -> Prop.``Access Lift``
    | 411 -> Prop.``COM_Teleport_Inhibitor``
    | 412 -> Prop.``COM_Door_Hackable``
    | 413 -> Prop.``COM_0b10_Conduit``
    | 414 -> Prop.``COM_Alternative_Access``
    | 416 -> Prop.``COM_Cache_Door``
    | 417 -> Prop.``AC0_Singularity_Gate``
    | 418 -> Prop.``Gate Controls``
    | 420 -> Prop.``AC0_Subspace_Node``
    | 421 -> Prop.``AC0_Subspace_Node_Mid``
    | 422 -> Prop.``AC0_Architect_Shell``
    | 423 -> Prop.``Architect Logs``
    | 424 -> Prop.``AC0_Abandoned_Machinery``
    | 425 -> Prop.``AC0_Shell_Shootable``
    | 426 -> Prop.``Analysis Chamber``
    | 427 -> Prop.``AC0_Workstation``
    | 428 -> Prop.``YRD_Black_Space``
    | 429 -> Prop.``YRD_New_Year_City``
    | x -> raise (System.ArgumentException(sprintf "Invalid value for prop type: %A" x))


[<RequireQualifiedAccess>]
type Entity =
    | ``Cogmind`` = 0
    | ``Drone`` = 1
    | ``Target Drone`` = 2
    | ``Mini Drone`` = 3
    | ``Mapping Drone`` = 4
    | ``Sensor Drone`` = 5
    | ``Hacking Drone`` = 6
    | ``Minesniffer Drone`` = 7
    | ``Decoy Drone`` = 8
    | ``Splice Drone`` = 9
    | ``Master Drone`` = 10
    | ``Advanced Drone`` = 11
    | ``Stealth Drone`` = 12
    | ``Trailblazer`` = 13
    | ``Thief Drone`` = 14
    | ``Army Drone`` = 15
    | ``Swarm Drone`` = 16
    | ``Combat Drone`` = 17
    | ``Assault Drone`` = 18
    | ``Bomb Drone`` = 19
    | ``Wardrone`` = 20
    | ``DAS Turret`` = 21
    | ``Autobeam Turret`` = 22
    | ``K-01 Serf`` = 23
    | ``U-05 Engineer`` = 24
    | ``T-07 Excavator`` = 25
    | ``A-02 Transporter`` = 26
    | ``A-15 Conveyor`` = 27
    | ``A-27 Freighter`` = 28
    | ``R-06 Scavenger`` = 29
    | ``R-10 Processor`` = 30
    | ``C-30 ARC`` = 31
    | ``M-14 Sweeper`` = 32
    | ``M-22 Extractor`` = 33
    | ``M-30 Cleanser`` = 34
    | ``M-13 Machinist`` = 35
    | ``M-28 Smith`` = 36
    | ``M-36 Artificer`` = 37
    | ``O-16 Technician`` = 38
    | ``O-24 Administrator`` = 39
    | ``O-32 Director`` = 40
    | ``N-00 Fly`` = 41
    | ``N-01 Spotter`` = 42
    | ``W-16 Scout`` = 43
    | ``W-25 Informer`` = 44
    | ``W-44 Eye`` = 45
    | ``S-10 Pest`` = 46
    | ``S-27 Virus`` = 47
    | ``S-43 Plague`` = 48
    | ``C-17 Slicer`` = 49
    | ``C-35 Carver`` = 50
    | ``C-57 Dissector`` = 51
    | ``E-15 Imp`` = 52
    | ``G-34 Mercenary`` = 53
    | ``G-47 Trooper`` = 54
    | ``G-50 Soldier`` = 55
    | ``G-67 Veteran`` = 56
    | ``G-73 Enforcer`` = 57
    | ``B-36 Bruiser`` = 58
    | ``B-48 Gladiator`` = 59
    | ``B-60 Warrior`` = 60
    | ``B-74 Champion`` = 61
    | ``L-31 Rogue`` = 62
    | ``L-41 Fighter`` = 63
    | ``L-61 Swordsman`` = 64
    | ``I-25 Savior`` = 65
    | ``I-36 Angel`` = 66
    | ``I-47 Archangel`` = 67
    | ``C-55 Analyst`` = 68
    | ``C-65 Expert`` = 69
    | ``Y-45 Defender`` = 70
    | ``Y-54 Guardian`` = 71
    | ``Y-64 Sentinel`` = 72
    | ``Y-72 Warden`` = 73
    | ``D-53 Grenadier`` = 74
    | ``D-63 Destroyer`` = 75
    | ``D-83 Annihilator`` = 76
    | ``X-57 Shotgunner`` = 77
    | ``X-62 Marksman`` = 78
    | ``X-67 Chaingunner`` = 79
    | ``X-72 Disruptor`` = 80
    | ``X-77 Beamer`` = 81
    | ``X-82 Rainmaker`` = 82
    | ``X-87 Electro`` = 83
    | ``H-55 Commando`` = 84
    | ``H-66 Slayer`` = 85
    | ``H-77 Assassin`` = 86
    | ``H-88 Terminator`` = 87
    | ``P-60 Hacker`` = 88
    | ``P-70 Sage`` = 89
    | ``P-80 Master`` = 90
    | ``H-61 Shepherd`` = 91
    | ``H-71 Marshal`` = 92
    | ``H-81 Overseer`` = 93
    | ``Q-Series`` = 94
    | ``B-75 Beast`` = 95
    | ``B-86 Titan`` = 96
    | ``B-90 Cyclops`` = 97
    | ``B-99 Colossus`` = 98
    | ``C-40 Crusher`` = 99
    | ``Cetus Guard`` = 100
    | ``Quarantine Guard`` = 101
    | ``Armor Guard`` = 102
    | ``S7 Guard`` = 103
    | ``M Guard`` = 104
    | ``M Shell_Atk`` = 105
    | ``M Shell_Def`` = 106
    | ``Enhanced Grunt`` = 107
    | ``Enhanced Sentry`` = 108
    | ``Enhanced Demolisher`` = 109
    | ``Enhanced Hunter`` = 110
    | ``Enhanced Programmer`` = 111
    | ``Enhanced Q-Series`` = 112
    | ``Lightning`` = 113
    | ``Tracker`` = 114
    | ``Combat Programmer`` = 115
    | ``Investigator`` = 116
    | ``Striker`` = 117
    | ``Executioner`` = 118
    | ``Superbehemoth`` = 119
    | ``Alpha 7`` = 120
    | ``Fortress`` = 121
    | ``LRC-V4`` = 122
    | ``LRC-V5`` = 123
    | ``LRC-V6`` = 124
    | ``P_Grunt`` = 125
    | ``P_Duelist`` = 126
    | ``P_Sentry`` = 127
    | ``P_Demolisher`` = 128
    | ``P_Specialist`` = 129
    | ``P_Hunter`` = 130
    | ``P_Programmer`` = 131
    | ``Artisan`` = 132
    | ``Cobbler`` = 133
    | ``Subdweller`` = 134
    | ``Bolteater`` = 135
    | ``Federalist`` = 136
    | ``Explorer`` = 137
    | ``Ranger`` = 138
    | ``Ranger_DRS`` = 139
    | ``Guru`` = 140
    | ``Scientist`` = 141
    | ``Scrapper_3`` = 142
    | ``Elite_4`` = 143
    | ``Scrapoid_3`` = 144
    | ``Scrapoid_6`` = 145
    | ``Scrapoid_8`` = 146
    | ``Mutated Botcube`` = 147
    | ``Large Mutated Botcube`` = 148
    | ``Wyrm Statue`` = 149
    | ``Zionite`` = 150
    | ``Z-Technician`` = 151
    | ``Z_Courier`` = 152
    | ``Z_Recon`` = 153
    | ``Z_Light_5`` = 154
    | ``Z_Light_7`` = 155
    | ``Z_Light_9`` = 156
    | ``Z_Heavy_5`` = 157
    | ``Z_Heavy_7`` = 158
    | ``Z_Heavy_9`` = 159
    | ``Z_Experiment_8`` = 160
    | ``Z_Experiment_10`` = 161
    | ``Assembler`` = 162
    | ``Assembled_4`` = 163
    | ``Assembled_7`` = 164
    | ``Golem_8`` = 165
    | ``Golem_0`` = 166
    | ``Decomposer`` = 167
    | ``Packrat`` = 168
    | ``Samaritan`` = 169
    | ``Tinkerer`` = 170
    | ``Demented`` = 171
    | ``Furnace`` = 172
    | ``Parasite`` = 173
    | ``Thief_5`` = 174
    | ``Thief_7`` = 175
    | ``Surgeon_4`` = 176
    | ``Surgeon_6`` = 177
    | ``Wasp_5`` = 178
    | ``Wasp_7`` = 179
    | ``Thug_5`` = 180
    | ``Thug_7`` = 181
    | ``Savage_5`` = 182
    | ``Savage_7`` = 183
    | ``Butcher_5`` = 184
    | ``Butcher_7`` = 185
    | ``Bouncer_7`` = 186
    | ``Martyr_5`` = 187
    | ``Martyr_7`` = 188
    | ``Guerilla_5`` = 189
    | ``Guerilla_7`` = 190
    | ``Wizard_5`` = 191
    | ``Wizard_7`` = 192
    | ``Marauder_6`` = 193
    | ``Marauder_8`` = 194
    | ``Fireman_5`` = 195
    | ``Fireman_7`` = 196
    | ``Mutant_5`` = 197
    | ``Mutant_6`` = 198
    | ``Mutant_7`` = 199
    | ``Mutant_8`` = 200
    | ``Infiltrator_6`` = 201
    | ``Infiltrator_7`` = 202
    | ``Infiltrator_8`` = 203
    | ``Sapper`` = 204
    | ``Commander`` = 205
    | ``Knight`` = 206
    | ``Troll`` = 207
    | ``Dragon`` = 208
    | ``Hydra`` = 209
    | ``Borebot`` = 210
    | ``8R-AWN`` = 211
    | ``EX-BIN`` = 212
    | ``EX-DEC`` = 213
    | ``EX-HEX`` = 214
    | ``YI-UF0`` = 215
    | ``01-MTF`` = 216
    | ``KN-7UR`` = 217
    | ``Warlord Statue`` = 218
    | ``Warbot`` = 219
    | ``5H-AD0`` = 220
    | ``Surveybot 24`` = 221
    | ``AZ-K3N`` = 222
    | ``HV-R5K`` = 223
    | ``7R-MNS`` = 224
    | ``VL-GR5`` = 225
    | ``LV-01A`` = 226
    | ``DD-05H`` = 227
    | ``Zion_Hero_01`` = 228
    | ``Zion_Hero_02`` = 229
    | ``Zion_Hero_03`` = 230
    | ``Zion_Hero_04`` = 231
    | ``Zion_Hero_05`` = 232
    | ``Zion_Hero_06`` = 233
    | ``Zion_Hero_07`` = 234
    | ``Zion_Hero_08`` = 235
    | ``Zion_Hero_09`` = 236
    | ``Revision`` = 237
    | ``Revision 17`` = 238
    | ``Revision 17__`` = 239
    | ``Imprinter`` = 240
    | ``Z-Imprinter`` = 241
    | ``Triborg_A`` = 242
    | ``A8`` = 243
    | ``A7`` = 244
    | ``A6`` = 245
    | ``A5`` = 246
    | ``A4`` = 247
    | ``A3`` = 248
    | ``A2`` = 249
    | ``Zhirov`` = 250
    | ``Perun`` = 251
    | ``Svarog`` = 252
    | ``Data Miner`` = 253
    | ``Fake_God_Mode`` = 254
    | ``God_Mode`` = 255
    | ``Warlord`` = 256
    | ``Warlord_B`` = 257
    | ``Warlord AM-PH4`` = 258
    | ``Warlord MG-163`` = 259
    | ``Warlord HL-1SK`` = 260
    | ``Warlord SH-K8T`` = 261
    | ``Warlord D3-CKR`` = 262
    | ``Warlord 4Z-XS3`` = 263
    | ``Warlord KY-Z71`` = 264
    | ``Sigix Containment Pod`` = 265
    | ``Sigix Exoskeleton`` = 266
    | ``Sigix Warrior`` = 267
    | ``MAINC_A`` = 268
    | ``MAINC_B`` = 269
    | ``Architect`` = 270
    | ``Anomaly`` = 271
    | ``Lesser Abomination`` = 272
    | ``Minor Abomination`` = 273
    | ``Greater Abomination`` = 274
    | ``Major Abomination`` = 275
    | ``Ultimate Abomination`` = 276
    | ``Final Abomination`` = 277
    | ``Player`` = 278
    | ``Player 2`` = 279
    | ``Sauler`` = 280
    | ``Elf`` = 281


let getEntity =
    function
    | 0 -> Entity.``Cogmind``
    | 1 -> Entity.``Drone``
    | 2 -> Entity.``Target Drone``
    | 3 -> Entity.``Mini Drone``
    | 4 -> Entity.``Mapping Drone``
    | 5 -> Entity.``Sensor Drone``
    | 6 -> Entity.``Hacking Drone``
    | 7 -> Entity.``Minesniffer Drone``
    | 8 -> Entity.``Decoy Drone``
    | 9 -> Entity.``Splice Drone``
    | 10 -> Entity.``Master Drone``
    | 11 -> Entity.``Advanced Drone``
    | 12 -> Entity.``Stealth Drone``
    | 13 -> Entity.``Trailblazer``
    | 14 -> Entity.``Thief Drone``
    | 15 -> Entity.``Army Drone``
    | 16 -> Entity.``Swarm Drone``
    | 17 -> Entity.``Combat Drone``
    | 18 -> Entity.``Assault Drone``
    | 19 -> Entity.``Bomb Drone``
    | 20 -> Entity.``Wardrone``
    | 21 -> Entity.``DAS Turret``
    | 22 -> Entity.``Autobeam Turret``
    | 23 -> Entity.``K-01 Serf``
    | 24 -> Entity.``U-05 Engineer``
    | 25 -> Entity.``T-07 Excavator``
    | 26 -> Entity.``A-02 Transporter``
    | 27 -> Entity.``A-15 Conveyor``
    | 28 -> Entity.``A-27 Freighter``
    | 29 -> Entity.``R-06 Scavenger``
    | 30 -> Entity.``R-10 Processor``
    | 31 -> Entity.``C-30 ARC``
    | 32 -> Entity.``M-14 Sweeper``
    | 33 -> Entity.``M-22 Extractor``
    | 34 -> Entity.``M-30 Cleanser``
    | 35 -> Entity.``M-13 Machinist``
    | 36 -> Entity.``M-28 Smith``
    | 37 -> Entity.``M-36 Artificer``
    | 38 -> Entity.``O-16 Technician``
    | 39 -> Entity.``O-24 Administrator``
    | 40 -> Entity.``O-32 Director``
    | 41 -> Entity.``N-00 Fly``
    | 42 -> Entity.``N-01 Spotter``
    | 43 -> Entity.``W-16 Scout``
    | 44 -> Entity.``W-25 Informer``
    | 45 -> Entity.``W-44 Eye``
    | 46 -> Entity.``S-10 Pest``
    | 47 -> Entity.``S-27 Virus``
    | 48 -> Entity.``S-43 Plague``
    | 49 -> Entity.``C-17 Slicer``
    | 50 -> Entity.``C-35 Carver``
    | 51 -> Entity.``C-57 Dissector``
    | 52 -> Entity.``E-15 Imp``
    | 53 -> Entity.``G-34 Mercenary``
    | 54 -> Entity.``G-47 Trooper``
    | 55 -> Entity.``G-50 Soldier``
    | 56 -> Entity.``G-67 Veteran``
    | 57 -> Entity.``G-73 Enforcer``
    | 58 -> Entity.``B-36 Bruiser``
    | 59 -> Entity.``B-48 Gladiator``
    | 60 -> Entity.``B-60 Warrior``
    | 61 -> Entity.``B-74 Champion``
    | 62 -> Entity.``L-31 Rogue``
    | 63 -> Entity.``L-41 Fighter``
    | 64 -> Entity.``L-61 Swordsman``
    | 65 -> Entity.``I-25 Savior``
    | 66 -> Entity.``I-36 Angel``
    | 67 -> Entity.``I-47 Archangel``
    | 68 -> Entity.``C-55 Analyst``
    | 69 -> Entity.``C-65 Expert``
    | 70 -> Entity.``Y-45 Defender``
    | 71 -> Entity.``Y-54 Guardian``
    | 72 -> Entity.``Y-64 Sentinel``
    | 73 -> Entity.``Y-72 Warden``
    | 74 -> Entity.``D-53 Grenadier``
    | 75 -> Entity.``D-63 Destroyer``
    | 76 -> Entity.``D-83 Annihilator``
    | 77 -> Entity.``X-57 Shotgunner``
    | 78 -> Entity.``X-62 Marksman``
    | 79 -> Entity.``X-67 Chaingunner``
    | 80 -> Entity.``X-72 Disruptor``
    | 81 -> Entity.``X-77 Beamer``
    | 82 -> Entity.``X-82 Rainmaker``
    | 83 -> Entity.``X-87 Electro``
    | 84 -> Entity.``H-55 Commando``
    | 85 -> Entity.``H-66 Slayer``
    | 86 -> Entity.``H-77 Assassin``
    | 87 -> Entity.``H-88 Terminator``
    | 88 -> Entity.``P-60 Hacker``
    | 89 -> Entity.``P-70 Sage``
    | 90 -> Entity.``P-80 Master``
    | 91 -> Entity.``H-61 Shepherd``
    | 92 -> Entity.``H-71 Marshal``
    | 93 -> Entity.``H-81 Overseer``
    | 94 -> Entity.``Q-Series``
    | 95 -> Entity.``B-75 Beast``
    | 96 -> Entity.``B-86 Titan``
    | 97 -> Entity.``B-90 Cyclops``
    | 98 -> Entity.``B-99 Colossus``
    | 99 -> Entity.``C-40 Crusher``
    | 100 -> Entity.``Cetus Guard``
    | 101 -> Entity.``Quarantine Guard``
    | 102 -> Entity.``Armor Guard``
    | 103 -> Entity.``S7 Guard``
    | 104 -> Entity.``M Guard``
    | 105 -> Entity.``M Shell_Atk``
    | 106 -> Entity.``M Shell_Def``
    | 107 -> Entity.``Enhanced Grunt``
    | 108 -> Entity.``Enhanced Sentry``
    | 109 -> Entity.``Enhanced Demolisher``
    | 110 -> Entity.``Enhanced Hunter``
    | 111 -> Entity.``Enhanced Programmer``
    | 112 -> Entity.``Enhanced Q-Series``
    | 113 -> Entity.``Lightning``
    | 114 -> Entity.``Tracker``
    | 115 -> Entity.``Combat Programmer``
    | 116 -> Entity.``Investigator``
    | 117 -> Entity.``Striker``
    | 118 -> Entity.``Executioner``
    | 119 -> Entity.``Superbehemoth``
    | 120 -> Entity.``Alpha 7``
    | 121 -> Entity.``Fortress``
    | 122 -> Entity.``LRC-V4``
    | 123 -> Entity.``LRC-V5``
    | 124 -> Entity.``LRC-V6``
    | 125 -> Entity.``P_Grunt``
    | 126 -> Entity.``P_Duelist``
    | 127 -> Entity.``P_Sentry``
    | 128 -> Entity.``P_Demolisher``
    | 129 -> Entity.``P_Specialist``
    | 130 -> Entity.``P_Hunter``
    | 131 -> Entity.``P_Programmer``
    | 132 -> Entity.``Artisan``
    | 133 -> Entity.``Cobbler``
    | 134 -> Entity.``Subdweller``
    | 135 -> Entity.``Bolteater``
    | 136 -> Entity.``Federalist``
    | 137 -> Entity.``Explorer``
    | 138 -> Entity.``Ranger``
    | 139 -> Entity.``Ranger_DRS``
    | 140 -> Entity.``Guru``
    | 141 -> Entity.``Scientist``
    | 142 -> Entity.``Scrapper_3``
    | 143 -> Entity.``Elite_4``
    | 144 -> Entity.``Scrapoid_3``
    | 145 -> Entity.``Scrapoid_6``
    | 146 -> Entity.``Scrapoid_8``
    | 147 -> Entity.``Mutated Botcube``
    | 148 -> Entity.``Large Mutated Botcube``
    | 149 -> Entity.``Wyrm Statue``
    | 150 -> Entity.``Zionite``
    | 151 -> Entity.``Z-Technician``
    | 152 -> Entity.``Z_Courier``
    | 153 -> Entity.``Z_Recon``
    | 154 -> Entity.``Z_Light_5``
    | 155 -> Entity.``Z_Light_7``
    | 156 -> Entity.``Z_Light_9``
    | 157 -> Entity.``Z_Heavy_5``
    | 158 -> Entity.``Z_Heavy_7``
    | 159 -> Entity.``Z_Heavy_9``
    | 160 -> Entity.``Z_Experiment_8``
    | 161 -> Entity.``Z_Experiment_10``
    | 162 -> Entity.``Assembler``
    | 163 -> Entity.``Assembled_4``
    | 164 -> Entity.``Assembled_7``
    | 165 -> Entity.``Golem_8``
    | 166 -> Entity.``Golem_0``
    | 167 -> Entity.``Decomposer``
    | 168 -> Entity.``Packrat``
    | 169 -> Entity.``Samaritan``
    | 170 -> Entity.``Tinkerer``
    | 171 -> Entity.``Demented``
    | 172 -> Entity.``Furnace``
    | 173 -> Entity.``Parasite``
    | 174 -> Entity.``Thief_5``
    | 175 -> Entity.``Thief_7``
    | 176 -> Entity.``Surgeon_4``
    | 177 -> Entity.``Surgeon_6``
    | 178 -> Entity.``Wasp_5``
    | 179 -> Entity.``Wasp_7``
    | 180 -> Entity.``Thug_5``
    | 181 -> Entity.``Thug_7``
    | 182 -> Entity.``Savage_5``
    | 183 -> Entity.``Savage_7``
    | 184 -> Entity.``Butcher_5``
    | 185 -> Entity.``Butcher_7``
    | 186 -> Entity.``Bouncer_7``
    | 187 -> Entity.``Martyr_5``
    | 188 -> Entity.``Martyr_7``
    | 189 -> Entity.``Guerilla_5``
    | 190 -> Entity.``Guerilla_7``
    | 191 -> Entity.``Wizard_5``
    | 192 -> Entity.``Wizard_7``
    | 193 -> Entity.``Marauder_6``
    | 194 -> Entity.``Marauder_8``
    | 195 -> Entity.``Fireman_5``
    | 196 -> Entity.``Fireman_7``
    | 197 -> Entity.``Mutant_5``
    | 198 -> Entity.``Mutant_6``
    | 199 -> Entity.``Mutant_7``
    | 200 -> Entity.``Mutant_8``
    | 201 -> Entity.``Infiltrator_6``
    | 202 -> Entity.``Infiltrator_7``
    | 203 -> Entity.``Infiltrator_8``
    | 204 -> Entity.``Sapper``
    | 205 -> Entity.``Commander``
    | 206 -> Entity.``Knight``
    | 207 -> Entity.``Troll``
    | 208 -> Entity.``Dragon``
    | 209 -> Entity.``Hydra``
    | 210 -> Entity.``Borebot``
    | 211 -> Entity.``8R-AWN``
    | 212 -> Entity.``EX-BIN``
    | 213 -> Entity.``EX-DEC``
    | 214 -> Entity.``EX-HEX``
    | 215 -> Entity.``YI-UF0``
    | 216 -> Entity.``01-MTF``
    | 217 -> Entity.``KN-7UR``
    | 218 -> Entity.``Warlord Statue``
    | 219 -> Entity.``Warbot``
    | 220 -> Entity.``5H-AD0``
    | 221 -> Entity.``Surveybot 24``
    | 222 -> Entity.``AZ-K3N``
    | 223 -> Entity.``HV-R5K``
    | 224 -> Entity.``7R-MNS``
    | 225 -> Entity.``VL-GR5``
    | 226 -> Entity.``LV-01A``
    | 227 -> Entity.``DD-05H``
    | 228 -> Entity.``Zion_Hero_01``
    | 229 -> Entity.``Zion_Hero_02``
    | 230 -> Entity.``Zion_Hero_03``
    | 231 -> Entity.``Zion_Hero_04``
    | 232 -> Entity.``Zion_Hero_05``
    | 233 -> Entity.``Zion_Hero_06``
    | 234 -> Entity.``Zion_Hero_07``
    | 235 -> Entity.``Zion_Hero_08``
    | 236 -> Entity.``Zion_Hero_09``
    | 237 -> Entity.``Revision``
    | 238 -> Entity.``Revision 17``
    | 239 -> Entity.``Revision 17__``
    | 240 -> Entity.``Imprinter``
    | 241 -> Entity.``Z-Imprinter``
    | 242 -> Entity.``Triborg_A``
    | 243 -> Entity.``A8``
    | 244 -> Entity.``A7``
    | 245 -> Entity.``A6``
    | 246 -> Entity.``A5``
    | 247 -> Entity.``A4``
    | 248 -> Entity.``A3``
    | 249 -> Entity.``A2``
    | 250 -> Entity.``Zhirov``
    | 251 -> Entity.``Perun``
    | 252 -> Entity.``Svarog``
    | 253 -> Entity.``Data Miner``
    | 254 -> Entity.``Fake_God_Mode``
    | 255 -> Entity.``God_Mode``
    | 256 -> Entity.``Warlord``
    | 257 -> Entity.``Warlord_B``
    | 258 -> Entity.``Warlord AM-PH4``
    | 259 -> Entity.``Warlord MG-163``
    | 260 -> Entity.``Warlord HL-1SK``
    | 261 -> Entity.``Warlord SH-K8T``
    | 262 -> Entity.``Warlord D3-CKR``
    | 263 -> Entity.``Warlord 4Z-XS3``
    | 264 -> Entity.``Warlord KY-Z71``
    | 265 -> Entity.``Sigix Containment Pod``
    | 266 -> Entity.``Sigix Exoskeleton``
    | 267 -> Entity.``Sigix Warrior``
    | 268 -> Entity.``MAINC_A``
    | 269 -> Entity.``MAINC_B``
    | 270 -> Entity.``Architect``
    | 271 -> Entity.``Anomaly``
    | 272 -> Entity.``Lesser Abomination``
    | 273 -> Entity.``Minor Abomination``
    | 274 -> Entity.``Greater Abomination``
    | 275 -> Entity.``Major Abomination``
    | 276 -> Entity.``Ultimate Abomination``
    | 277 -> Entity.``Final Abomination``
    | 278 -> Entity.``Player``
    | 279 -> Entity.``Player 2``
    | 280 -> Entity.``Sauler``
    | 281 -> Entity.``Elf``
    | x -> raise (System.ArgumentException(sprintf "Invalid value for entity type: %A" x))

/// Represents the location in-world
type MapType =
    | MAP_NONE = 0
    | MAP_SAN = -1
    | MAP_SCR = 1
    | MAP_MAT = 2
    | MAP_FAC = 3
    | MAP_RES = 4
    | MAP_ACC = 5
    | MAP_SUR = 6
    | MAP_MIN = 7
    | MAP_EXI = 8
    | MAP_STO = 9
    | MAP_REC = 10
    | MAP_WAS = 11
    | MAP_GAR = 12
    | MAP_DSF = 13
    | MAP_SUB = 14
    | MAP_LOW = 15
    | MAP_UPP = 16
    | MAP_PRO = 17
    | MAP_DEE = 18
    | MAP_ZIO = 19
    | MAP_DAT = 20
    | MAP_ZHI = 21
    | MAP_WAR = 22
    | MAP_EXT = 23
    | MAP_CET = 24
    | MAP_ARC = 25
    | MAP_HUB = 26
    | MAP_ARM = 27
    | MAP_LAB = 28
    | MAP_QUA = 29
    | MAP_TES = 30
    | MAP_SEC = 31
    | MAP_COM = 32
    | MAP_AC0 = 33
    | MAP_LAI = 34
    | MAP_TOW = 35
    | MAP_W00 = 1000
    | MAP_W01 = 1001
    | MAP_W02 = 1002
    | MAP_W03 = 1003
    | MAP_W04 = 1004
    | MAP_W05 = 1005
    | MAP_W06 = 1006
    | MAP_W07 = 1007
    | MAP_W08 = 1008

/// Converts raw Cogmind memory to in-world location data
let liftMapType =
    function
    | 1 -> MapType.MAP_SAN
    | 2 -> MapType.MAP_SCR
    | 3 -> MapType.MAP_MAT
    | 4 -> MapType.MAP_FAC
    | 5 -> MapType.MAP_RES
    | 6 -> MapType.MAP_ACC
    | 7 -> MapType.MAP_SUR
    | 8 -> MapType.MAP_MIN
    | 9 -> MapType.MAP_EXI
    | 10 -> MapType.MAP_STO
    | 11 -> MapType.MAP_REC
    | 12 -> MapType.MAP_WAS
    | 13 -> MapType.MAP_GAR
    | 35 -> MapType.MAP_DSF
    | 14 -> MapType.MAP_LOW
    | 15 -> MapType.MAP_UPP
    | 16 -> MapType.MAP_PRO
    | 17 -> MapType.MAP_DEE
    | 18 -> MapType.MAP_ZIO
    | 19 -> MapType.MAP_DAT
    | 20 -> MapType.MAP_ZHI
    | 21 -> MapType.MAP_WAR
    | 22 -> MapType.MAP_EXT
    | 23 -> MapType.MAP_CET
    | 24 -> MapType.MAP_ARC
    | 25 -> MapType.MAP_HUB
    | 26 -> MapType.MAP_ARM
    | 27 -> MapType.MAP_LAB
    | 28 -> MapType.MAP_QUA
    | 29 -> MapType.MAP_TES
    | 30 -> MapType.MAP_SEC
    | 31 -> MapType.MAP_COM
    | 32 -> MapType.MAP_AC0
    | 33 -> MapType.MAP_LAI
    | 34 -> MapType.MAP_TOW
    | 1000 -> MapType.MAP_W00
    | 1001 -> MapType.MAP_W01
    | 1002 -> MapType.MAP_W02
    | 1003 -> MapType.MAP_W03
    | 1004 -> MapType.MAP_W04
    | 1005 -> MapType.MAP_W05
    | 1006 -> MapType.MAP_W06
    | 1007 -> MapType.MAP_W07
    | 1008 -> MapType.MAP_W08
    | _ -> MapType.MAP_NONE
