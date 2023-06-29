module WalkMind.Domain


type cell =
    | ``NO_CELL`` = -1
    | ``EARTH`` = 0
    | ``EARTH_EXC`` = 1
    | ``GROUND`` = 2
    | ``FLOOR_SAN`` = 3
    | ``FLOOR_JUN`` = 4
    | ``FLOOR_MAT`` = 5
    | ``FLOOR_FAC`` = 6
    | ``FLOOR_RES`` = 7
    | ``FLOOR_ACC`` = 8
    | ``FLOOR_SUR`` = 9
    | ``FLOOR_MIN`` = 10
    | ``FLOOR_EXI`` = 11
    | ``FLOOR_STO`` = 12
    | ``FLOOR_REC`` = 13
    | ``FLOOR_WAS`` = 14
    | ``FLOOR_GAR`` = 15
    | ``FLOOR_DSF`` = 16
    | ``FLOOR_SUB`` = 17
    | ``FLOOR_LOW`` = 18
    | ``FLOOR_UPP`` = 19
    | ``FLOOR_PRO`` = 20
    | ``FLOOR_DEE`` = 21
    | ``FLOOR_ZIO`` = 22
    | ``FLOOR_DAT`` = 23
    | ``FLOOR_ZHI`` = 24
    | ``FLOOR_WAR`` = 25
    | ``FLOOR_EXT`` = 26
    | ``FLOOR_CET`` = 27
    | ``FLOOR_ARC`` = 28
    | ``FLOOR_HUB`` = 29
    | ``FLOOR_ARM`` = 30
    | ``FLOOR_LAB`` = 31
    | ``FLOOR_QUA`` = 32
    | ``FLOOR_TES`` = 33
    | ``FLOOR_SEC`` = 34
    | ``FLOOR_COM`` = 35
    | ``FLOOR_AC0`` = 36
    | ``FLOOR_LAI`` = 37
    | ``FLOOR_TOW`` = 38
    | ``TEMP_WALL`` = 39
    | ``WALL_SAN`` = 40
    | ``WALL_JUN`` = 41
    | ``WALL_MAT`` = 42
    | ``WALL_FAC`` = 43
    | ``WALL_RES`` = 44
    | ``WALL_ACC`` = 45
    | ``WALL_SUR`` = 46
    | ``WALL_MIN`` = 47
    | ``WALL_EXI`` = 48
    | ``WALL_STO`` = 49
    | ``WALL_REC`` = 50
    | ``WALL_WAS`` = 51
    | ``WALL_GAR`` = 52
    | ``WALL_DSF`` = 53
    | ``WALL_SUB`` = 54
    | ``WALL_LOW`` = 55
    | ``WALL_UPP`` = 56
    | ``WALL_PRO`` = 57
    | ``WALL_DEE`` = 58
    | ``WALL_ZIO`` = 59
    | ``WALL_DAT`` = 60
    | ``WALL_ZHI`` = 61
    | ``WALL_WAR`` = 62
    | ``WALL_EXT`` = 63
    | ``WALL_CET`` = 64
    | ``WALL_ARC`` = 65
    | ``WALL_HUB`` = 66
    | ``WALL_ARM`` = 67
    | ``WALL_LAB`` = 68
    | ``WALL_QUA`` = 69
    | ``WALL_TES`` = 70
    | ``WALL_SEC`` = 71
    | ``WALL_COM`` = 72
    | ``WALL_AC0`` = 73
    | ``WALL_LAI`` = 74
    | ``WALL_TOW`` = 75
    | ``BARRIER_SAN`` = 76
    | ``BARRIER_JUN`` = 77
    | ``BARRIER_MAT`` = 78
    | ``BARRIER_FAC`` = 79
    | ``BARRIER_RES`` = 80
    | ``BARRIER_ACC`` = 81
    | ``BARRIER_SUR`` = 82
    | ``BARRIER_MIN`` = 83
    | ``BARRIER_EXI`` = 84
    | ``BARRIER_STO`` = 85
    | ``BARRIER_REC`` = 86
    | ``BARRIER_WAS`` = 87
    | ``BARRIER_GAR`` = 88
    | ``BARRIER_DSF`` = 89
    | ``BARRIER_SUB`` = 90
    | ``BARRIER_LOW`` = 91
    | ``BARRIER_UPP`` = 92
    | ``BARRIER_PRO`` = 93
    | ``BARRIER_DEE`` = 94
    | ``BARRIER_ZIO`` = 95
    | ``BARRIER_DAT`` = 96
    | ``BARRIER_ZHI`` = 97
    | ``BARRIER_WAR`` = 98
    | ``BARRIER_EXT`` = 99
    | ``BARRIER_CET`` = 100
    | ``BARRIER_ARC`` = 101
    | ``BARRIER_HUB`` = 102
    | ``BARRIER_ARM`` = 103
    | ``BARRIER_LAB`` = 104
    | ``BARRIER_QUA`` = 105
    | ``BARRIER_TES`` = 106
    | ``BARRIER_SEC`` = 107
    | ``BARRIER_COM`` = 108
    | ``BARRIER_AC0`` = 109
    | ``BARRIER_LAI`` = 110
    | ``BARRIER_TOW`` = 111
    | ``SHORTCUT_SAN`` = 112
    | ``SHORTCUT_JUN`` = 113
    | ``SHORTCUT_MAT`` = 114
    | ``SHORTCUT_FAC`` = 115
    | ``SHORTCUT_RES`` = 116
    | ``SHORTCUT_ACC`` = 117
    | ``SHORTCUT_SUR`` = 118
    | ``SHORTCUT_MIN`` = 119
    | ``SHORTCUT_EXI`` = 120
    | ``SHORTCUT_STO`` = 121
    | ``SHORTCUT_REC`` = 122
    | ``SHORTCUT_WAS`` = 123
    | ``SHORTCUT_GAR`` = 124
    | ``SHORTCUT_DSF`` = 125
    | ``SHORTCUT_SUB`` = 126
    | ``SHORTCUT_LOW`` = 127
    | ``SHORTCUT_UPP`` = 128
    | ``SHORTCUT_PRO`` = 129
    | ``SHORTCUT_DEE`` = 130
    | ``SHORTCUT_ZIO`` = 131
    | ``SHORTCUT_DAT`` = 132
    | ``SHORTCUT_ZHI`` = 133
    | ``SHORTCUT_WAR`` = 134
    | ``SHORTCUT_EXT`` = 135
    | ``SHORTCUT_CET`` = 136
    | ``SHORTCUT_ARC`` = 137
    | ``SHORTCUT_HUB`` = 138
    | ``SHORTCUT_ARM`` = 139
    | ``SHORTCUT_LAB`` = 140
    | ``SHORTCUT_QUA`` = 141
    | ``SHORTCUT_TES`` = 142
    | ``SHORTCUT_SEC`` = 143
    | ``SHORTCUT_COM`` = 144
    | ``SHORTCUT_AC0`` = 145
    | ``SHORTCUT_LAI`` = 146
    | ``SHORTCUT_TOW`` = 147
    | ``SHORTCUT_KNOWN`` = 148
    | ``PHASEWALL_SAN`` = 149
    | ``PHASEWALL_JUN`` = 150
    | ``PHASEWALL_MAT`` = 151
    | ``PHASEWALL_FAC`` = 152
    | ``PHASEWALL_RES`` = 153
    | ``PHASEWALL_ACC`` = 154
    | ``PHASEWALL_SUR`` = 155
    | ``PHASEWALL_MIN`` = 156
    | ``PHASEWALL_EXI`` = 157
    | ``PHASEWALL_STO`` = 158
    | ``PHASEWALL_REC`` = 159
    | ``PHASEWALL_WAS`` = 160
    | ``PHASEWALL_GAR`` = 161
    | ``PHASEWALL_DSF`` = 162
    | ``PHASEWALL_SUB`` = 163
    | ``PHASEWALL_LOW`` = 164
    | ``PHASEWALL_UPP`` = 165
    | ``PHASEWALL_PRO`` = 166
    | ``PHASEWALL_DEE`` = 167
    | ``PHASEWALL_ZIO`` = 168
    | ``PHASEWALL_DAT`` = 169
    | ``PHASEWALL_ZHI`` = 170
    | ``PHASEWALL_WAR`` = 171
    | ``PHASEWALL_EXT`` = 172
    | ``PHASEWALL_CET`` = 173
    | ``PHASEWALL_ARC`` = 174
    | ``PHASEWALL_HUB`` = 175
    | ``PHASEWALL_ARM`` = 176
    | ``PHASEWALL_LAB`` = 177
    | ``PHASEWALL_QUA`` = 178
    | ``PHASEWALL_TES`` = 179
    | ``PHASEWALL_SEC`` = 180
    | ``PHASEWALL_COM`` = 181
    | ``PHASEWALL_AC0`` = 182
    | ``PHASEWALL_LAI`` = 183
    | ``PHASEWALL_TOW`` = 184
    | ``PHASEWALL_KNOWN`` = 185
    | ``SEALED_DOOR`` = 186
    | ``DOOR_SAN`` = 187
    | ``DOOR_JUN`` = 188
    | ``DOOR_MAT`` = 189
    | ``DOOR_FAC`` = 190
    | ``DOOR_RES`` = 191
    | ``DOOR_ACC`` = 192
    | ``DOOR_SUR`` = 193
    | ``DOOR_MIN`` = 194
    | ``DOOR_EXI`` = 195
    | ``DOOR_STO`` = 196
    | ``DOOR_REC`` = 197
    | ``DOOR_WAS`` = 198
    | ``DOOR_GAR`` = 199
    | ``DOOR_DSF`` = 200
    | ``DOOR_SUB`` = 201
    | ``DOOR_LOW`` = 202
    | ``DOOR_UPP`` = 203
    | ``DOOR_PRO`` = 204
    | ``DOOR_DEE`` = 205
    | ``DOOR_ZIO`` = 206
    | ``DOOR_DAT`` = 207
    | ``DOOR_ZHI`` = 208
    | ``DOOR_WAR`` = 209
    | ``DOOR_EXT`` = 210
    | ``DOOR_CET`` = 211
    | ``DOOR_ARC`` = 212
    | ``DOOR_HUB`` = 213
    | ``DOOR_ARM`` = 214
    | ``DOOR_LAB`` = 215
    | ``DOOR_QUA`` = 216
    | ``DOOR_TES`` = 217
    | ``DOOR_SEC`` = 218
    | ``DOOR_COM`` = 219
    | ``DOOR_AC0`` = 220
    | ``DOOR_LAI`` = 221
    | ``DOOR_TOW`` = 222
    | ``STAIRS_SAN`` = 223
    | ``STAIRS_JUN`` = 224
    | ``STAIRS_MAT`` = 225
    | ``STAIRS_FAC`` = 226
    | ``STAIRS_RES`` = 227
    | ``STAIRS_SUR`` = 228
    | ``STAIRS_ACC`` = 229
    | ``STAIRS_MIN`` = 230
    | ``STAIRS_EXI`` = 231
    | ``STAIRS_STO`` = 232
    | ``STAIRS_REC`` = 233
    | ``STAIRS_WAS`` = 234
    | ``STAIRS_GAR`` = 235
    | ``STAIRS_DSF`` = 236
    | ``STAIRS_SUB`` = 237
    | ``STAIRS_LOW`` = 238
    | ``STAIRS_UPP`` = 239
    | ``STAIRS_PRO`` = 240
    | ``STAIRS_DEE`` = 241
    | ``STAIRS_ZIO`` = 242
    | ``STAIRS_DAT`` = 243
    | ``STAIRS_ZHI`` = 244
    | ``STAIRS_WAR`` = 245
    | ``STAIRS_EXT`` = 246
    | ``STAIRS_CET`` = 247
    | ``STAIRS_ARC`` = 248
    | ``STAIRS_HUB`` = 249
    | ``STAIRS_ARM`` = 250
    | ``STAIRS_LAB`` = 251
    | ``STAIRS_QUA`` = 252
    | ``STAIRS_TES`` = 253
    | ``STAIRS_SEC`` = 254
    | ``STAIRS_COM`` = 255
    | ``STAIRS_AC0`` = 256
    | ``STAIRS_LAI`` = 257
    | ``STAIRS_TOW`` = 258
    | ``STAIRS_NOACCESS`` = 259
    | ``STAIRS_BLOCKED`` = 260
    | ``STAIRS_GAR_OPEN`` = 261
    | ``STAIRS_DSF_OPEN`` = 262
    | ``STAIRS_SHORTCUT`` = 263

[<RequireQualifiedAccess>]
type Item =
    | ``Matter``
    | ``Data Core``
    | ``Derelict Log``
    | ``Schematic Archive``
    | ``Imprinter Data Core``
    | ``A2 Data Core``
    | ``A7 Data Core``
    | ``MAIN_C Data Core``
    | ``Architect Data Core``
    | ``Scrap``
    | ``Protomatter``
    | ``Ion Engine``
    | ``Lgt_ Ion Engine``
    | ``Backup Power I``
    | ``Imp_ Ion Engine``
    | ``Rnf_ Ion Engine``
    | ``Hvy_ Ion Engine``
    | ``Cld_ Ion Engine``
    | ``Sub_ Power Source``
    | ``Deuterium Engine``
    | ``Lgt_ Deuterium Engine``
    | ``Backup Power III``
    | ``Nuclear Core``
    | ``Lgt_ Nuclear Core``
    | ``Imp_ Deuterium Engine``
    | ``Rnf_ Deuterium Engine``
    | ``Hyb_ Deuterium Engine``
    | ``Hvy_ Deuterium Engine``
    | ``Cld_ Deuterium Engine``
    | ``Enh_ Nuclear Core``
    | ``Mic_ Nuclear Core``
    | ``Mak_ Power Source``
    | ``Angular Momentum Engine``
    | ``Lgt_ Angular Momentum Engine``
    | ``F-cell Engine``
    | ``Fission Core``
    | ``Lgt_ Fission Core``
    | ``Hyb_ Fission Core``
    | ``Fusion Compressor``
    | ``Cold Fusion Reactor``
    | ``Neutrino Core``
    | ``Lgt_ Neutrino Core``
    | ``Rnf_ Fission Core``
    | ``Enh_ Fission Core``
    | ``Cld_ Fission Core``
    | ``Mic_ Fission Core``
    | ``Fusion Reactor``
    | ``Antimatter Reactor``
    | ``Lgt_ Antimatter Reactor``
    | ``Rnf_ Antimatter Reactor``
    | ``Hyb_ Antimatter Reactor``
    | ``Backup Power VII``
    | ``Hvy_ Antimatter Reactor``
    | ``Mni_ Fusion Reactor``
    | ``Imp_ Fusion Compressor``
    | ``Mic_ Neutrino Core``
    | ``Zio_ Light DM Reactor``
    | ``Zio_ Heavy DM Reactor``
    | ``Particle Reactor``
    | ``Lgt_ Particle Reactor``
    | ``Mic_ Antimatter Reactor``
    | ``Com_ Particle Reactor``
    | ``Cld_ Antimatter Reactor``
    | ``Graviton Reactor``
    | ``Asb_ Flux Generator``
    | ``Quantum Reactor``
    | ``Lgt_ Quantum Reactor``
    | ``Rnf_ Quantum Reactor``
    | ``Imp_ Quantum Reactor``
    | ``Zero-point Reactor``
    | ``Vortex Chain Reactor``
    | ``Singularity Reactor``
    | ``Matter Drive``
    | ``Meta Core``
    | ``SE_PO1``
    | ``Lgt_ Treads``
    | ``Imp_ Treads``
    | ``Spk_ Treads``
    | ``Arm_ Treads``
    | ``Adv_ Treads``
    | ``Med_ Treads``
    | ``Imp_ Medium Treads``
    | ``Spk_ Medium Treads``
    | ``Arm_ Medium Treads``
    | ``Hvy_ Treads``
    | ``Adv_ Medium Treads``
    | ``Enh_ Armored Medium Treads``
    | ``Imp_ Heavy Treads``
    | ``Hvy_ Siege Treads``
    | ``Spk_ Heavy Treads``
    | ``Biometal Medium Treads``
    | ``Arm_ Heavy Treads``
    | ``Adv_ Heavy Treads``
    | ``Imp_ Heavy Siege Treads``
    | ``Centrium Heavy Treads``
    | ``Megatreads``
    | ``Biometal Heavy Treads``
    | ``Exp_ Biometal Heavy Treads``
    | ``Enh_ Armored Heavy Treads``
    | ``Adv_ Heavy Siege Treads``
    | ``Hdn_ Centrium Heavy Treads``
    | ``Exp_ Biometal Medium Treads``
    | ``Aluminum Leg``
    | ``Imp_ Aluminum Leg``
    | ``Carbon-fiber Leg``
    | ``Titanium Leg``
    | ``VSS Leg``
    | ``Imp_ Carbon-fiber Leg``
    | ``Imp_ Titanium Leg``
    | ``Lgt_ Armored Exoskeleton``
    | ``Mak_ Leg``
    | ``Flexi-carbon Leg``
    | ``Arm_ Leg``
    | ``Imp_ VSS Leg``
    | ``Zio_ Composite Leg I``
    | ``Med_ Armored Exoskeleton``
    | ``Enh_ Flexi-carbon Leg``
    | ``Enh_ Armored Leg``
    | ``Arachnoskeleton``
    | ``Myomer Leg``
    | ``Adv_ VSS Leg``
    | ``Adv_ Myomer Leg``
    | ``Exp_ Flexi-carbon Leg``
    | ``Zio_ Composite Leg II``
    | ``Cargo Legs``
    | ``Etherial Tendrils``
    | ``Biometal Leg``
    | ``Hvy_ Armored Exoskeleton``
    | ``Enh_ Biometal Leg``
    | ``Exp_ Myomer Leg``
    | ``Tripod Weapons Platform``
    | ``T_R_O_L_L_ Exoskeleton``
    | ``Asb_ Alloy Leg``
    | ``Centrium Leg``
    | ``Hdn_ Centrium Leg``
    | ``Exp_ Biometal Leg``
    | ``Sigix Exoskeleton``
    | ``Zio_ Supercomposite Leg``
    | ``Potential Leg``
    | ``Myomer Exoskeleton``
    | ``SE_PR1``
    | ``Wheel``
    | ``Com_ Wheel``
    | ``Arm_ Wheel``
    | ``Sub_ Monowheel``
    | ``Arm_ Huge Wheel``
    | ``Centrium Wheel``
    | ``Hdn_ Centrium Wheel``
    | ``Hover Unit``
    | ``Backup Propulsion I``
    | ``Imp_ Hover Unit``
    | ``Airjet``
    | ``Aerolev Unit``
    | ``Asb_ Hover Unit``
    | ``Backup Propulsion III``
    | ``Gravmag System``
    | ``Asb_ Hover System``
    | ``Imp_ Airjet``
    | ``Cld_ Airjet``
    | ``Imp_ Gravmag System``
    | ``Cld_ Aerolev Unit``
    | ``Cmb_ Airjet``
    | ``Gravmag Array``
    | ``Mak_ Hover Unit``
    | ``Zio_ Glidesys I``
    | ``Antigrav System``
    | ``Gyrokinetic Inverter``
    | ``Linear Gravjet``
    | ``Cld_ Gravmag System``
    | ``Cmb_ Gravmag System``
    | ``Imp_ Antigrav System``
    | ``Imp_ Gyrokinetic Inverter``
    | ``Imp_ Linear Gravjet``
    | ``Backup Propulsion VII``
    | ``Zio_ Glidesys II``
    | ``Cld_ Antigrav System``
    | ``Cmb_ Antigrav System``
    | ``Antigrav Array``
    | ``Exp_ Gyrokinetic Inverter``
    | ``Cld_ Linear Gravjet``
    | ``Cmb_ Linear Gravjet``
    | ``Flight Unit``
    | ``VTOL Module``
    | ``Imp_ Flight Unit``
    | ``Cesium-ion Thruster``
    | ``Surge Thruster``
    | ``Imp_ VTOL Module``
    | ``Xenon Bombardment Thruster``
    | ``Imp_ Cesium-ion Thruster``
    | ``Cld_ VTOL Module``
    | ``Mak_ Flight Unit``
    | ``Nuclear Pulse Thruster``
    | ``Imp_ Surge Thruster``
    | ``Mni_ Nuclear Pulse Thruster``
    | ``Cld_ Cesium-ion Thruster``
    | ``Biomechanical Wings``
    | ``Field Propulsion Drive``
    | ``Cld_ Nuclear Pulse Thruster``
    | ``Exp_ Cesium-ion Thruster``
    | ``Nuclear Pulse Array``
    | ``Mak_ Microthruster``
    | ``Impulse Thruster``
    | ``Adv_ Surge Thruster``
    | ``Cld_ Field Propulsion Drive``
    | ``Field Propulsion Array``
    | ``Diametric Drive``
    | ``Flying Fortress v7``
    | ``T-thruster``
    | ``Integrated Tracker Drive``
    | ``Etherial Propulsion``
    | ``Q-thruster``
    | ``Electron Diverter``
    | ``Imp_ Diametric Drive``
    | ``Cld_ Impulse Thruster``
    | ``Impulse Thruster Array``
    | ``Flightbrick``
    | ``Imp_ Q-thruster``
    | ``Cld_ Q-thruster``
    | ``Exp_ Q-thruster``
    | ``Scrap Engine``
    | ``Arm_ Scrap Engine``
    | ``Desublimator``
    | ``Power Amplifier``
    | ``Adv_ Power Amplifier``
    | ``Exp_ Power Amplifier``
    | ``Thermal Generator``
    | ``Imp_ Thermal Generator``
    | ``Adv_ Thermal Generator``
    | ``Exp_ Thermal Generator``
    | ``Cryofiber Web``
    | ``Imp_ Cryofiber Web``
    | ``Adv_ Cryofiber Web``
    | ``Exp_ Cryofiber Web``
    | ``Heat Sink``
    | ``Imp_ Heat Sink``
    | ``Adv_ Heat Sink``
    | ``Exp_ Heat Sink``
    | ``Cooling System``
    | ``Imp_ Cooling System``
    | ``Adv_ Cooling System``
    | ``Exp_ Cooling System``
    | ``Coolant Network``
    | ``Asb_ Nanovents``
    | ``2N-1CE's Frost Array``
    | ``Disposable Heat Sink``
    | ``Coolant Injector``
    | ``Imp_ Coolant Injector``
    | ``Adv_ Coolant Injector``
    | ``Exp_ Coolant Injector``
    | ``Sml_ Storage Unit``
    | ``Med_ Storage Unit``
    | ``Lrg_ Storage Unit``
    | ``Hcp_ Storage Unit``
    | ``Huge Storage Unit``
    | ``Cargo Storage Unit``
    | ``Humpback``
    | ``Lightpack 2_0``
    | ``Sml_ Battery``
    | ``Med_ Battery``
    | ``Lrg_ Battery``
    | ``Hcp_ Battery``
    | ``Com_ Battery``
    | ``Energy Well``
    | ``Imp_ Energy Well``
    | ``Adv_ Energy Well``
    | ``Exp_ Energy Well``
    | ``Zio_ Biocell``
    | ``Asb_ Biocell Array``
    | ``Zio_ Biocell Array``
    | ``Superbattery``
    | ``Sml_ Matter Pod``
    | ``Med_ Matter Pod``
    | ``Lrg_ Matter Pod``
    | ``Hcp_ Matter Pod``
    | ``Com_ Matter Pod``
    | ``Matter Compressor``
    | ``Imp_ Matter Compressor``
    | ``Adv_ Matter Compressor``
    | ``Exp_ Matter Compressor``
    | ``YI-UF0's Bottomless Matter Pit``
    | ``Weight Redist_ System``
    | ``Adv_ Weight Redist_ System``
    | ``Gravity Neutralizer``
    | ``Adv_ Gravity Neutralizer``
    | ``Quantum Shading Machine``
    | ``Asb_ Suspension Frame``
    | ``Adv_ Quantum Shading Machine``
    | ``Asb_ Metafiber Network``
    | ``Zio_ Metafield Generator``
    | ``ST Field Compressor``
    | ``Structural Scanner``
    | ``Trap Scanner``
    | ``Imp_ Trap Scanner``
    | ``Mak_ Trap Scanner``
    | ``Adv_ Trap Scanner``
    | ``Machine Analyzer``
    | ``Triangulator``
    | ``Visual Processing Unit``
    | ``Sub_ Optics``
    | ``Adv_ Visual Processing Unit``
    | ``Enh_ Optical Array``
    | ``Exp_ Optical Array``
    | ``Spectral Analyzer``
    | ``Sensor Array``
    | ``Imp_ Sensor Array``
    | ``Adv_ Sensor Array``
    | ``Lrn_ Sensor Array``
    | ``Mak_ Sensor Array``
    | ``Exp_ Sensor Array``
    | ``Signal Interpreter``
    | ``Imp_ Signal Interpreter``
    | ``Adv_ Signal Interpreter``
    | ``Exp_ Signal Interpreter``
    | ``Active Sensor Suite``
    | ``Terrain Scanner``
    | ``Imp_ Terrain Scanner``
    | ``Adv_ Terrain Scanner``
    | ``Mak_ Terrain Scanner``
    | ``Lrn_ Terrain Scanner``
    | ``Exp_ Terrain Scanner``
    | ``Surveybot 24 Scanner``
    | ``Terrain Scan Processor``
    | ``Imp_ Terrain Scan Processor``
    | ``Mak_ Terrain Scan Processor``
    | ``Adv_ Terrain Scan Processor``
    | ``Exp_ Terrain Scan Processor``
    | ``Surveybot 24 Chip``
    | ``Seismic Detector``
    | ``Transport Network Coupler``
    | ``Modified TNC``
    | ``Encrypted Comm Array``
    | ``0b10 Decoder Chip _Generic_``
    | ``0b10 Decoder Chip _Looter_``
    | ``0b10 Decoder Chip _Scout_``
    | ``0b10 Decoder Chip _Skirmisher_``
    | ``0b10 Alert Chip``
    | ``Salvage Targeting Computer``
    | ``Imp_ Salvage Targeting Computer``
    | ``Mak_ Salvage Targeting Computer``
    | ``Adv_ Salvage Targeting Computer``
    | ``Asb_ Combat Suite``
    | ``Targeting Computer``
    | ``Imp_ Targeting Computer``
    | ``Adv_ Targeting Computer``
    | ``Exp_ Targeting Computer``
    | ``Multitargeting Array``
    | ``Tactical Coordination Suite``
    | ``Melee Analysis Suite``
    | ``Imp_ Melee Analysis Suite``
    | ``Adv_ Melee Analysis Suite``
    | ``Exp_ Melee Analysis Suite``
    | ``Launcher Guidance Computer``
    | ``Imp_ Launcher Guidance Computer``
    | ``Adv_ Launcher Guidance Computer``
    | ``Weapon Mount``
    | ``Target Analyzer``
    | ``Imp_ Target Analyzer``
    | ``Adv_ Target Analyzer``
    | ``Exp_ Target Analyzer``
    | ``Core Analyzer``
    | ``Exp_ Core Analyzer``
    | ``Armor Integrity Analyzer``
    | ``Imp_ Armor Integrity Analyzer``
    | ``Exp_ Armor Integrity Analyzer``
    | ``Recoil Stabilizer``
    | ``Recoil Nullifier``
    | ``Matter Filter``
    | ``Prc_ Matter Filter``
    | ``Energy Filter``
    | ``Prc_ Energy Filter``
    | ``Particle Charger``
    | ``Imp_ Particle Charger``
    | ``Adv_ Particle Charger``
    | ``Particle Accelerator``
    | ``Imp_ Particle Accelerator``
    | ``Adv_ Particle Accelerator``
    | ``Kinecellerator``
    | ``Imp_ Kinecellerator``
    | ``Adv_ Kinecellerator``
    | ``Heavy Servo Lattice``
    | ``VL-GR5's Timing Chip``
    | ``Launcher Loader``
    | ``Quantum Capacitor``
    | ``Weapon Cycler``
    | ``Imp_ Weapon Cycler``
    | ``Adv_ Weapon Cycler``
    | ``Exp_ Weapon Cycler``
    | ``Microactuators``
    | ``Nanoactuators``
    | ``Femtoactuators``
    | ``Actuator Array``
    | ``Imp_ Actuator Array``
    | ``Adv_ Actuator Array``
    | ``Exp_ Actuator Array``
    | ``Force Booster``
    | ``Imp_ Force Booster``
    | ``Adv_ Force Booster``
    | ``Stasis Canceller``
    | ``Transmission Jammer``
    | ``Mak_ Transmission Jammer``
    | ``Imp_ Transmission Jammer``
    | ``Adv_ Transmission Jammer``
    | ``Exp_ Transmission Jammer``
    | ``ECM Suite``
    | ``Mak_ ECM Suite``
    | ``Adv_ ECM Suite``
    | ``Exp_ ECM Suite``
    | ``Active Sensor Spoofer``
    | ``Reaction Control System``
    | ``Imp_ Reaction Control System``
    | ``Adv_ Reaction Control System``
    | ``Exp_ Reaction Control System``
    | ``Phase Shifter``
    | ``Imp_ Phase Shifter``
    | ``Adv_ Phase Shifter``
    | ``Exp_ Phase Shifter``
    | ``Cloaking Device``
    | ``Mak_ Cloaking Device``
    | ``Imp_ Cloaking Device``
    | ``Adv_ Cloaking Device``
    | ``Exp_ Cloaking Device``
    | ``Cloak of Protection``
    | ``5H-AD0's Cloak``
    | ``Core Shielding``
    | ``Imp_ Core Shielding``
    | ``Exp_ Core Shielding``
    | ``Power Shielding``
    | ``Imp_ Power Shielding``
    | ``Exp_ Power Shielding``
    | ``Propulsion Shielding``
    | ``Imp_ Propulsion Shielding``
    | ``Exp_ Propulsion Shielding``
    | ``Utility Shielding``
    | ``Imp_ Utility Shielding``
    | ``Exp_ Utility Shielding``
    | ``Weapon Shielding``
    | ``Imp_ Weapon Shielding``
    | ``Exp_ Weapon Shielding``
    | ``Zio_ Weapon Casing``
    | ``Backup Plating I``
    | ``Backup Plating III``
    | ``Backup Plating VII``
    | ``Lgt_ Armor Plating``
    | ``Med_ Armor Plating``
    | ``Hvy_ Armor Plating``
    | ``Zio_ Light Carapace``
    | ``Zio_ Heavy Carapace``
    | ``Hrd_ Light Armor Plating``
    | ``Hrd_ Medium Armor Plating``
    | ``Hrd_ Heavy Armor Plating``
    | ``Imp_ Light Armor Plating``
    | ``Imp_ Medium Armor Plating``
    | ``Imp_ Heavy Armor Plating``
    | ``Lyr_ Light Armor Plating``
    | ``Mak_ Armor Plating``
    | ``Lyr_ Medium Armor Plating``
    | ``Lyr_ Heavy Armor Plating``
    | ``Gun Armor``
    | ``Centrium Light Armor Plating``
    | ``Centrium Medium Armor Plating``
    | ``Centrium Heavy Armor Plating``
    | ``Centrium Linked Plating``
    | ``Reactive Plating``
    | ``Med_ Reactive Plating``
    | ``Mak_ Kinetic Plating``
    | ``Hvy_ Reactive Plating``
    | ``Reflective Plating``
    | ``Med_ Reflective Plating``
    | ``Mak_ Thermal Plating``
    | ``Hvy_ Reflective Plating``
    | ``8R-AWN's Armor_TH``
    | ``8R-AWN's Armor_EX``
    | ``Insulated Plating``
    | ``Med_ Insulated Plating``
    | ``Hvy_ Insulated Plating``
    | ``Damper Plating``
    | ``Zio_ Shade Carapace``
    | ``Zio_ Shade Armor``
    | ``Asb_ Alloy Armor``
    | ``Mak_ Ablative Armor``
    | ``Active Cooling Armor``
    | ``Scrap Shield``
    | ``Powered Armor``
    | ``Imp_ Powered Armor``
    | ``Adv_ Powered Armor``
    | ``Exp_ Powered Armor``
    | ``1C-UTU's Buckler``
    | ``Lgt_ Regenerative Plating``
    | ``Med_ Regenerative Plating``
    | ``Hvy_ Regenerative Plating``
    | ``SHELL Armor``
    | ``Phase Armor``
    | ``Graphene Brace``
    | ``Focal Shield``
    | ``Imp_ Focal Shield``
    | ``Adv_ Focal Shield``
    | ``Exp_ Focal Shield``
    | ``Thermal Shield``
    | ``Imp_ Thermal Shield``
    | ``Adv_ Thermal Shield``
    | ``Exp_ Thermal Shield``
    | ``Thermal Barrier``
    | ``Beam Splitter``
    | ``Thermal Defense Suite``
    | ``Imp_ Thermal Defense Suite``
    | ``Adv_ Thermal Defense Suite``
    | ``Exp_ Thermal Defense Suite``
    | ``Shock Absorption System``
    | ``Imp_ Shock Absorption System``
    | ``Exp_ Shock Absorption System``
    | ``EM Disruption Field``
    | ``Adv_ EM Disruption Field``
    | ``Exp_ EM Disruption Field``
    | ``ME-RLN's Chromatic Screen``
    | ``Hardlight Generator``
    | ``Imp_ Hardlight Generator``
    | ``Adv_ Hardlight Generator``
    | ``Exp_ Hardlight Generator``
    | ``Shield Generator``
    | ``Imp_ Shield Generator``
    | ``Adv_ Shield Generator``
    | ``Exp_ Shield Generator``
    | ``Force Field``
    | ``Imp_ Force Field``
    | ``Adv_ Force Field``
    | ``Exp_ Force Field``
    | ``7V-RTL's Ultimate Field``
    | ``Vortex Field Projector``
    | ``Remote Shield``
    | ``Imp_ Remote Shield``
    | ``Adv_ Remote Shield``
    | ``Remote Force Field``
    | ``Imp_ Remote Force Field``
    | ``Energy Mantle``
    | ``Imp_ Energy Mantle``
    | ``AEGIS Remote Shield``
    | ``Phase Redirector``
    | ``Point Defense System``
    | ``Point Defense Array``
    | ``Antimissile System``
    | ``EX Chip 1``
    | ``Hacking Suite``
    | ``Mak_ Hacking Suite``
    | ``Imp_ Hacking Suite``
    | ``Adv_ Hacking Suite``
    | ``Exp_ Hacking Suite``
    | ``System Mapper``
    | ``Deep Network Scanner``
    | ``Architect God Chip A``
    | ``EX Chip 2``
    | ``System Shield``
    | ``Mak_ System Shield``
    | ``Imp_ System Shield``
    | ``Adv_ System Shield``
    | ``Exp_ System Shield``
    | ``Ghost Barrier``
    | ``Quantum Router``
    | ``Architect God Chip D``
    | ``Authchip _R_NC_``
    | ``Authchip _R_Combat_``
    | ``Authchip _Power_``
    | ``Authchip _Propulsion_``
    | ``Authchip _Device_``
    | ``Authchip _Storage_``
    | ``Authchip _Processor_``
    | ``Authchip _Armor_``
    | ``Authchip _Weapon_``
    | ``Relay Coupler _NC_``
    | ``Relay Coupler _C_``
    | ``Relay Coupler _Swarmer_``
    | ``Relay Coupler _Cutter_``
    | ``Relay Coupler _Grunt_``
    | ``Relay Coupler _Brawler_``
    | ``Relay Coupler _Duelist_``
    | ``Relay Coupler _Sentry_``
    | ``Relay Coupler _Demolisher_``
    | ``Relay Coupler _Specialist_``
    | ``Relay Coupler _Hunter_``
    | ``Relay Coupler _Heavy_``
    | ``Relay Coupler _Behemoth_``
    | ``Relay Coupler _Programmer_``
    | ``Relay Coupler _Proto_``
    | ``Skeleton Box``
    | ``01-MTF's Autohacker``
    | ``Component Analysis Suite``
    | ``Imp_ Component Analysis Suite``
    | ``Adv_ Component Analysis Suite``
    | ``Dynamic Insulation System``
    | ``Imp_ Dynamic Insulation System``
    | ``Adv_ Dynamic Insulation System``
    | ``System Guard``
    | ``Imp_ System Guard``
    | ``Exp_ System Guard``
    | ``Corruption Screen``
    | ``Imp_ Corruption Screen``
    | ``Adv_ Corruption Screen``
    | ``System Restoration Module``
    | ``Mak_ System Restoration Module``
    | ``Imp_ System Restoration Module``
    | ``Adv_ System Restoration Module``
    | ``System Purifier``
    | ``Exp_ System Purifier``
    | ``Tractor Beam``
    | ``Hpw_ Tractor Beam``
    | ``Lrn_ Tractor Beam``
    | ``Mobile Refinery Mk_ CCLXVII``
    | ``Trap Extractor``
    | ``Imp_ Trap Extractor``
    | ``Adv_ Trap Extractor``
    | ``Trap Reconfigurator``
    | ``Recalibrator``
    | ``Imp_ Recalibrator``
    | ``Adv_ Recalibrator``
    | ``Field Recycling Unit``
    | ``Imp_ Field Recycling Unit``
    | ``Adv_ Field Recycling Unit``
    | ``Exp_ Field Recycling Unit``
    | ``Drone Bay``
    | ``Z-Drone Bay``
    | ``Mni_ Drone Bay``
    | ``Mapping Drone Bay``
    | ``Adv_ Drone Bay``
    | ``Bomb Drone Bay``
    | ``Thief Drone Bay``
    | ``Decoy Drone Bay``
    | ``Splice Drone Bay``
    | ``Combat Drone Bay``
    | ``Assault Drone Bay``
    | ``Stealth Drone Bay``
    | ``Swarm Drone Bay``
    | ``Supersonic Drone Bay``
    | ``Sensor Drone Bay``
    | ``Hacking Drone Bay``
    | ``Minesniffer Drone Bay``
    | ``Army-in-a-Box``
    | ``Wardrone Bay``
    | ``Cobbler Unit``
    | ``Bomb Factory No_ 2``
    | ``Mobile Assembly Unit``
    | ``Heart of Steel``
    | ``GOLEM Unit``
    | ``PSU Rigger``
    | ``Phasing AFG``
    | ``AS-neutralizer No_ 17b``
    | ``V3-11A's Pendant``
    | ``Chronowheel``
    | ``Power Bank``
    | ``Rainbow Chip``
    | ``VL-GR5's Exoskeleton _Deathgrip_``
    | ``Dimensional Node Initializer``
    | ``Transdimensional Reconstructor``
    | ``Hpw_ Transdimensional Reconstructor``
    | ``Supercharged TR``
    | ``Core Expander``
    | ``Core Regenerator``
    | ``Integrity Redistributor``
    | ``Integrated Dissipator``
    | ``Supercharged Integrated Dissipator``
    | ``Integrated Thermoelectric Network``
    | ``Integrated Reactor``
    | ``Supercharged Integrated Reactor``
    | ``Integrated Mediator``
    | ``Core Membrane``
    | ``Navigation Efficiency Matrix``
    | ``Core Reset Matrix``
    | ``Subatomic Replicator``
    | ``Terrabomb``
    | ``Core Physics Calibrator``
    | ``Spacefold Activator``
    | ``Microwarp Drive``
    | ``LC Capacitor``
    | ``LRC Armor``
    | ``LRC Storage``
    | ``LRC Energy Well``
    | ``LRC Matter Compressor``
    | ``LRC Boosters``
    | ``LRC Insulator``
    | ``EM Pulse Gun``
    | ``Hvy_ EM Pulse Gun``
    | ``EM Shotgun``
    | ``Imp_ EM Shotgun``
    | ``Shock Rifle``
    | ``Riot Gun``
    | ``Hvy_ EM Shotgun``
    | ``Lightning Gun``
    | ``Hvy_ Riot Gun``
    | ``Arc Projector``
    | ``Prc_ Shock Rifle``
    | ``Hpw_ Shock Rifle``
    | ``Arc Thrower``
    | ``Imp_ Lightning Gun``
    | ``Tesla Rifle``
    | ``Imp_ Arc Projector``
    | ``Hvy_ Tesla Rifle``
    | ``Hyp_ EM Gauss Rifle``
    | ``Imp_ Arc Thrower``
    | ``01-MTF's Shockpuncher``
    | ``Gamma Rifle``
    | ``Tachyon Dispersion Ray``
    | ``Immobilizer``
    | ``Modified EM Gauss Rifle``
    | ``AWS_EX-DEC``
    | ``Enh_ Gamma Rifle``
    | ``Med_ Laser``
    | ``Sml_ Laser``
    | ``Backup Laser I``
    | ``Beam Rifle``
    | ``Particle Gun``
    | ``Spread Laser``
    | ``Imp_ Medium Laser``
    | ``Sub_ Laser``
    | ``Autobeam``
    | ``Field Laser``
    | ``Pulse Rifle``
    | ``Backup Laser III``
    | ``Hvy_ Particle Gun``
    | ``Prc_ Beam Rifle``
    | ``Adv_ Beam Rifle``
    | ``Hvy_ Laser``
    | ``Gatling Laser``
    | ``Cld_ Pulse Rifle``
    | ``Hpw_ Field Laser``
    | ``Imp_ Spread Laser``
    | ``Mak_ Laser``
    | ``Plasma Rifle``
    | ``Thermic Laser``
    | ``Beamcaster``
    | ``Force Rifle``
    | ``Imp_ Heavy Laser``
    | ``Storm Laser``
    | ``Zio_ Laser-S``
    | ``Wave Gun``
    | ``Variable Charge Gun``
    | ``Hvy_ Beamcaster``
    | ``Cld_ Plasma Rifle``
    | ``Enh_ Force Rifle``
    | ``Hvy_ Gatling Laser``
    | ``Zio_ Phaser-S``
    | ``Phase Gun``
    | ``Dispersion Rifle``
    | ``Backup Laser VII``
    | ``Plasma Storm``
    | ``Adv_ Plasma Rifle``
    | ``Hvy_ Wave Gun``
    | ``Adv_ Variable Charge Gun``
    | ``Cld_ Phase Gun``
    | ``Lrn_ Gatling Laser``
    | ``Warp Gun``
    | ``Vortex Rifle``
    | ``Zio_ Laser-M``
    | ``AWS_Thermal``
    | ``PD Laser``
    | ``Quantum Rifle``
    | ``Prc_ Phase Gun``
    | ``Hvy_ Dispersion Rifle``
    | ``Vortex Shotgun``
    | ``Vortex Rail``
    | ``Zio_ Phaser-M``
    | ``Enh_ Quantum Rifle``
    | ``Zio_ Laser-H``
    | ``Hvy_ Quantum Rifle``
    | ``Zio_ Phaser-H``
    | ``Gatling Beam``
    | ``Sigix Sheargun``
    | ``Modified Sigix Sheargun``
    | ``Lgt_ EM Pulse Cannon``
    | ``EM Pulse Cannon``
    | ``Imp_ EM Pulse Cannon``
    | ``Proton Cannon``
    | ``Lrn_ Proton Cannon``
    | ``Disruptor Cannon``
    | ``Hvy_ Proton Cannon``
    | ``HERF Cannon``
    | ``Hvy_ Disruptor Cannon``
    | ``Cld_ Proton Cannon``
    | ``Proton Burst Cannon``
    | ``Com_ HERF Cannon``
    | ``Latent Energy Streamer``
    | ``NK-0LA's Tesla Doomcannon``
    | ``EMDS``
    | ``Hpw_ Disruptor Cannon``
    | ``Beam Cannon``
    | ``Particle Cannon``
    | ``Adv_ Beam Cannon``
    | ``Sub_ Beam Cannon``
    | ``Hvy_ Particle Cannon``
    | ``Ion Cannon``
    | ``Plasma Cannon``
    | ``Hvy_ Ion Cannon``
    | ``Cld_ Particle Cannon``
    | ``Phase Cannon``
    | ``Hvy_ Plasma Cannon``
    | ``Cld_ Plasma Cannon``
    | ``Com_ Ion Cannon``
    | ``Ion Burst Cannon``
    | ``Adv_ Plasma Cannon``
    | ``Hvy_ Phase Cannon``
    | ``Neutron Cannon``
    | ``Powered Cannon``
    | ``Matter Neutralizer``
    | ``Hvy_ Neutron Cannon``
    | ``Lrn_ Phase Cannon``
    | ``Cld_ Phase Cannon``
    | ``Vortex Cannon``
    | ``Gui_ Plasma Cannon``
    | ``Nova Cannon``
    | ``Imp_ Matter Neutralizer``
    | ``Exp_ Thermic Cannon``
    | ``Vortex Driver``
    | ``Zio_ Alpha Cannon``
    | ``Asb_ Focal Cannon``
    | ``Enh_ Nova Cannon``
    | ``Firepult``
    | ``YOLO Cannon``
    | ``Potential Cannon``
    | ``Warp Cannon``
    | ``Cld_ Nova Cannon``
    | ``Null Cannon``
    | ``Imp_ Potential Cannon``
    | ``Multinova Projection Cannon``
    | ``Disintegrator``
    | ``Core Cannon``
    | ``Sigix Shearcannon``
    | ``Drained L-Cannon``
    | ``L-Cannon``
    | ``Zio_ Alpha Cannon Mk_ II``
    | ``BFG-9k Vortex Edition``
    | ``Assault Rifle``
    | ``Asb_ Rifle``
    | ``Lgt_ Assault Rifle``
    | ``Hvy_ Assault Rifle``
    | ``Autogun``
    | ``Shotgun``
    | ``Battle Rifle``
    | ``Asb_ Heavy Rifle``
    | ``Sub_ Machine Gun``
    | ``Imp_ Assault Rifle``
    | ``Minigun``
    | ``Hpw_ Shotgun``
    | ``Asb_ Shotgun``
    | ``Barrage Gun``
    | ``Enh_ Autogun``
    | ``Gauss Rifle``
    | ``Asb_ Gauss Rifle``
    | ``Flak Gun``
    | ``Prc_ Assault Rifle``
    | ``Hvy_ Battle Rifle``
    | ``Mak_ Shrapnel Gun``
    | ``Coil Gun``
    | ``Hyp_ Gauss Rifle``
    | ``Hvy_ Machine Gun``
    | ``Imp_ Heavy Machine Gun``
    | ``Com_ Gauss Rifle``
    | ``XL Autogun Subcomponent``
    | ``KE Penetrator``
    | ``Hyp_ Coil Gun``
    | ``Imp_ KE Penetrator``
    | ``Enh_ Coil Gun``
    | ``Com_ Coil Gun``
    | ``Railgun``
    | ``Adv_ KE Penetrator``
    | ``Linked Autogun``
    | ``AWS_Gauss``
    | ``Hyp_ Railgun``
    | ``Helical Railgun``
    | ``Com_ Railgun``
    | ``XL Autogun Array``
    | ``12-ASH's Boomstick``
    | ``8R-AWN's Boregun``
    | ``Multirail``
    | ``Hyp_ Multirail``
    | ``5H-AD0's Sniper Rifle``
    | ``A3's Sniper Rifle``
    | ``Lgt_ Cannon``
    | ``Imp_ Light Cannon``
    | ``Battle Cannon``
    | ``Assault Cannon``
    | ``Hvy_ Assault Cannon``
    | ``Flak Cannon``
    | ``Adv_ Assault Cannon``
    | ``Gauss Cannon``
    | ``Slug Cannon``
    | ``Mni_ Assault Cannon``
    | ``Magnetic Acceleration Cannon``
    | ``Hvy_ Flak Cannon``
    | ``Bore Cannon``
    | ``Antimatter Cannon``
    | ``Mass Driver``
    | ``Hvy_ Mass Driver``
    | ``Enh_ Gauss Cannon``
    | ``Hyp_ Gauss Cannon``
    | ``Tri-rail Accelerator``
    | ``Hardcell Cannon``
    | ``Hvy_ Gauss Cannon``
    | ``Hyp_ Mass Driver``
    | ``Hvy_ Autocannon``
    | ``DAS Cannon``
    | ``Lgt_ Antimatter Cannon``
    | ``Linear Accelerator``
    | ``Hvy_ Linear Accelerator``
    | ``Com_ Mass Driver``
    | ``Hvy_ Hardcell Cannon``
    | ``Com_ Linear Accelerator``
    | ``Hyp_ Linear Accelerator``
    | ``Hcl_ Linear Accelerator``
    | ``Graviton Cannon``
    | ``Blast Cannon``
    | ``P1-3CE's Gatling Flakker``
    | ``AWS_Autocannon``
    | ``Perforator``
    | ``Omega Cannon``
    | ``EMP Blaster``
    | ``Shock Bomb Launcher``
    | ``Adv_ EMP Blaster``
    | ``Proton Missile Launcher``
    | ``Imp_ Proton Missile Launcher``
    | ``Gui_ EMP Blaster``
    | ``Hvy_ Shock Bomb Launcher``
    | ``Tesla Bomb Launcher``
    | ``Hvy_ Proton Missile Launcher``
    | ``Com_ Tesla Bomb Launcher``
    | ``Gamma Bomb Array``
    | ``Enh_ Gamma Bomb Array``
    | ``Grenade Launcher``
    | ``Rocket Launcher``
    | ``Mni_ Grenade Launcher``
    | ``Sub_ Shrapnel Launcher``
    | ``Imp_ Grenade Launcher``
    | ``Missile Launcher``
    | ``Concussive RPG``
    | ``YI-UF0's Doublenader``
    | ``Hvy_ Rocket Launcher``
    | ``Hvy_ Missile Launcher``
    | ``Gui_ Missile Launcher``
    | ``Prc_ Grenade Launcher``
    | ``Rocket Array``
    | ``Lrn_ Missile Launcher``
    | ``Imp_ Concussive RPG``
    | ``Prc_ Rocket Launcher``
    | ``Scatter Rocket Array``
    | ``Smartbomb Launcher``
    | ``Mni_ Smartbomb Launcher``
    | ``Tiamat Missile Launcher``
    | ``Thermoblaster``
    | ``Micro-nuke Launcher``
    | ``Adv_ Concussive RPG``
    | ``Neutron Missile Launcher``
    | ``Fusion Bomb Launcher``
    | ``Hellfire Missile Launcher``
    | ``Adv_ Micro-nuke Launcher``
    | ``Tactical Quantum Warhead``
    | ``Vortex Catalyst Activator``
    | ``Chain Missile Launcher``
    | ``Ragnarok Missile Launcher``
    | ``Point Singularity Launcher``
    | ``Gui_ Micro-nuke Launcher``
    | ``99-TNT's Nukerbomber``
    | ``Z-bomb Delivery System``
    | ``Sigix Terminator``
    | ``Supercharged Sigix Terminator``
    | ``Containment Facilitator``
    | ``Detonator``
    | ``Dirty Datajack``
    | ``Splice Injector``
    | ``Datajack``
    | ``Imp_ Datajack``
    | ``Adv_ Datajack``
    | ``Remote Datajack``
    | ``Imp_ Remote Datajack``
    | ``Adv_ Remote Datajack``
    | ``Exp_ Remote Datajack``
    | ``Gui_ Remote Datajack``
    | ``ME-RLN's Wand``
    | ``Field Lobotomy Kit``
    | ``Mining Laser``
    | ``Welding Torch``
    | ``Plasma Cutter``
    | ``Imp_ Plasma Cutter``
    | ``CPS Tube``
    | ``Multitool``
    | ``Flamer``
    | ``Asb_ F-torch``
    | ``Enh_ Flamer``
    | ``Plasma Flamer``
    | ``Asb_ P-torch``
    | ``RU-N14's Throwing Claymores``
    | ``RU-N14's Throwing Claymores v3``
    | ``AD-0RF's Magmablaster``
    | ``Stasis Beam``
    | ``Stasis Projector``
    | ``Exp_ Stasis Projector``
    | ``Molecular Deconstructor``
    | ``SE_WE1``
    | ``SE_WE2``
    | ``SE_WE3``
    | ``SE_WE4``
    | ``SE_WE5``
    | ``Hammer``
    | ``Mace``
    | ``Flail``
    | ``Maul``
    | ``Asb_ Maul``
    | ``Hvy_ Hammer``
    | ``Hvy_ Mace``
    | ``Hvy_ Flail``
    | ``Great Maul``
    | ``Powered Hammer``
    | ``Mak_ Hammer``
    | ``Power Maul``
    | ``Asb_ P-maul``
    | ``Impact Mace``
    | ``Shock Maul``
    | ``Thunder Hammer``
    | ``Compactor``
    | ``Gravity Flail``
    | ``CL-ANK's Mallet``
    | ``Core Stripper``
    | ``Mining Claw``
    | ``EC_1``
    | ``Katana``
    | ``Asb_ Blade``
    | ``Scythe``
    | ``Axe``
    | ``Blade Saw``
    | ``EC_3``
    | ``Chainsword``
    | ``Ripper``
    | ``Mak_ Axe``
    | ``Mak_ Sword``
    | ``Great Axe``
    | ``Greatsword``
    | ``Power Sword``
    | ``Asb_ P-sword``
    | ``Falx``
    | ``Carbide Saw``
    | ``Segregator``
    | ``Tearclaws``
    | ``EC_5``
    | ``Phasing Sabre``
    | ``Plasma Sword``
    | ``Ionic Axe``
    | ``Mni_ Tearclaws``
    | ``Dual-blade Saw``
    | ``Vibroblade``
    | ``Molecular Scythe``
    | ``Centrium Greatsword``
    | ``Master Tearclaws``
    | ``Longsword _1``
    | ``EC_7``
    | ``Nanosword``
    | ``Particle Cleaver``
    | ``Centrium Claws``
    | ``1C-UTU's Sword _Lootmaker_``
    | ``1C-UTU's Sword _Choppy_``
    | ``Vortex Shredder``
    | ``EC_9``
    | ``Sigix Broadsword``
    | ``Spear``
    | ``Mak_ Spear``
    | ``CR-A16's Pointy Stick``
    | ``Hvy_ Pick``
    | ``Lance``
    | ``Kinetic Spear``
    | ``Force Lance``
    | ``Plasma Lance``
    | ``Enh_ Force Lance``
    | ``Vortex Lance``
    | ``CR-A16's Behemoth Slayer``
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
    | ``Piercing Trap``
    | ``Shock Trap``
    | ``EM Surge Trap``
    | ``Fire Trap``
    | ``Stasis Trap``
    | ``Scrap Shield Fragment``
    | ``Signal Generator``
    | ``Self-destruct Interrupter``
    | ``Sapper Charge``
    | ``Zhirov Special``
    | ``Deploy-a-Sentry``
    | ``GAL Module``
    | ``Portable AFG``
    | ``SGEMP Prototype``
    | ``Terrabomb Derivative``
    | ``Sigix Containment Pod``
    | ``Sigix Corpse``
    | ``Meganuke``
    | ``Gamma Refractor``
    
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
    | 52 -> Item.``Hvy_ Antimatter Reactor``
    | 53 -> Item.``Mni_ Fusion Reactor``
    | 54 -> Item.``Imp_ Fusion Compressor``
    | 55 -> Item.``Mic_ Neutrino Core``
    | 56 -> Item.``Zio_ Light DM Reactor``
    | 57 -> Item.``Zio_ Heavy DM Reactor``
    | 58 -> Item.``Particle Reactor``
    | 59 -> Item.``Lgt_ Particle Reactor``
    | 60 -> Item.``Mic_ Antimatter Reactor``
    | 61 -> Item.``Com_ Particle Reactor``
    | 62 -> Item.``Cld_ Antimatter Reactor``
    | 63 -> Item.``Graviton Reactor``
    | 64 -> Item.``Asb_ Flux Generator``
    | 65 -> Item.``Quantum Reactor``
    | 66 -> Item.``Lgt_ Quantum Reactor``
    | 67 -> Item.``Rnf_ Quantum Reactor``
    | 68 -> Item.``Imp_ Quantum Reactor``
    | 69 -> Item.``Zero-point Reactor``
    | 70 -> Item.``Vortex Chain Reactor``
    | 71 -> Item.``Singularity Reactor``
    | 72 -> Item.``Matter Drive``
    | 73 -> Item.``Meta Core``
    | 74 -> Item.``SE_PO1``
    | 75 -> Item.``Lgt_ Treads``
    | 76 -> Item.``Imp_ Treads``
    | 77 -> Item.``Spk_ Treads``
    | 78 -> Item.``Arm_ Treads``
    | 79 -> Item.``Adv_ Treads``
    | 80 -> Item.``Med_ Treads``
    | 81 -> Item.``Imp_ Medium Treads``
    | 82 -> Item.``Spk_ Medium Treads``
    | 83 -> Item.``Arm_ Medium Treads``
    | 84 -> Item.``Hvy_ Treads``
    | 85 -> Item.``Adv_ Medium Treads``
    | 86 -> Item.``Enh_ Armored Medium Treads``
    | 87 -> Item.``Imp_ Heavy Treads``
    | 88 -> Item.``Hvy_ Siege Treads``
    | 89 -> Item.``Spk_ Heavy Treads``
    | 90 -> Item.``Biometal Medium Treads``
    | 91 -> Item.``Arm_ Heavy Treads``
    | 92 -> Item.``Adv_ Heavy Treads``
    | 93 -> Item.``Imp_ Heavy Siege Treads``
    | 94 -> Item.``Centrium Heavy Treads``
    | 95 -> Item.``Megatreads``
    | 96 -> Item.``Biometal Heavy Treads``
    | 97 -> Item.``Exp_ Biometal Heavy Treads``
    | 98 -> Item.``Enh_ Armored Heavy Treads``
    | 99 -> Item.``Adv_ Heavy Siege Treads``
    | 100 -> Item.``Hdn_ Centrium Heavy Treads``
    | 101 -> Item.``Exp_ Biometal Medium Treads``
    | 102 -> Item.``Aluminum Leg``
    | 103 -> Item.``Imp_ Aluminum Leg``
    | 104 -> Item.``Carbon-fiber Leg``
    | 105 -> Item.``Titanium Leg``
    | 106 -> Item.``VSS Leg``
    | 107 -> Item.``Imp_ Carbon-fiber Leg``
    | 108 -> Item.``Imp_ Titanium Leg``
    | 109 -> Item.``Lgt_ Armored Exoskeleton``
    | 110 -> Item.``Mak_ Leg``
    | 111 -> Item.``Flexi-carbon Leg``
    | 112 -> Item.``Arm_ Leg``
    | 113 -> Item.``Imp_ VSS Leg``
    | 114 -> Item.``Zio_ Composite Leg I``
    | 115 -> Item.``Med_ Armored Exoskeleton``
    | 116 -> Item.``Enh_ Flexi-carbon Leg``
    | 117 -> Item.``Enh_ Armored Leg``
    | 118 -> Item.``Arachnoskeleton``
    | 119 -> Item.``Myomer Leg``
    | 120 -> Item.``Adv_ VSS Leg``
    | 121 -> Item.``Adv_ Myomer Leg``
    | 122 -> Item.``Exp_ Flexi-carbon Leg``
    | 123 -> Item.``Zio_ Composite Leg II``
    | 124 -> Item.``Cargo Legs``
    | 125 -> Item.``Etherial Tendrils``
    | 126 -> Item.``Biometal Leg``
    | 127 -> Item.``Hvy_ Armored Exoskeleton``
    | 128 -> Item.``Enh_ Biometal Leg``
    | 129 -> Item.``Exp_ Myomer Leg``
    | 130 -> Item.``Tripod Weapons Platform``
    | 131 -> Item.``T_R_O_L_L_ Exoskeleton``
    | 132 -> Item.``Asb_ Alloy Leg``
    | 133 -> Item.``Centrium Leg``
    | 134 -> Item.``Hdn_ Centrium Leg``
    | 135 -> Item.``Exp_ Biometal Leg``
    | 136 -> Item.``Sigix Exoskeleton``
    | 137 -> Item.``Zio_ Supercomposite Leg``
    | 138 -> Item.``Potential Leg``
    | 139 -> Item.``Myomer Exoskeleton``
    | 140 -> Item.``SE_PR1``
    | 141 -> Item.``Wheel``
    | 142 -> Item.``Com_ Wheel``
    | 143 -> Item.``Arm_ Wheel``
    | 144 -> Item.``Sub_ Monowheel``
    | 145 -> Item.``Arm_ Huge Wheel``
    | 146 -> Item.``Centrium Wheel``
    | 147 -> Item.``Hdn_ Centrium Wheel``
    | 148 -> Item.``Hover Unit``
    | 149 -> Item.``Backup Propulsion I``
    | 150 -> Item.``Imp_ Hover Unit``
    | 151 -> Item.``Airjet``
    | 152 -> Item.``Aerolev Unit``
    | 153 -> Item.``Asb_ Hover Unit``
    | 154 -> Item.``Backup Propulsion III``
    | 155 -> Item.``Gravmag System``
    | 156 -> Item.``Asb_ Hover System``
    | 157 -> Item.``Imp_ Airjet``
    | 158 -> Item.``Cld_ Airjet``
    | 159 -> Item.``Imp_ Gravmag System``
    | 160 -> Item.``Cld_ Aerolev Unit``
    | 161 -> Item.``Cmb_ Airjet``
    | 162 -> Item.``Gravmag Array``
    | 163 -> Item.``Mak_ Hover Unit``
    | 164 -> Item.``Zio_ Glidesys I``
    | 165 -> Item.``Antigrav System``
    | 166 -> Item.``Gyrokinetic Inverter``
    | 167 -> Item.``Linear Gravjet``
    | 168 -> Item.``Cld_ Gravmag System``
    | 169 -> Item.``Cmb_ Gravmag System``
    | 170 -> Item.``Imp_ Antigrav System``
    | 171 -> Item.``Imp_ Gyrokinetic Inverter``
    | 172 -> Item.``Imp_ Linear Gravjet``
    | 173 -> Item.``Backup Propulsion VII``
    | 174 -> Item.``Zio_ Glidesys II``
    | 175 -> Item.``Cld_ Antigrav System``
    | 176 -> Item.``Cmb_ Antigrav System``
    | 177 -> Item.``Antigrav Array``
    | 178 -> Item.``Exp_ Gyrokinetic Inverter``
    | 179 -> Item.``Cld_ Linear Gravjet``
    | 180 -> Item.``Cmb_ Linear Gravjet``
    | 181 -> Item.``Flight Unit``
    | 182 -> Item.``VTOL Module``
    | 183 -> Item.``Imp_ Flight Unit``
    | 184 -> Item.``Cesium-ion Thruster``
    | 185 -> Item.``Surge Thruster``
    | 186 -> Item.``Imp_ VTOL Module``
    | 187 -> Item.``Xenon Bombardment Thruster``
    | 188 -> Item.``Imp_ Cesium-ion Thruster``
    | 189 -> Item.``Cld_ VTOL Module``
    | 190 -> Item.``Mak_ Flight Unit``
    | 191 -> Item.``Nuclear Pulse Thruster``
    | 192 -> Item.``Imp_ Surge Thruster``
    | 193 -> Item.``Mni_ Nuclear Pulse Thruster``
    | 194 -> Item.``Cld_ Cesium-ion Thruster``
    | 195 -> Item.``Biomechanical Wings``
    | 196 -> Item.``Field Propulsion Drive``
    | 197 -> Item.``Cld_ Nuclear Pulse Thruster``
    | 198 -> Item.``Exp_ Cesium-ion Thruster``
    | 199 -> Item.``Nuclear Pulse Array``
    | 200 -> Item.``Mak_ Microthruster``
    | 201 -> Item.``Impulse Thruster``
    | 202 -> Item.``Adv_ Surge Thruster``
    | 203 -> Item.``Cld_ Field Propulsion Drive``
    | 204 -> Item.``Field Propulsion Array``
    | 205 -> Item.``Diametric Drive``
    | 206 -> Item.``Flying Fortress v7``
    | 207 -> Item.``T-thruster``
    | 208 -> Item.``Integrated Tracker Drive``
    | 209 -> Item.``Etherial Propulsion``
    | 210 -> Item.``Q-thruster``
    | 211 -> Item.``Electron Diverter``
    | 212 -> Item.``Imp_ Diametric Drive``
    | 213 -> Item.``Cld_ Impulse Thruster``
    | 214 -> Item.``Impulse Thruster Array``
    | 215 -> Item.``Flightbrick``
    | 216 -> Item.``Imp_ Q-thruster``
    | 217 -> Item.``Cld_ Q-thruster``
    | 218 -> Item.``Exp_ Q-thruster``
    | 219 -> Item.``Scrap Engine``
    | 220 -> Item.``Arm_ Scrap Engine``
    | 221 -> Item.``Desublimator``
    | 222 -> Item.``Power Amplifier``
    | 223 -> Item.``Adv_ Power Amplifier``
    | 224 -> Item.``Exp_ Power Amplifier``
    | 225 -> Item.``Thermal Generator``
    | 226 -> Item.``Imp_ Thermal Generator``
    | 227 -> Item.``Adv_ Thermal Generator``
    | 228 -> Item.``Exp_ Thermal Generator``
    | 229 -> Item.``Cryofiber Web``
    | 230 -> Item.``Imp_ Cryofiber Web``
    | 231 -> Item.``Adv_ Cryofiber Web``
    | 232 -> Item.``Exp_ Cryofiber Web``
    | 233 -> Item.``Heat Sink``
    | 234 -> Item.``Imp_ Heat Sink``
    | 235 -> Item.``Adv_ Heat Sink``
    | 236 -> Item.``Exp_ Heat Sink``
    | 237 -> Item.``Cooling System``
    | 238 -> Item.``Imp_ Cooling System``
    | 239 -> Item.``Adv_ Cooling System``
    | 240 -> Item.``Exp_ Cooling System``
    | 241 -> Item.``Coolant Network``
    | 242 -> Item.``Asb_ Nanovents``
    | 243 -> Item.``2N-1CE's Frost Array``
    | 244 -> Item.``Disposable Heat Sink``
    | 245 -> Item.``Coolant Injector``
    | 246 -> Item.``Imp_ Coolant Injector``
    | 247 -> Item.``Adv_ Coolant Injector``
    | 248 -> Item.``Exp_ Coolant Injector``
    | 249 -> Item.``Sml_ Storage Unit``
    | 250 -> Item.``Med_ Storage Unit``
    | 251 -> Item.``Lrg_ Storage Unit``
    | 252 -> Item.``Hcp_ Storage Unit``
    | 253 -> Item.``Huge Storage Unit``
    | 254 -> Item.``Cargo Storage Unit``
    | 255 -> Item.``Humpback``
    | 256 -> Item.``Lightpack 2_0``
    | 257 -> Item.``Sml_ Battery``
    | 258 -> Item.``Med_ Battery``
    | 259 -> Item.``Lrg_ Battery``
    | 260 -> Item.``Hcp_ Battery``
    | 261 -> Item.``Com_ Battery``
    | 262 -> Item.``Energy Well``
    | 263 -> Item.``Imp_ Energy Well``
    | 264 -> Item.``Adv_ Energy Well``
    | 265 -> Item.``Exp_ Energy Well``
    | 266 -> Item.``Zio_ Biocell``
    | 267 -> Item.``Asb_ Biocell Array``
    | 268 -> Item.``Zio_ Biocell Array``
    | 269 -> Item.``Superbattery``
    | 270 -> Item.``Sml_ Matter Pod``
    | 271 -> Item.``Med_ Matter Pod``
    | 272 -> Item.``Lrg_ Matter Pod``
    | 273 -> Item.``Hcp_ Matter Pod``
    | 274 -> Item.``Com_ Matter Pod``
    | 275 -> Item.``Matter Compressor``
    | 276 -> Item.``Imp_ Matter Compressor``
    | 277 -> Item.``Adv_ Matter Compressor``
    | 278 -> Item.``Exp_ Matter Compressor``
    | 279 -> Item.``YI-UF0's Bottomless Matter Pit``
    | 280 -> Item.``Weight Redist_ System``
    | 281 -> Item.``Adv_ Weight Redist_ System``
    | 282 -> Item.``Gravity Neutralizer``
    | 283 -> Item.``Adv_ Gravity Neutralizer``
    | 284 -> Item.``Quantum Shading Machine``
    | 285 -> Item.``Asb_ Suspension Frame``
    | 286 -> Item.``Adv_ Quantum Shading Machine``
    | 287 -> Item.``Asb_ Metafiber Network``
    | 288 -> Item.``Zio_ Metafield Generator``
    | 289 -> Item.``ST Field Compressor``
    | 290 -> Item.``Structural Scanner``
    | 291 -> Item.``Trap Scanner``
    | 292 -> Item.``Imp_ Trap Scanner``
    | 293 -> Item.``Mak_ Trap Scanner``
    | 294 -> Item.``Adv_ Trap Scanner``
    | 295 -> Item.``Machine Analyzer``
    | 296 -> Item.``Triangulator``
    | 297 -> Item.``Visual Processing Unit``
    | 298 -> Item.``Sub_ Optics``
    | 299 -> Item.``Adv_ Visual Processing Unit``
    | 300 -> Item.``Enh_ Optical Array``
    | 301 -> Item.``Exp_ Optical Array``
    | 302 -> Item.``Spectral Analyzer``
    | 303 -> Item.``Sensor Array``
    | 304 -> Item.``Imp_ Sensor Array``
    | 305 -> Item.``Adv_ Sensor Array``
    | 306 -> Item.``Lrn_ Sensor Array``
    | 307 -> Item.``Mak_ Sensor Array``
    | 308 -> Item.``Exp_ Sensor Array``
    | 309 -> Item.``Signal Interpreter``
    | 310 -> Item.``Imp_ Signal Interpreter``
    | 311 -> Item.``Adv_ Signal Interpreter``
    | 312 -> Item.``Exp_ Signal Interpreter``
    | 313 -> Item.``Active Sensor Suite``
    | 314 -> Item.``Terrain Scanner``
    | 315 -> Item.``Imp_ Terrain Scanner``
    | 316 -> Item.``Adv_ Terrain Scanner``
    | 317 -> Item.``Mak_ Terrain Scanner``
    | 318 -> Item.``Lrn_ Terrain Scanner``
    | 319 -> Item.``Exp_ Terrain Scanner``
    | 320 -> Item.``Surveybot 24 Scanner``
    | 321 -> Item.``Terrain Scan Processor``
    | 322 -> Item.``Imp_ Terrain Scan Processor``
    | 323 -> Item.``Mak_ Terrain Scan Processor``
    | 324 -> Item.``Adv_ Terrain Scan Processor``
    | 325 -> Item.``Exp_ Terrain Scan Processor``
    | 326 -> Item.``Surveybot 24 Chip``
    | 327 -> Item.``Seismic Detector``
    | 328 -> Item.``Transport Network Coupler``
    | 329 -> Item.``Modified TNC``
    | 330 -> Item.``Encrypted Comm Array``
    | 331 -> Item.``0b10 Decoder Chip _Generic_``
    | 332 -> Item.``0b10 Decoder Chip _Looter_``
    | 333 -> Item.``0b10 Decoder Chip _Scout_``
    | 334 -> Item.``0b10 Decoder Chip _Skirmisher_``
    | 335 -> Item.``0b10 Alert Chip``
    | 336 -> Item.``Salvage Targeting Computer``
    | 337 -> Item.``Imp_ Salvage Targeting Computer``
    | 338 -> Item.``Mak_ Salvage Targeting Computer``
    | 339 -> Item.``Adv_ Salvage Targeting Computer``
    | 340 -> Item.``Asb_ Combat Suite``
    | 341 -> Item.``Targeting Computer``
    | 342 -> Item.``Imp_ Targeting Computer``
    | 343 -> Item.``Adv_ Targeting Computer``
    | 344 -> Item.``Exp_ Targeting Computer``
    | 345 -> Item.``Multitargeting Array``
    | 346 -> Item.``Tactical Coordination Suite``
    | 347 -> Item.``Melee Analysis Suite``
    | 348 -> Item.``Imp_ Melee Analysis Suite``
    | 349 -> Item.``Adv_ Melee Analysis Suite``
    | 350 -> Item.``Exp_ Melee Analysis Suite``
    | 351 -> Item.``Launcher Guidance Computer``
    | 352 -> Item.``Imp_ Launcher Guidance Computer``
    | 353 -> Item.``Adv_ Launcher Guidance Computer``
    | 354 -> Item.``Weapon Mount``
    | 355 -> Item.``Target Analyzer``
    | 356 -> Item.``Imp_ Target Analyzer``
    | 357 -> Item.``Adv_ Target Analyzer``
    | 358 -> Item.``Exp_ Target Analyzer``
    | 359 -> Item.``Core Analyzer``
    | 360 -> Item.``Exp_ Core Analyzer``
    | 361 -> Item.``Armor Integrity Analyzer``
    | 362 -> Item.``Imp_ Armor Integrity Analyzer``
    | 363 -> Item.``Exp_ Armor Integrity Analyzer``
    | 364 -> Item.``Recoil Stabilizer``
    | 365 -> Item.``Recoil Nullifier``
    | 366 -> Item.``Matter Filter``
    | 367 -> Item.``Prc_ Matter Filter``
    | 368 -> Item.``Energy Filter``
    | 369 -> Item.``Prc_ Energy Filter``
    | 370 -> Item.``Particle Charger``
    | 371 -> Item.``Imp_ Particle Charger``
    | 372 -> Item.``Adv_ Particle Charger``
    | 373 -> Item.``Particle Accelerator``
    | 374 -> Item.``Imp_ Particle Accelerator``
    | 375 -> Item.``Adv_ Particle Accelerator``
    | 376 -> Item.``Kinecellerator``
    | 377 -> Item.``Imp_ Kinecellerator``
    | 378 -> Item.``Adv_ Kinecellerator``
    | 379 -> Item.``Heavy Servo Lattice``
    | 380 -> Item.``VL-GR5's Timing Chip``
    | 381 -> Item.``Launcher Loader``
    | 382 -> Item.``Quantum Capacitor``
    | 383 -> Item.``Weapon Cycler``
    | 384 -> Item.``Imp_ Weapon Cycler``
    | 385 -> Item.``Adv_ Weapon Cycler``
    | 386 -> Item.``Exp_ Weapon Cycler``
    | 387 -> Item.``Microactuators``
    | 388 -> Item.``Nanoactuators``
    | 389 -> Item.``Femtoactuators``
    | 390 -> Item.``Actuator Array``
    | 391 -> Item.``Imp_ Actuator Array``
    | 392 -> Item.``Adv_ Actuator Array``
    | 393 -> Item.``Exp_ Actuator Array``
    | 394 -> Item.``Force Booster``
    | 395 -> Item.``Imp_ Force Booster``
    | 396 -> Item.``Adv_ Force Booster``
    | 397 -> Item.``Stasis Canceller``
    | 398 -> Item.``Transmission Jammer``
    | 399 -> Item.``Mak_ Transmission Jammer``
    | 400 -> Item.``Imp_ Transmission Jammer``
    | 401 -> Item.``Adv_ Transmission Jammer``
    | 402 -> Item.``Exp_ Transmission Jammer``
    | 403 -> Item.``ECM Suite``
    | 404 -> Item.``Mak_ ECM Suite``
    | 405 -> Item.``Adv_ ECM Suite``
    | 406 -> Item.``Exp_ ECM Suite``
    | 407 -> Item.``Active Sensor Spoofer``
    | 408 -> Item.``Reaction Control System``
    | 409 -> Item.``Imp_ Reaction Control System``
    | 410 -> Item.``Adv_ Reaction Control System``
    | 411 -> Item.``Exp_ Reaction Control System``
    | 412 -> Item.``Phase Shifter``
    | 413 -> Item.``Imp_ Phase Shifter``
    | 414 -> Item.``Adv_ Phase Shifter``
    | 415 -> Item.``Exp_ Phase Shifter``
    | 416 -> Item.``Cloaking Device``
    | 417 -> Item.``Mak_ Cloaking Device``
    | 418 -> Item.``Imp_ Cloaking Device``
    | 419 -> Item.``Adv_ Cloaking Device``
    | 420 -> Item.``Exp_ Cloaking Device``
    | 421 -> Item.``Cloak of Protection``
    | 422 -> Item.``5H-AD0's Cloak``
    | 423 -> Item.``Core Shielding``
    | 424 -> Item.``Imp_ Core Shielding``
    | 425 -> Item.``Exp_ Core Shielding``
    | 426 -> Item.``Power Shielding``
    | 427 -> Item.``Imp_ Power Shielding``
    | 428 -> Item.``Exp_ Power Shielding``
    | 429 -> Item.``Propulsion Shielding``
    | 430 -> Item.``Imp_ Propulsion Shielding``
    | 431 -> Item.``Exp_ Propulsion Shielding``
    | 432 -> Item.``Utility Shielding``
    | 433 -> Item.``Imp_ Utility Shielding``
    | 434 -> Item.``Exp_ Utility Shielding``
    | 435 -> Item.``Weapon Shielding``
    | 436 -> Item.``Imp_ Weapon Shielding``
    | 437 -> Item.``Exp_ Weapon Shielding``
    | 438 -> Item.``Zio_ Weapon Casing``
    | 439 -> Item.``Backup Plating I``
    | 440 -> Item.``Backup Plating III``
    | 441 -> Item.``Backup Plating VII``
    | 442 -> Item.``Lgt_ Armor Plating``
    | 443 -> Item.``Med_ Armor Plating``
    | 444 -> Item.``Hvy_ Armor Plating``
    | 445 -> Item.``Zio_ Light Carapace``
    | 446 -> Item.``Zio_ Heavy Carapace``
    | 447 -> Item.``Hrd_ Light Armor Plating``
    | 448 -> Item.``Hrd_ Medium Armor Plating``
    | 449 -> Item.``Hrd_ Heavy Armor Plating``
    | 450 -> Item.``Imp_ Light Armor Plating``
    | 451 -> Item.``Imp_ Medium Armor Plating``
    | 452 -> Item.``Imp_ Heavy Armor Plating``
    | 453 -> Item.``Lyr_ Light Armor Plating``
    | 454 -> Item.``Mak_ Armor Plating``
    | 455 -> Item.``Lyr_ Medium Armor Plating``
    | 456 -> Item.``Lyr_ Heavy Armor Plating``
    | 457 -> Item.``Gun Armor``
    | 458 -> Item.``Centrium Light Armor Plating``
    | 459 -> Item.``Centrium Medium Armor Plating``
    | 460 -> Item.``Centrium Heavy Armor Plating``
    | 461 -> Item.``Centrium Linked Plating``
    | 462 -> Item.``Reactive Plating``
    | 463 -> Item.``Med_ Reactive Plating``
    | 464 -> Item.``Mak_ Kinetic Plating``
    | 465 -> Item.``Hvy_ Reactive Plating``
    | 466 -> Item.``Reflective Plating``
    | 467 -> Item.``Med_ Reflective Plating``
    | 468 -> Item.``Mak_ Thermal Plating``
    | 469 -> Item.``Hvy_ Reflective Plating``
    | 470 -> Item.``8R-AWN's Armor_TH``
    | 471 -> Item.``8R-AWN's Armor_EX``
    | 472 -> Item.``Insulated Plating``
    | 473 -> Item.``Med_ Insulated Plating``
    | 474 -> Item.``Hvy_ Insulated Plating``
    | 475 -> Item.``Damper Plating``
    | 476 -> Item.``Zio_ Shade Carapace``
    | 477 -> Item.``Zio_ Shade Armor``
    | 478 -> Item.``Asb_ Alloy Armor``
    | 479 -> Item.``Mak_ Ablative Armor``
    | 480 -> Item.``Active Cooling Armor``
    | 481 -> Item.``Scrap Shield``
    | 482 -> Item.``Powered Armor``
    | 483 -> Item.``Imp_ Powered Armor``
    | 484 -> Item.``Adv_ Powered Armor``
    | 485 -> Item.``Exp_ Powered Armor``
    | 486 -> Item.``1C-UTU's Buckler``
    | 487 -> Item.``Lgt_ Regenerative Plating``
    | 488 -> Item.``Med_ Regenerative Plating``
    | 489 -> Item.``Hvy_ Regenerative Plating``
    | 490 -> Item.``SHELL Armor``
    | 491 -> Item.``Phase Armor``
    | 492 -> Item.``Graphene Brace``
    | 493 -> Item.``Focal Shield``
    | 494 -> Item.``Imp_ Focal Shield``
    | 495 -> Item.``Adv_ Focal Shield``
    | 496 -> Item.``Exp_ Focal Shield``
    | 497 -> Item.``Thermal Shield``
    | 498 -> Item.``Imp_ Thermal Shield``
    | 499 -> Item.``Adv_ Thermal Shield``
    | 500 -> Item.``Exp_ Thermal Shield``
    | 501 -> Item.``Thermal Barrier``
    | 502 -> Item.``Beam Splitter``
    | 503 -> Item.``Thermal Defense Suite``
    | 504 -> Item.``Imp_ Thermal Defense Suite``
    | 505 -> Item.``Adv_ Thermal Defense Suite``
    | 506 -> Item.``Exp_ Thermal Defense Suite``
    | 507 -> Item.``Shock Absorption System``
    | 508 -> Item.``Imp_ Shock Absorption System``
    | 509 -> Item.``Exp_ Shock Absorption System``
    | 510 -> Item.``EM Disruption Field``
    | 511 -> Item.``Adv_ EM Disruption Field``
    | 512 -> Item.``Exp_ EM Disruption Field``
    | 513 -> Item.``ME-RLN's Chromatic Screen``
    | 514 -> Item.``Hardlight Generator``
    | 515 -> Item.``Imp_ Hardlight Generator``
    | 516 -> Item.``Adv_ Hardlight Generator``
    | 517 -> Item.``Exp_ Hardlight Generator``
    | 518 -> Item.``Shield Generator``
    | 519 -> Item.``Imp_ Shield Generator``
    | 520 -> Item.``Adv_ Shield Generator``
    | 521 -> Item.``Exp_ Shield Generator``
    | 522 -> Item.``Force Field``
    | 523 -> Item.``Imp_ Force Field``
    | 524 -> Item.``Adv_ Force Field``
    | 525 -> Item.``Exp_ Force Field``
    | 526 -> Item.``7V-RTL's Ultimate Field``
    | 527 -> Item.``Vortex Field Projector``
    | 528 -> Item.``Remote Shield``
    | 529 -> Item.``Imp_ Remote Shield``
    | 530 -> Item.``Adv_ Remote Shield``
    | 531 -> Item.``Remote Force Field``
    | 532 -> Item.``Imp_ Remote Force Field``
    | 533 -> Item.``Energy Mantle``
    | 534 -> Item.``Imp_ Energy Mantle``
    | 535 -> Item.``AEGIS Remote Shield``
    | 536 -> Item.``Phase Redirector``
    | 537 -> Item.``Point Defense System``
    | 538 -> Item.``Point Defense Array``
    | 539 -> Item.``Antimissile System``
    | 540 -> Item.``EX Chip 1``
    | 541 -> Item.``Hacking Suite``
    | 542 -> Item.``Mak_ Hacking Suite``
    | 543 -> Item.``Imp_ Hacking Suite``
    | 544 -> Item.``Adv_ Hacking Suite``
    | 545 -> Item.``Exp_ Hacking Suite``
    | 546 -> Item.``System Mapper``
    | 547 -> Item.``Deep Network Scanner``
    | 548 -> Item.``Architect God Chip A``
    | 549 -> Item.``EX Chip 2``
    | 550 -> Item.``System Shield``
    | 551 -> Item.``Mak_ System Shield``
    | 552 -> Item.``Imp_ System Shield``
    | 553 -> Item.``Adv_ System Shield``
    | 554 -> Item.``Exp_ System Shield``
    | 555 -> Item.``Ghost Barrier``
    | 556 -> Item.``Quantum Router``
    | 557 -> Item.``Architect God Chip D``
    | 558 -> Item.``Authchip _R_NC_``
    | 559 -> Item.``Authchip _R_Combat_``
    | 560 -> Item.``Authchip _Power_``
    | 561 -> Item.``Authchip _Propulsion_``
    | 562 -> Item.``Authchip _Device_``
    | 563 -> Item.``Authchip _Storage_``
    | 564 -> Item.``Authchip _Processor_``
    | 565 -> Item.``Authchip _Armor_``
    | 566 -> Item.``Authchip _Weapon_``
    | 567 -> Item.``Relay Coupler _NC_``
    | 568 -> Item.``Relay Coupler _C_``
    | 569 -> Item.``Relay Coupler _Swarmer_``
    | 570 -> Item.``Relay Coupler _Cutter_``
    | 571 -> Item.``Relay Coupler _Grunt_``
    | 572 -> Item.``Relay Coupler _Brawler_``
    | 573 -> Item.``Relay Coupler _Duelist_``
    | 574 -> Item.``Relay Coupler _Sentry_``
    | 575 -> Item.``Relay Coupler _Demolisher_``
    | 576 -> Item.``Relay Coupler _Specialist_``
    | 577 -> Item.``Relay Coupler _Hunter_``
    | 578 -> Item.``Relay Coupler _Heavy_``
    | 579 -> Item.``Relay Coupler _Behemoth_``
    | 580 -> Item.``Relay Coupler _Programmer_``
    | 581 -> Item.``Relay Coupler _Proto_``
    | 582 -> Item.``Skeleton Box``
    | 583 -> Item.``01-MTF's Autohacker``
    | 584 -> Item.``Component Analysis Suite``
    | 585 -> Item.``Imp_ Component Analysis Suite``
    | 586 -> Item.``Adv_ Component Analysis Suite``
    | 587 -> Item.``Dynamic Insulation System``
    | 588 -> Item.``Imp_ Dynamic Insulation System``
    | 589 -> Item.``Adv_ Dynamic Insulation System``
    | 590 -> Item.``System Guard``
    | 591 -> Item.``Imp_ System Guard``
    | 592 -> Item.``Exp_ System Guard``
    | 593 -> Item.``Corruption Screen``
    | 594 -> Item.``Imp_ Corruption Screen``
    | 595 -> Item.``Adv_ Corruption Screen``
    | 596 -> Item.``System Restoration Module``
    | 597 -> Item.``Mak_ System Restoration Module``
    | 598 -> Item.``Imp_ System Restoration Module``
    | 599 -> Item.``Adv_ System Restoration Module``
    | 600 -> Item.``System Purifier``
    | 601 -> Item.``Exp_ System Purifier``
    | 602 -> Item.``Tractor Beam``
    | 603 -> Item.``Hpw_ Tractor Beam``
    | 604 -> Item.``Lrn_ Tractor Beam``
    | 605 -> Item.``Mobile Refinery Mk_ CCLXVII``
    | 606 -> Item.``Trap Extractor``
    | 607 -> Item.``Imp_ Trap Extractor``
    | 608 -> Item.``Adv_ Trap Extractor``
    | 609 -> Item.``Trap Reconfigurator``
    | 610 -> Item.``Recalibrator``
    | 611 -> Item.``Imp_ Recalibrator``
    | 612 -> Item.``Adv_ Recalibrator``
    | 613 -> Item.``Field Recycling Unit``
    | 614 -> Item.``Imp_ Field Recycling Unit``
    | 615 -> Item.``Adv_ Field Recycling Unit``
    | 616 -> Item.``Exp_ Field Recycling Unit``
    | 617 -> Item.``Drone Bay``
    | 618 -> Item.``Z-Drone Bay``
    | 619 -> Item.``Mni_ Drone Bay``
    | 620 -> Item.``Mapping Drone Bay``
    | 621 -> Item.``Adv_ Drone Bay``
    | 622 -> Item.``Bomb Drone Bay``
    | 623 -> Item.``Thief Drone Bay``
    | 624 -> Item.``Decoy Drone Bay``
    | 625 -> Item.``Splice Drone Bay``
    | 626 -> Item.``Combat Drone Bay``
    | 627 -> Item.``Assault Drone Bay``
    | 628 -> Item.``Stealth Drone Bay``
    | 629 -> Item.``Swarm Drone Bay``
    | 630 -> Item.``Supersonic Drone Bay``
    | 631 -> Item.``Sensor Drone Bay``
    | 632 -> Item.``Hacking Drone Bay``
    | 633 -> Item.``Minesniffer Drone Bay``
    | 634 -> Item.``Army-in-a-Box``
    | 635 -> Item.``Wardrone Bay``
    | 636 -> Item.``Cobbler Unit``
    | 637 -> Item.``Bomb Factory No_ 2``
    | 638 -> Item.``Mobile Assembly Unit``
    | 639 -> Item.``Heart of Steel``
    | 640 -> Item.``GOLEM Unit``
    | 641 -> Item.``PSU Rigger``
    | 642 -> Item.``Phasing AFG``
    | 643 -> Item.``AS-neutralizer No_ 17b``
    | 644 -> Item.``V3-11A's Pendant``
    | 645 -> Item.``Chronowheel``
    | 646 -> Item.``Power Bank``
    | 647 -> Item.``Rainbow Chip``
    | 648 -> Item.``VL-GR5's Exoskeleton _Deathgrip_``
    | 649 -> Item.``Dimensional Node Initializer``
    | 650 -> Item.``Transdimensional Reconstructor``
    | 651 -> Item.``Hpw_ Transdimensional Reconstructor``
    | 652 -> Item.``Supercharged TR``
    | 653 -> Item.``Core Expander``
    | 654 -> Item.``Core Regenerator``
    | 655 -> Item.``Integrity Redistributor``
    | 656 -> Item.``Integrated Dissipator``
    | 657 -> Item.``Supercharged Integrated Dissipator``
    | 658 -> Item.``Integrated Thermoelectric Network``
    | 659 -> Item.``Integrated Reactor``
    | 660 -> Item.``Supercharged Integrated Reactor``
    | 661 -> Item.``Integrated Mediator``
    | 662 -> Item.``Core Membrane``
    | 663 -> Item.``Navigation Efficiency Matrix``
    | 664 -> Item.``Core Reset Matrix``
    | 665 -> Item.``Subatomic Replicator``
    | 666 -> Item.``Terrabomb``
    | 667 -> Item.``Core Physics Calibrator``
    | 668 -> Item.``Spacefold Activator``
    | 669 -> Item.``Microwarp Drive``
    | 670 -> Item.``LC Capacitor``
    | 671 -> Item.``LRC Armor``
    | 672 -> Item.``LRC Storage``
    | 673 -> Item.``LRC Energy Well``
    | 674 -> Item.``LRC Matter Compressor``
    | 675 -> Item.``LRC Boosters``
    | 676 -> Item.``LRC Insulator``
    | 677 -> Item.``EM Pulse Gun``
    | 678 -> Item.``Hvy_ EM Pulse Gun``
    | 679 -> Item.``EM Shotgun``
    | 680 -> Item.``Imp_ EM Shotgun``
    | 681 -> Item.``Shock Rifle``
    | 682 -> Item.``Riot Gun``
    | 683 -> Item.``Hvy_ EM Shotgun``
    | 684 -> Item.``Lightning Gun``
    | 685 -> Item.``Hvy_ Riot Gun``
    | 686 -> Item.``Arc Projector``
    | 687 -> Item.``Prc_ Shock Rifle``
    | 688 -> Item.``Hpw_ Shock Rifle``
    | 689 -> Item.``Arc Thrower``
    | 690 -> Item.``Imp_ Lightning Gun``
    | 691 -> Item.``Tesla Rifle``
    | 692 -> Item.``Imp_ Arc Projector``
    | 693 -> Item.``Hvy_ Tesla Rifle``
    | 694 -> Item.``Hyp_ EM Gauss Rifle``
    | 695 -> Item.``Imp_ Arc Thrower``
    | 696 -> Item.``01-MTF's Shockpuncher``
    | 697 -> Item.``Gamma Rifle``
    | 698 -> Item.``Tachyon Dispersion Ray``
    | 699 -> Item.``Immobilizer``
    | 700 -> Item.``Modified EM Gauss Rifle``
    | 701 -> Item.``AWS_EX-DEC``
    | 702 -> Item.``Enh_ Gamma Rifle``
    | 703 -> Item.``Med_ Laser``
    | 704 -> Item.``Sml_ Laser``
    | 705 -> Item.``Backup Laser I``
    | 706 -> Item.``Beam Rifle``
    | 707 -> Item.``Particle Gun``
    | 708 -> Item.``Spread Laser``
    | 709 -> Item.``Imp_ Medium Laser``
    | 710 -> Item.``Sub_ Laser``
    | 711 -> Item.``Autobeam``
    | 712 -> Item.``Field Laser``
    | 713 -> Item.``Pulse Rifle``
    | 714 -> Item.``Backup Laser III``
    | 715 -> Item.``Hvy_ Particle Gun``
    | 716 -> Item.``Prc_ Beam Rifle``
    | 717 -> Item.``Adv_ Beam Rifle``
    | 718 -> Item.``Hvy_ Laser``
    | 719 -> Item.``Gatling Laser``
    | 720 -> Item.``Cld_ Pulse Rifle``
    | 721 -> Item.``Hpw_ Field Laser``
    | 722 -> Item.``Imp_ Spread Laser``
    | 723 -> Item.``Mak_ Laser``
    | 724 -> Item.``Plasma Rifle``
    | 725 -> Item.``Thermic Laser``
    | 726 -> Item.``Beamcaster``
    | 727 -> Item.``Force Rifle``
    | 728 -> Item.``Imp_ Heavy Laser``
    | 729 -> Item.``Storm Laser``
    | 730 -> Item.``Zio_ Laser-S``
    | 731 -> Item.``Wave Gun``
    | 732 -> Item.``Variable Charge Gun``
    | 733 -> Item.``Hvy_ Beamcaster``
    | 734 -> Item.``Cld_ Plasma Rifle``
    | 735 -> Item.``Enh_ Force Rifle``
    | 736 -> Item.``Hvy_ Gatling Laser``
    | 737 -> Item.``Zio_ Phaser-S``
    | 738 -> Item.``Phase Gun``
    | 739 -> Item.``Dispersion Rifle``
    | 740 -> Item.``Backup Laser VII``
    | 741 -> Item.``Plasma Storm``
    | 742 -> Item.``Adv_ Plasma Rifle``
    | 743 -> Item.``Hvy_ Wave Gun``
    | 744 -> Item.``Adv_ Variable Charge Gun``
    | 745 -> Item.``Cld_ Phase Gun``
    | 746 -> Item.``Lrn_ Gatling Laser``
    | 747 -> Item.``Warp Gun``
    | 748 -> Item.``Vortex Rifle``
    | 749 -> Item.``Zio_ Laser-M``
    | 750 -> Item.``AWS_Thermal``
    | 751 -> Item.``PD Laser``
    | 752 -> Item.``Quantum Rifle``
    | 753 -> Item.``Prc_ Phase Gun``
    | 754 -> Item.``Hvy_ Dispersion Rifle``
    | 755 -> Item.``Vortex Shotgun``
    | 756 -> Item.``Vortex Rail``
    | 757 -> Item.``Zio_ Phaser-M``
    | 758 -> Item.``Enh_ Quantum Rifle``
    | 759 -> Item.``Zio_ Laser-H``
    | 760 -> Item.``Hvy_ Quantum Rifle``
    | 761 -> Item.``Zio_ Phaser-H``
    | 762 -> Item.``Gatling Beam``
    | 763 -> Item.``Sigix Sheargun``
    | 764 -> Item.``Modified Sigix Sheargun``
    | 765 -> Item.``Lgt_ EM Pulse Cannon``
    | 766 -> Item.``EM Pulse Cannon``
    | 767 -> Item.``Imp_ EM Pulse Cannon``
    | 768 -> Item.``Proton Cannon``
    | 769 -> Item.``Lrn_ Proton Cannon``
    | 770 -> Item.``Disruptor Cannon``
    | 771 -> Item.``Hvy_ Proton Cannon``
    | 772 -> Item.``HERF Cannon``
    | 773 -> Item.``Hvy_ Disruptor Cannon``
    | 774 -> Item.``Cld_ Proton Cannon``
    | 775 -> Item.``Proton Burst Cannon``
    | 776 -> Item.``Com_ HERF Cannon``
    | 777 -> Item.``Latent Energy Streamer``
    | 778 -> Item.``NK-0LA's Tesla Doomcannon``
    | 779 -> Item.``EMDS``
    | 780 -> Item.``Hpw_ Disruptor Cannon``
    | 781 -> Item.``Beam Cannon``
    | 782 -> Item.``Particle Cannon``
    | 783 -> Item.``Adv_ Beam Cannon``
    | 784 -> Item.``Sub_ Beam Cannon``
    | 785 -> Item.``Hvy_ Particle Cannon``
    | 786 -> Item.``Ion Cannon``
    | 787 -> Item.``Plasma Cannon``
    | 788 -> Item.``Hvy_ Ion Cannon``
    | 789 -> Item.``Cld_ Particle Cannon``
    | 790 -> Item.``Phase Cannon``
    | 791 -> Item.``Hvy_ Plasma Cannon``
    | 792 -> Item.``Cld_ Plasma Cannon``
    | 793 -> Item.``Com_ Ion Cannon``
    | 794 -> Item.``Ion Burst Cannon``
    | 795 -> Item.``Adv_ Plasma Cannon``
    | 796 -> Item.``Hvy_ Phase Cannon``
    | 797 -> Item.``Neutron Cannon``
    | 798 -> Item.``Powered Cannon``
    | 799 -> Item.``Matter Neutralizer``
    | 800 -> Item.``Hvy_ Neutron Cannon``
    | 801 -> Item.``Lrn_ Phase Cannon``
    | 802 -> Item.``Cld_ Phase Cannon``
    | 803 -> Item.``Vortex Cannon``
    | 804 -> Item.``Gui_ Plasma Cannon``
    | 805 -> Item.``Nova Cannon``
    | 806 -> Item.``Imp_ Matter Neutralizer``
    | 807 -> Item.``Exp_ Thermic Cannon``
    | 808 -> Item.``Vortex Driver``
    | 809 -> Item.``Zio_ Alpha Cannon``
    | 810 -> Item.``Asb_ Focal Cannon``
    | 811 -> Item.``Enh_ Nova Cannon``
    | 812 -> Item.``Firepult``
    | 813 -> Item.``YOLO Cannon``
    | 814 -> Item.``Potential Cannon``
    | 815 -> Item.``Warp Cannon``
    | 816 -> Item.``Cld_ Nova Cannon``
    | 817 -> Item.``Null Cannon``
    | 818 -> Item.``Imp_ Potential Cannon``
    | 819 -> Item.``Multinova Projection Cannon``
    | 820 -> Item.``Disintegrator``
    | 821 -> Item.``Core Cannon``
    | 822 -> Item.``Sigix Shearcannon``
    | 823 -> Item.``Drained L-Cannon``
    | 824 -> Item.``L-Cannon``
    | 825 -> Item.``Zio_ Alpha Cannon Mk_ II``
    | 826 -> Item.``BFG-9k Vortex Edition``
    | 827 -> Item.``Assault Rifle``
    | 828 -> Item.``Asb_ Rifle``
    | 829 -> Item.``Lgt_ Assault Rifle``
    | 830 -> Item.``Hvy_ Assault Rifle``
    | 831 -> Item.``Autogun``
    | 832 -> Item.``Shotgun``
    | 833 -> Item.``Battle Rifle``
    | 834 -> Item.``Asb_ Heavy Rifle``
    | 835 -> Item.``Sub_ Machine Gun``
    | 836 -> Item.``Imp_ Assault Rifle``
    | 837 -> Item.``Minigun``
    | 838 -> Item.``Hpw_ Shotgun``
    | 839 -> Item.``Asb_ Shotgun``
    | 840 -> Item.``Barrage Gun``
    | 841 -> Item.``Enh_ Autogun``
    | 842 -> Item.``Gauss Rifle``
    | 843 -> Item.``Asb_ Gauss Rifle``
    | 844 -> Item.``Flak Gun``
    | 845 -> Item.``Prc_ Assault Rifle``
    | 846 -> Item.``Hvy_ Battle Rifle``
    | 847 -> Item.``Mak_ Shrapnel Gun``
    | 848 -> Item.``Coil Gun``
    | 849 -> Item.``Hyp_ Gauss Rifle``
    | 850 -> Item.``Hvy_ Machine Gun``
    | 851 -> Item.``Imp_ Heavy Machine Gun``
    | 852 -> Item.``Com_ Gauss Rifle``
    | 853 -> Item.``XL Autogun Subcomponent``
    | 854 -> Item.``KE Penetrator``
    | 855 -> Item.``Hyp_ Coil Gun``
    | 856 -> Item.``Imp_ KE Penetrator``
    | 857 -> Item.``Enh_ Coil Gun``
    | 858 -> Item.``Com_ Coil Gun``
    | 859 -> Item.``Railgun``
    | 860 -> Item.``Adv_ KE Penetrator``
    | 861 -> Item.``Linked Autogun``
    | 862 -> Item.``AWS_Gauss``
    | 863 -> Item.``Hyp_ Railgun``
    | 864 -> Item.``Helical Railgun``
    | 865 -> Item.``Com_ Railgun``
    | 866 -> Item.``XL Autogun Array``
    | 867 -> Item.``12-ASH's Boomstick``
    | 868 -> Item.``8R-AWN's Boregun``
    | 869 -> Item.``Multirail``
    | 870 -> Item.``Hyp_ Multirail``
    | 871 -> Item.``5H-AD0's Sniper Rifle``
    | 872 -> Item.``A3's Sniper Rifle``
    | 873 -> Item.``Lgt_ Cannon``
    | 874 -> Item.``Imp_ Light Cannon``
    | 875 -> Item.``Battle Cannon``
    | 876 -> Item.``Assault Cannon``
    | 877 -> Item.``Hvy_ Assault Cannon``
    | 878 -> Item.``Flak Cannon``
    | 879 -> Item.``Adv_ Assault Cannon``
    | 880 -> Item.``Gauss Cannon``
    | 881 -> Item.``Slug Cannon``
    | 882 -> Item.``Mni_ Assault Cannon``
    | 883 -> Item.``Magnetic Acceleration Cannon``
    | 884 -> Item.``Hvy_ Flak Cannon``
    | 885 -> Item.``Bore Cannon``
    | 886 -> Item.``Antimatter Cannon``
    | 887 -> Item.``Mass Driver``
    | 888 -> Item.``Hvy_ Mass Driver``
    | 889 -> Item.``Enh_ Gauss Cannon``
    | 890 -> Item.``Hyp_ Gauss Cannon``
    | 891 -> Item.``Tri-rail Accelerator``
    | 892 -> Item.``Hardcell Cannon``
    | 893 -> Item.``Hvy_ Gauss Cannon``
    | 894 -> Item.``Hyp_ Mass Driver``
    | 895 -> Item.``Hvy_ Autocannon``
    | 896 -> Item.``DAS Cannon``
    | 897 -> Item.``Lgt_ Antimatter Cannon``
    | 898 -> Item.``Linear Accelerator``
    | 899 -> Item.``Hvy_ Linear Accelerator``
    | 900 -> Item.``Com_ Mass Driver``
    | 901 -> Item.``Hvy_ Hardcell Cannon``
    | 902 -> Item.``Com_ Linear Accelerator``
    | 903 -> Item.``Hyp_ Linear Accelerator``
    | 904 -> Item.``Hcl_ Linear Accelerator``
    | 905 -> Item.``Graviton Cannon``
    | 906 -> Item.``Blast Cannon``
    | 907 -> Item.``P1-3CE's Gatling Flakker``
    | 908 -> Item.``AWS_Autocannon``
    | 909 -> Item.``Perforator``
    | 910 -> Item.``Omega Cannon``
    | 911 -> Item.``EMP Blaster``
    | 912 -> Item.``Shock Bomb Launcher``
    | 913 -> Item.``Adv_ EMP Blaster``
    | 914 -> Item.``Proton Missile Launcher``
    | 915 -> Item.``Imp_ Proton Missile Launcher``
    | 916 -> Item.``Gui_ EMP Blaster``
    | 917 -> Item.``Hvy_ Shock Bomb Launcher``
    | 918 -> Item.``Tesla Bomb Launcher``
    | 919 -> Item.``Hvy_ Proton Missile Launcher``
    | 920 -> Item.``Com_ Tesla Bomb Launcher``
    | 921 -> Item.``Gamma Bomb Array``
    | 922 -> Item.``Enh_ Gamma Bomb Array``
    | 923 -> Item.``Grenade Launcher``
    | 924 -> Item.``Rocket Launcher``
    | 925 -> Item.``Mni_ Grenade Launcher``
    | 926 -> Item.``Sub_ Shrapnel Launcher``
    | 927 -> Item.``Imp_ Grenade Launcher``
    | 928 -> Item.``Missile Launcher``
    | 929 -> Item.``Concussive RPG``
    | 930 -> Item.``YI-UF0's Doublenader``
    | 931 -> Item.``Hvy_ Rocket Launcher``
    | 932 -> Item.``Hvy_ Missile Launcher``
    | 933 -> Item.``Gui_ Missile Launcher``
    | 934 -> Item.``Prc_ Grenade Launcher``
    | 935 -> Item.``Rocket Array``
    | 936 -> Item.``Lrn_ Missile Launcher``
    | 937 -> Item.``Imp_ Concussive RPG``
    | 938 -> Item.``Prc_ Rocket Launcher``
    | 939 -> Item.``Scatter Rocket Array``
    | 940 -> Item.``Smartbomb Launcher``
    | 941 -> Item.``Mni_ Smartbomb Launcher``
    | 942 -> Item.``Tiamat Missile Launcher``
    | 943 -> Item.``Thermoblaster``
    | 944 -> Item.``Micro-nuke Launcher``
    | 945 -> Item.``Adv_ Concussive RPG``
    | 946 -> Item.``Neutron Missile Launcher``
    | 947 -> Item.``Fusion Bomb Launcher``
    | 948 -> Item.``Hellfire Missile Launcher``
    | 949 -> Item.``Adv_ Micro-nuke Launcher``
    | 950 -> Item.``Tactical Quantum Warhead``
    | 951 -> Item.``Vortex Catalyst Activator``
    | 952 -> Item.``Chain Missile Launcher``
    | 953 -> Item.``Ragnarok Missile Launcher``
    | 954 -> Item.``Point Singularity Launcher``
    | 955 -> Item.``Gui_ Micro-nuke Launcher``
    | 956 -> Item.``99-TNT's Nukerbomber``
    | 957 -> Item.``Z-bomb Delivery System``
    | 958 -> Item.``Sigix Terminator``
    | 959 -> Item.``Supercharged Sigix Terminator``
    | 960 -> Item.``Containment Facilitator``
    | 961 -> Item.``Detonator``
    | 962 -> Item.``Dirty Datajack``
    | 963 -> Item.``Splice Injector``
    | 964 -> Item.``Datajack``
    | 965 -> Item.``Imp_ Datajack``
    | 966 -> Item.``Adv_ Datajack``
    | 967 -> Item.``Remote Datajack``
    | 968 -> Item.``Imp_ Remote Datajack``
    | 969 -> Item.``Adv_ Remote Datajack``
    | 970 -> Item.``Exp_ Remote Datajack``
    | 971 -> Item.``Gui_ Remote Datajack``
    | 972 -> Item.``ME-RLN's Wand``
    | 973 -> Item.``Field Lobotomy Kit``
    | 974 -> Item.``Mining Laser``
    | 975 -> Item.``Welding Torch``
    | 976 -> Item.``Plasma Cutter``
    | 977 -> Item.``Imp_ Plasma Cutter``
    | 978 -> Item.``CPS Tube``
    | 979 -> Item.``Multitool``
    | 980 -> Item.``Flamer``
    | 981 -> Item.``Asb_ F-torch``
    | 982 -> Item.``Enh_ Flamer``
    | 983 -> Item.``Plasma Flamer``
    | 984 -> Item.``Asb_ P-torch``
    | 985 -> Item.``RU-N14's Throwing Claymores``
    | 986 -> Item.``RU-N14's Throwing Claymores v3``
    | 987 -> Item.``AD-0RF's Magmablaster``
    | 988 -> Item.``Stasis Beam``
    | 989 -> Item.``Stasis Projector``
    | 990 -> Item.``Exp_ Stasis Projector``
    | 991 -> Item.``Molecular Deconstructor``
    | 992 -> Item.``SE_WE1``
    | 993 -> Item.``SE_WE2``
    | 994 -> Item.``SE_WE3``
    | 995 -> Item.``SE_WE4``
    | 996 -> Item.``SE_WE5``
    | 997 -> Item.``Hammer``
    | 998 -> Item.``Mace``
    | 999 -> Item.``Flail``
    | 1000 -> Item.``Maul``
    | 1001 -> Item.``Asb_ Maul``
    | 1002 -> Item.``Hvy_ Hammer``
    | 1003 -> Item.``Hvy_ Mace``
    | 1004 -> Item.``Hvy_ Flail``
    | 1005 -> Item.``Great Maul``
    | 1006 -> Item.``Powered Hammer``
    | 1007 -> Item.``Mak_ Hammer``
    | 1008 -> Item.``Power Maul``
    | 1009 -> Item.``Asb_ P-maul``
    | 1010 -> Item.``Impact Mace``
    | 1011 -> Item.``Shock Maul``
    | 1012 -> Item.``Thunder Hammer``
    | 1013 -> Item.``Compactor``
    | 1014 -> Item.``Gravity Flail``
    | 1015 -> Item.``CL-ANK's Mallet``
    | 1016 -> Item.``Core Stripper``
    | 1017 -> Item.``Mining Claw``
    | 1018 -> Item.``EC_1``
    | 1019 -> Item.``Katana``
    | 1020 -> Item.``Asb_ Blade``
    | 1021 -> Item.``Scythe``
    | 1022 -> Item.``Axe``
    | 1023 -> Item.``Blade Saw``
    | 1024 -> Item.``EC_3``
    | 1025 -> Item.``Chainsword``
    | 1026 -> Item.``Ripper``
    | 1027 -> Item.``Mak_ Axe``
    | 1028 -> Item.``Mak_ Sword``
    | 1029 -> Item.``Great Axe``
    | 1030 -> Item.``Greatsword``
    | 1031 -> Item.``Power Sword``
    | 1032 -> Item.``Asb_ P-sword``
    | 1033 -> Item.``Falx``
    | 1034 -> Item.``Carbide Saw``
    | 1035 -> Item.``Segregator``
    | 1036 -> Item.``Tearclaws``
    | 1037 -> Item.``EC_5``
    | 1038 -> Item.``Phasing Sabre``
    | 1039 -> Item.``Plasma Sword``
    | 1040 -> Item.``Ionic Axe``
    | 1041 -> Item.``Mni_ Tearclaws``
    | 1042 -> Item.``Dual-blade Saw``
    | 1043 -> Item.``Vibroblade``
    | 1044 -> Item.``Molecular Scythe``
    | 1045 -> Item.``Centrium Greatsword``
    | 1046 -> Item.``Master Tearclaws``
    | 1047 -> Item.``Longsword _1``
    | 1048 -> Item.``EC_7``
    | 1049 -> Item.``Nanosword``
    | 1050 -> Item.``Particle Cleaver``
    | 1051 -> Item.``Centrium Claws``
    | 1052 -> Item.``1C-UTU's Sword _Lootmaker_``
    | 1053 -> Item.``1C-UTU's Sword _Choppy_``
    | 1054 -> Item.``Vortex Shredder``
    | 1055 -> Item.``EC_9``
    | 1056 -> Item.``Sigix Broadsword``
    | 1057 -> Item.``Spear``
    | 1058 -> Item.``Mak_ Spear``
    | 1059 -> Item.``CR-A16's Pointy Stick``
    | 1060 -> Item.``Hvy_ Pick``
    | 1061 -> Item.``Lance``
    | 1062 -> Item.``Kinetic Spear``
    | 1063 -> Item.``Force Lance``
    | 1064 -> Item.``Plasma Lance``
    | 1065 -> Item.``Enh_ Force Lance``
    | 1066 -> Item.``Vortex Lance``
    | 1067 -> Item.``CR-A16's Behemoth Slayer``
    | 1068 -> Item.``Blade Trap``
    | 1069 -> Item.``Segregator Trap``
    | 1070 -> Item.``Explosive Trap``
    | 1071 -> Item.``Heavy Explosive Trap``
    | 1072 -> Item.``Tiamat Bomb Trap``
    | 1073 -> Item.``Fusion Bomb Trap``
    | 1074 -> Item.``Hellfire Trap``
    | 1075 -> Item.``Armageddon Trap``
    | 1076 -> Item.``Dirty Bomb Trap``
    | 1077 -> Item.``EMP Trap``
    | 1078 -> Item.``Proton Bomb Trap``
    | 1079 -> Item.``Tesla Bomb Trap``
    | 1080 -> Item.``Gamma Bomb Trap``
    | 1081 -> Item.``Shrapnel Trap``
    | 1082 -> Item.``Piercing Trap``
    | 1083 -> Item.``Shock Trap``
    | 1084 -> Item.``EM Surge Trap``
    | 1085 -> Item.``Fire Trap``
    | 1086 -> Item.``Stasis Trap``
    | 1087 -> Item.``Scrap Shield Fragment``
    | 1088 -> Item.``Signal Generator``
    | 1089 -> Item.``Self-destruct Interrupter``
    | 1090 -> Item.``Sapper Charge``
    | 1091 -> Item.``Zhirov Special``
    | 1092 -> Item.``Deploy-a-Sentry``
    | 1093 -> Item.``GAL Module``
    | 1094 -> Item.``Portable AFG``
    | 1095 -> Item.``SGEMP Prototype``
    | 1096 -> Item.``Terrabomb Derivative``
    | 1097 -> Item.``Sigix Containment Pod``
    | 1098 -> Item.``Sigix Corpse``
    | 1099 -> Item.``Meganuke``
    | 1100 -> Item.``Gamma Refractor``
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
    | Item.``MAIN_C Data Core`` -> "MAIN_C Data Core"
    | Item.``Architect Data Core`` -> "Architect Data Core"
    | Item.``Scrap`` -> "Scrap"
    | Item.``Protomatter`` -> "Protomatter"
    | Item.``Ion Engine`` -> "Ion Engine"
    | Item.``Lgt_ Ion Engine`` -> "Lgt_ Ion Engine"
    | Item.``Backup Power I`` -> "Backup Power I"
    | Item.``Imp_ Ion Engine`` -> "Imp_ Ion Engine"
    | Item.``Rnf_ Ion Engine`` -> "Rnf_ Ion Engine"
    | Item.``Hvy_ Ion Engine`` -> "Hvy_ Ion Engine"
    | Item.``Cld_ Ion Engine`` -> "Cld_ Ion Engine"
    | Item.``Sub_ Power Source`` -> "Sub_ Power Source"
    | Item.``Deuterium Engine`` -> "Deuterium Engine"
    | Item.``Lgt_ Deuterium Engine`` -> "Lgt_ Deuterium Engine"
    | Item.``Backup Power III`` -> "Backup Power III"
    | Item.``Nuclear Core`` -> "Nuclear Core"
    | Item.``Lgt_ Nuclear Core`` -> "Lgt_ Nuclear Core"
    | Item.``Imp_ Deuterium Engine`` -> "Imp_ Deuterium Engine"
    | Item.``Rnf_ Deuterium Engine`` -> "Rnf_ Deuterium Engine"
    | Item.``Hyb_ Deuterium Engine`` -> "Hyb_ Deuterium Engine"
    | Item.``Hvy_ Deuterium Engine`` -> "Hvy_ Deuterium Engine"
    | Item.``Cld_ Deuterium Engine`` -> "Cld_ Deuterium Engine"
    | Item.``Enh_ Nuclear Core`` -> "Enh_ Nuclear Core"
    | Item.``Mic_ Nuclear Core`` -> "Mic_ Nuclear Core"
    | Item.``Mak_ Power Source`` -> "Mak_ Power Source"
    | Item.``Angular Momentum Engine`` -> "Angular Momentum Engine"
    | Item.``Lgt_ Angular Momentum Engine`` -> "Lgt_ Angular Momentum Engine"
    | Item.``F-cell Engine`` -> "F-cell Engine"
    | Item.``Fission Core`` -> "Fission Core"
    | Item.``Lgt_ Fission Core`` -> "Lgt_ Fission Core"
    | Item.``Hyb_ Fission Core`` -> "Hyb_ Fission Core"
    | Item.``Fusion Compressor`` -> "Fusion Compressor"
    | Item.``Cold Fusion Reactor`` -> "Cold Fusion Reactor"
    | Item.``Neutrino Core`` -> "Neutrino Core"
    | Item.``Lgt_ Neutrino Core`` -> "Lgt_ Neutrino Core"
    | Item.``Rnf_ Fission Core`` -> "Rnf_ Fission Core"
    | Item.``Enh_ Fission Core`` -> "Enh_ Fission Core"
    | Item.``Cld_ Fission Core`` -> "Cld_ Fission Core"
    | Item.``Mic_ Fission Core`` -> "Mic_ Fission Core"
    | Item.``Fusion Reactor`` -> "Fusion Reactor"
    | Item.``Antimatter Reactor`` -> "Antimatter Reactor"
    | Item.``Lgt_ Antimatter Reactor`` -> "Lgt_ Antimatter Reactor"
    | Item.``Rnf_ Antimatter Reactor`` -> "Rnf_ Antimatter Reactor"
    | Item.``Hyb_ Antimatter Reactor`` -> "Hyb_ Antimatter Reactor"
    | Item.``Backup Power VII`` -> "Backup Power VII"
    | Item.``Hvy_ Antimatter Reactor`` -> "Hvy_ Antimatter Reactor"
    | Item.``Mni_ Fusion Reactor`` -> "Mni_ Fusion Reactor"
    | Item.``Imp_ Fusion Compressor`` -> "Imp_ Fusion Compressor"
    | Item.``Mic_ Neutrino Core`` -> "Mic_ Neutrino Core"
    | Item.``Zio_ Light DM Reactor`` -> "Zio_ Light DM Reactor"
    | Item.``Zio_ Heavy DM Reactor`` -> "Zio_ Heavy DM Reactor"
    | Item.``Particle Reactor`` -> "Particle Reactor"
    | Item.``Lgt_ Particle Reactor`` -> "Lgt_ Particle Reactor"
    | Item.``Mic_ Antimatter Reactor`` -> "Mic_ Antimatter Reactor"
    | Item.``Com_ Particle Reactor`` -> "Com_ Particle Reactor"
    | Item.``Cld_ Antimatter Reactor`` -> "Cld_ Antimatter Reactor"
    | Item.``Graviton Reactor`` -> "Graviton Reactor"
    | Item.``Asb_ Flux Generator`` -> "Asb_ Flux Generator"
    | Item.``Quantum Reactor`` -> "Quantum Reactor"
    | Item.``Lgt_ Quantum Reactor`` -> "Lgt_ Quantum Reactor"
    | Item.``Rnf_ Quantum Reactor`` -> "Rnf_ Quantum Reactor"
    | Item.``Imp_ Quantum Reactor`` -> "Imp_ Quantum Reactor"
    | Item.``Zero-point Reactor`` -> "Zero-point Reactor"
    | Item.``Vortex Chain Reactor`` -> "Vortex Chain Reactor"
    | Item.``Singularity Reactor`` -> "Singularity Reactor"
    | Item.``Matter Drive`` -> "Matter Drive"
    | Item.``Meta Core`` -> "Meta Core"
    | Item.``SE_PO1`` -> "SE_PO1"
    | Item.``Lgt_ Treads`` -> "Lgt_ Treads"
    | Item.``Imp_ Treads`` -> "Imp_ Treads"
    | Item.``Spk_ Treads`` -> "Spk_ Treads"
    | Item.``Arm_ Treads`` -> "Arm_ Treads"
    | Item.``Adv_ Treads`` -> "Adv_ Treads"
    | Item.``Med_ Treads`` -> "Med_ Treads"
    | Item.``Imp_ Medium Treads`` -> "Imp_ Medium Treads"
    | Item.``Spk_ Medium Treads`` -> "Spk_ Medium Treads"
    | Item.``Arm_ Medium Treads`` -> "Arm_ Medium Treads"
    | Item.``Hvy_ Treads`` -> "Hvy_ Treads"
    | Item.``Adv_ Medium Treads`` -> "Adv_ Medium Treads"
    | Item.``Enh_ Armored Medium Treads`` -> "Enh_ Armored Medium Treads"
    | Item.``Imp_ Heavy Treads`` -> "Imp_ Heavy Treads"
    | Item.``Hvy_ Siege Treads`` -> "Hvy_ Siege Treads"
    | Item.``Spk_ Heavy Treads`` -> "Spk_ Heavy Treads"
    | Item.``Biometal Medium Treads`` -> "Biometal Medium Treads"
    | Item.``Arm_ Heavy Treads`` -> "Arm_ Heavy Treads"
    | Item.``Adv_ Heavy Treads`` -> "Adv_ Heavy Treads"
    | Item.``Imp_ Heavy Siege Treads`` -> "Imp_ Heavy Siege Treads"
    | Item.``Centrium Heavy Treads`` -> "Centrium Heavy Treads"
    | Item.``Megatreads`` -> "Megatreads"
    | Item.``Biometal Heavy Treads`` -> "Biometal Heavy Treads"
    | Item.``Exp_ Biometal Heavy Treads`` -> "Exp_ Biometal Heavy Treads"
    | Item.``Enh_ Armored Heavy Treads`` -> "Enh_ Armored Heavy Treads"
    | Item.``Adv_ Heavy Siege Treads`` -> "Adv_ Heavy Siege Treads"
    | Item.``Hdn_ Centrium Heavy Treads`` -> "Hdn_ Centrium Heavy Treads"
    | Item.``Exp_ Biometal Medium Treads`` -> "Exp_ Biometal Medium Treads"
    | Item.``Aluminum Leg`` -> "Aluminum Leg"
    | Item.``Imp_ Aluminum Leg`` -> "Imp_ Aluminum Leg"
    | Item.``Carbon-fiber Leg`` -> "Carbon-fiber Leg"
    | Item.``Titanium Leg`` -> "Titanium Leg"
    | Item.``VSS Leg`` -> "VSS Leg"
    | Item.``Imp_ Carbon-fiber Leg`` -> "Imp_ Carbon-fiber Leg"
    | Item.``Imp_ Titanium Leg`` -> "Imp_ Titanium Leg"
    | Item.``Lgt_ Armored Exoskeleton`` -> "Lgt_ Armored Exoskeleton"
    | Item.``Mak_ Leg`` -> "Mak_ Leg"
    | Item.``Flexi-carbon Leg`` -> "Flexi-carbon Leg"
    | Item.``Arm_ Leg`` -> "Arm_ Leg"
    | Item.``Imp_ VSS Leg`` -> "Imp_ VSS Leg"
    | Item.``Zio_ Composite Leg I`` -> "Zio_ Composite Leg I"
    | Item.``Med_ Armored Exoskeleton`` -> "Med_ Armored Exoskeleton"
    | Item.``Enh_ Flexi-carbon Leg`` -> "Enh_ Flexi-carbon Leg"
    | Item.``Enh_ Armored Leg`` -> "Enh_ Armored Leg"
    | Item.``Arachnoskeleton`` -> "Arachnoskeleton"
    | Item.``Myomer Leg`` -> "Myomer Leg"
    | Item.``Adv_ VSS Leg`` -> "Adv_ VSS Leg"
    | Item.``Adv_ Myomer Leg`` -> "Adv_ Myomer Leg"
    | Item.``Exp_ Flexi-carbon Leg`` -> "Exp_ Flexi-carbon Leg"
    | Item.``Zio_ Composite Leg II`` -> "Zio_ Composite Leg II"
    | Item.``Cargo Legs`` -> "Cargo Legs"
    | Item.``Etherial Tendrils`` -> "Etherial Tendrils"
    | Item.``Biometal Leg`` -> "Biometal Leg"
    | Item.``Hvy_ Armored Exoskeleton`` -> "Hvy_ Armored Exoskeleton"
    | Item.``Enh_ Biometal Leg`` -> "Enh_ Biometal Leg"
    | Item.``Exp_ Myomer Leg`` -> "Exp_ Myomer Leg"
    | Item.``Tripod Weapons Platform`` -> "Tripod Weapons Platform"
    | Item.``T_R_O_L_L_ Exoskeleton`` -> "T_R_O_L_L_ Exoskeleton"
    | Item.``Asb_ Alloy Leg`` -> "Asb_ Alloy Leg"
    | Item.``Centrium Leg`` -> "Centrium Leg"
    | Item.``Hdn_ Centrium Leg`` -> "Hdn_ Centrium Leg"
    | Item.``Exp_ Biometal Leg`` -> "Exp_ Biometal Leg"
    | Item.``Sigix Exoskeleton`` -> "Sigix Exoskeleton"
    | Item.``Zio_ Supercomposite Leg`` -> "Zio_ Supercomposite Leg"
    | Item.``Potential Leg`` -> "Potential Leg"
    | Item.``Myomer Exoskeleton`` -> "Myomer Exoskeleton"
    | Item.``SE_PR1`` -> "SE_PR1"
    | Item.``Wheel`` -> "Wheel"
    | Item.``Com_ Wheel`` -> "Com_ Wheel"
    | Item.``Arm_ Wheel`` -> "Arm_ Wheel"
    | Item.``Sub_ Monowheel`` -> "Sub_ Monowheel"
    | Item.``Arm_ Huge Wheel`` -> "Arm_ Huge Wheel"
    | Item.``Centrium Wheel`` -> "Centrium Wheel"
    | Item.``Hdn_ Centrium Wheel`` -> "Hdn_ Centrium Wheel"
    | Item.``Hover Unit`` -> "Hover Unit"
    | Item.``Backup Propulsion I`` -> "Backup Propulsion I"
    | Item.``Imp_ Hover Unit`` -> "Imp_ Hover Unit"
    | Item.``Airjet`` -> "Airjet"
    | Item.``Aerolev Unit`` -> "Aerolev Unit"
    | Item.``Asb_ Hover Unit`` -> "Asb_ Hover Unit"
    | Item.``Backup Propulsion III`` -> "Backup Propulsion III"
    | Item.``Gravmag System`` -> "Gravmag System"
    | Item.``Asb_ Hover System`` -> "Asb_ Hover System"
    | Item.``Imp_ Airjet`` -> "Imp_ Airjet"
    | Item.``Cld_ Airjet`` -> "Cld_ Airjet"
    | Item.``Imp_ Gravmag System`` -> "Imp_ Gravmag System"
    | Item.``Cld_ Aerolev Unit`` -> "Cld_ Aerolev Unit"
    | Item.``Cmb_ Airjet`` -> "Cmb_ Airjet"
    | Item.``Gravmag Array`` -> "Gravmag Array"
    | Item.``Mak_ Hover Unit`` -> "Mak_ Hover Unit"
    | Item.``Zio_ Glidesys I`` -> "Zio_ Glidesys I"
    | Item.``Antigrav System`` -> "Antigrav System"
    | Item.``Gyrokinetic Inverter`` -> "Gyrokinetic Inverter"
    | Item.``Linear Gravjet`` -> "Linear Gravjet"
    | Item.``Cld_ Gravmag System`` -> "Cld_ Gravmag System"
    | Item.``Cmb_ Gravmag System`` -> "Cmb_ Gravmag System"
    | Item.``Imp_ Antigrav System`` -> "Imp_ Antigrav System"
    | Item.``Imp_ Gyrokinetic Inverter`` -> "Imp_ Gyrokinetic Inverter"
    | Item.``Imp_ Linear Gravjet`` -> "Imp_ Linear Gravjet"
    | Item.``Backup Propulsion VII`` -> "Backup Propulsion VII"
    | Item.``Zio_ Glidesys II`` -> "Zio_ Glidesys II"
    | Item.``Cld_ Antigrav System`` -> "Cld_ Antigrav System"
    | Item.``Cmb_ Antigrav System`` -> "Cmb_ Antigrav System"
    | Item.``Antigrav Array`` -> "Antigrav Array"
    | Item.``Exp_ Gyrokinetic Inverter`` -> "Exp_ Gyrokinetic Inverter"
    | Item.``Cld_ Linear Gravjet`` -> "Cld_ Linear Gravjet"
    | Item.``Cmb_ Linear Gravjet`` -> "Cmb_ Linear Gravjet"
    | Item.``Flight Unit`` -> "Flight Unit"
    | Item.``VTOL Module`` -> "VTOL Module"
    | Item.``Imp_ Flight Unit`` -> "Imp_ Flight Unit"
    | Item.``Cesium-ion Thruster`` -> "Cesium-ion Thruster"
    | Item.``Surge Thruster`` -> "Surge Thruster"
    | Item.``Imp_ VTOL Module`` -> "Imp_ VTOL Module"
    | Item.``Xenon Bombardment Thruster`` -> "Xenon Bombardment Thruster"
    | Item.``Imp_ Cesium-ion Thruster`` -> "Imp_ Cesium-ion Thruster"
    | Item.``Cld_ VTOL Module`` -> "Cld_ VTOL Module"
    | Item.``Mak_ Flight Unit`` -> "Mak_ Flight Unit"
    | Item.``Nuclear Pulse Thruster`` -> "Nuclear Pulse Thruster"
    | Item.``Imp_ Surge Thruster`` -> "Imp_ Surge Thruster"
    | Item.``Mni_ Nuclear Pulse Thruster`` -> "Mni_ Nuclear Pulse Thruster"
    | Item.``Cld_ Cesium-ion Thruster`` -> "Cld_ Cesium-ion Thruster"
    | Item.``Biomechanical Wings`` -> "Biomechanical Wings"
    | Item.``Field Propulsion Drive`` -> "Field Propulsion Drive"
    | Item.``Cld_ Nuclear Pulse Thruster`` -> "Cld_ Nuclear Pulse Thruster"
    | Item.``Exp_ Cesium-ion Thruster`` -> "Exp_ Cesium-ion Thruster"
    | Item.``Nuclear Pulse Array`` -> "Nuclear Pulse Array"
    | Item.``Mak_ Microthruster`` -> "Mak_ Microthruster"
    | Item.``Impulse Thruster`` -> "Impulse Thruster"
    | Item.``Adv_ Surge Thruster`` -> "Adv_ Surge Thruster"
    | Item.``Cld_ Field Propulsion Drive`` -> "Cld_ Field Propulsion Drive"
    | Item.``Field Propulsion Array`` -> "Field Propulsion Array"
    | Item.``Diametric Drive`` -> "Diametric Drive"
    | Item.``Flying Fortress v7`` -> "Flying Fortress v7"
    | Item.``T-thruster`` -> "T-thruster"
    | Item.``Integrated Tracker Drive`` -> "Integrated Tracker Drive"
    | Item.``Etherial Propulsion`` -> "Etherial Propulsion"
    | Item.``Q-thruster`` -> "Q-thruster"
    | Item.``Electron Diverter`` -> "Electron Diverter"
    | Item.``Imp_ Diametric Drive`` -> "Imp_ Diametric Drive"
    | Item.``Cld_ Impulse Thruster`` -> "Cld_ Impulse Thruster"
    | Item.``Impulse Thruster Array`` -> "Impulse Thruster Array"
    | Item.``Flightbrick`` -> "Flightbrick"
    | Item.``Imp_ Q-thruster`` -> "Imp_ Q-thruster"
    | Item.``Cld_ Q-thruster`` -> "Cld_ Q-thruster"
    | Item.``Exp_ Q-thruster`` -> "Exp_ Q-thruster"
    | Item.``Scrap Engine`` -> "Scrap Engine"
    | Item.``Arm_ Scrap Engine`` -> "Arm_ Scrap Engine"
    | Item.``Desublimator`` -> "Desublimator"
    | Item.``Power Amplifier`` -> "Power Amplifier"
    | Item.``Adv_ Power Amplifier`` -> "Adv_ Power Amplifier"
    | Item.``Exp_ Power Amplifier`` -> "Exp_ Power Amplifier"
    | Item.``Thermal Generator`` -> "Thermal Generator"
    | Item.``Imp_ Thermal Generator`` -> "Imp_ Thermal Generator"
    | Item.``Adv_ Thermal Generator`` -> "Adv_ Thermal Generator"
    | Item.``Exp_ Thermal Generator`` -> "Exp_ Thermal Generator"
    | Item.``Cryofiber Web`` -> "Cryofiber Web"
    | Item.``Imp_ Cryofiber Web`` -> "Imp_ Cryofiber Web"
    | Item.``Adv_ Cryofiber Web`` -> "Adv_ Cryofiber Web"
    | Item.``Exp_ Cryofiber Web`` -> "Exp_ Cryofiber Web"
    | Item.``Heat Sink`` -> "Heat Sink"
    | Item.``Imp_ Heat Sink`` -> "Imp_ Heat Sink"
    | Item.``Adv_ Heat Sink`` -> "Adv_ Heat Sink"
    | Item.``Exp_ Heat Sink`` -> "Exp_ Heat Sink"
    | Item.``Cooling System`` -> "Cooling System"
    | Item.``Imp_ Cooling System`` -> "Imp_ Cooling System"
    | Item.``Adv_ Cooling System`` -> "Adv_ Cooling System"
    | Item.``Exp_ Cooling System`` -> "Exp_ Cooling System"
    | Item.``Coolant Network`` -> "Coolant Network"
    | Item.``Asb_ Nanovents`` -> "Asb_ Nanovents"
    | Item.``2N-1CE's Frost Array`` -> "2N-1CE's Frost Array"
    | Item.``Disposable Heat Sink`` -> "Disposable Heat Sink"
    | Item.``Coolant Injector`` -> "Coolant Injector"
    | Item.``Imp_ Coolant Injector`` -> "Imp_ Coolant Injector"
    | Item.``Adv_ Coolant Injector`` -> "Adv_ Coolant Injector"
    | Item.``Exp_ Coolant Injector`` -> "Exp_ Coolant Injector"
    | Item.``Sml_ Storage Unit`` -> "Sml_ Storage Unit"
    | Item.``Med_ Storage Unit`` -> "Med_ Storage Unit"
    | Item.``Lrg_ Storage Unit`` -> "Lrg_ Storage Unit"
    | Item.``Hcp_ Storage Unit`` -> "Hcp_ Storage Unit"
    | Item.``Huge Storage Unit`` -> "Huge Storage Unit"
    | Item.``Cargo Storage Unit`` -> "Cargo Storage Unit"
    | Item.``Humpback`` -> "Humpback"
    | Item.``Lightpack 2_0`` -> "Lightpack 2_0"
    | Item.``Sml_ Battery`` -> "Sml_ Battery"
    | Item.``Med_ Battery`` -> "Med_ Battery"
    | Item.``Lrg_ Battery`` -> "Lrg_ Battery"
    | Item.``Hcp_ Battery`` -> "Hcp_ Battery"
    | Item.``Com_ Battery`` -> "Com_ Battery"
    | Item.``Energy Well`` -> "Energy Well"
    | Item.``Imp_ Energy Well`` -> "Imp_ Energy Well"
    | Item.``Adv_ Energy Well`` -> "Adv_ Energy Well"
    | Item.``Exp_ Energy Well`` -> "Exp_ Energy Well"
    | Item.``Zio_ Biocell`` -> "Zio_ Biocell"
    | Item.``Asb_ Biocell Array`` -> "Asb_ Biocell Array"
    | Item.``Zio_ Biocell Array`` -> "Zio_ Biocell Array"
    | Item.``Superbattery`` -> "Superbattery"
    | Item.``Sml_ Matter Pod`` -> "Sml_ Matter Pod"
    | Item.``Med_ Matter Pod`` -> "Med_ Matter Pod"
    | Item.``Lrg_ Matter Pod`` -> "Lrg_ Matter Pod"
    | Item.``Hcp_ Matter Pod`` -> "Hcp_ Matter Pod"
    | Item.``Com_ Matter Pod`` -> "Com_ Matter Pod"
    | Item.``Matter Compressor`` -> "Matter Compressor"
    | Item.``Imp_ Matter Compressor`` -> "Imp_ Matter Compressor"
    | Item.``Adv_ Matter Compressor`` -> "Adv_ Matter Compressor"
    | Item.``Exp_ Matter Compressor`` -> "Exp_ Matter Compressor"
    | Item.``YI-UF0's Bottomless Matter Pit`` -> "YI-UF0's Bottomless Matter Pit"
    | Item.``Weight Redist_ System`` -> "Weight Redist_ System"
    | Item.``Adv_ Weight Redist_ System`` -> "Adv_ Weight Redist_ System"
    | Item.``Gravity Neutralizer`` -> "Gravity Neutralizer"
    | Item.``Adv_ Gravity Neutralizer`` -> "Adv_ Gravity Neutralizer"
    | Item.``Quantum Shading Machine`` -> "Quantum Shading Machine"
    | Item.``Asb_ Suspension Frame`` -> "Asb_ Suspension Frame"
    | Item.``Adv_ Quantum Shading Machine`` -> "Adv_ Quantum Shading Machine"
    | Item.``Asb_ Metafiber Network`` -> "Asb_ Metafiber Network"
    | Item.``Zio_ Metafield Generator`` -> "Zio_ Metafield Generator"
    | Item.``ST Field Compressor`` -> "ST Field Compressor"
    | Item.``Structural Scanner`` -> "Structural Scanner"
    | Item.``Trap Scanner`` -> "Trap Scanner"
    | Item.``Imp_ Trap Scanner`` -> "Imp_ Trap Scanner"
    | Item.``Mak_ Trap Scanner`` -> "Mak_ Trap Scanner"
    | Item.``Adv_ Trap Scanner`` -> "Adv_ Trap Scanner"
    | Item.``Machine Analyzer`` -> "Machine Analyzer"
    | Item.``Triangulator`` -> "Triangulator"
    | Item.``Visual Processing Unit`` -> "Visual Processing Unit"
    | Item.``Sub_ Optics`` -> "Sub_ Optics"
    | Item.``Adv_ Visual Processing Unit`` -> "Adv_ Visual Processing Unit"
    | Item.``Enh_ Optical Array`` -> "Enh_ Optical Array"
    | Item.``Exp_ Optical Array`` -> "Exp_ Optical Array"
    | Item.``Spectral Analyzer`` -> "Spectral Analyzer"
    | Item.``Sensor Array`` -> "Sensor Array"
    | Item.``Imp_ Sensor Array`` -> "Imp_ Sensor Array"
    | Item.``Adv_ Sensor Array`` -> "Adv_ Sensor Array"
    | Item.``Lrn_ Sensor Array`` -> "Lrn_ Sensor Array"
    | Item.``Mak_ Sensor Array`` -> "Mak_ Sensor Array"
    | Item.``Exp_ Sensor Array`` -> "Exp_ Sensor Array"
    | Item.``Signal Interpreter`` -> "Signal Interpreter"
    | Item.``Imp_ Signal Interpreter`` -> "Imp_ Signal Interpreter"
    | Item.``Adv_ Signal Interpreter`` -> "Adv_ Signal Interpreter"
    | Item.``Exp_ Signal Interpreter`` -> "Exp_ Signal Interpreter"
    | Item.``Active Sensor Suite`` -> "Active Sensor Suite"
    | Item.``Terrain Scanner`` -> "Terrain Scanner"
    | Item.``Imp_ Terrain Scanner`` -> "Imp_ Terrain Scanner"
    | Item.``Adv_ Terrain Scanner`` -> "Adv_ Terrain Scanner"
    | Item.``Mak_ Terrain Scanner`` -> "Mak_ Terrain Scanner"
    | Item.``Lrn_ Terrain Scanner`` -> "Lrn_ Terrain Scanner"
    | Item.``Exp_ Terrain Scanner`` -> "Exp_ Terrain Scanner"
    | Item.``Surveybot 24 Scanner`` -> "Surveybot 24 Scanner"
    | Item.``Terrain Scan Processor`` -> "Terrain Scan Processor"
    | Item.``Imp_ Terrain Scan Processor`` -> "Imp_ Terrain Scan Processor"
    | Item.``Mak_ Terrain Scan Processor`` -> "Mak_ Terrain Scan Processor"
    | Item.``Adv_ Terrain Scan Processor`` -> "Adv_ Terrain Scan Processor"
    | Item.``Exp_ Terrain Scan Processor`` -> "Exp_ Terrain Scan Processor"
    | Item.``Surveybot 24 Chip`` -> "Surveybot 24 Chip"
    | Item.``Seismic Detector`` -> "Seismic Detector"
    | Item.``Transport Network Coupler`` -> "Transport Network Coupler"
    | Item.``Modified TNC`` -> "Modified TNC"
    | Item.``Encrypted Comm Array`` -> "Encrypted Comm Array"
    | Item.``0b10 Decoder Chip _Generic_`` -> "0b10 Decoder Chip _Generic_"
    | Item.``0b10 Decoder Chip _Looter_`` -> "0b10 Decoder Chip _Looter_"
    | Item.``0b10 Decoder Chip _Scout_`` -> "0b10 Decoder Chip _Scout_"
    | Item.``0b10 Decoder Chip _Skirmisher_`` -> "0b10 Decoder Chip _Skirmisher_"
    | Item.``0b10 Alert Chip`` -> "0b10 Alert Chip"
    | Item.``Salvage Targeting Computer`` -> "Salvage Targeting Computer"
    | Item.``Imp_ Salvage Targeting Computer`` -> "Imp_ Salvage Targeting Computer"
    | Item.``Mak_ Salvage Targeting Computer`` -> "Mak_ Salvage Targeting Computer"
    | Item.``Adv_ Salvage Targeting Computer`` -> "Adv_ Salvage Targeting Computer"
    | Item.``Asb_ Combat Suite`` -> "Asb_ Combat Suite"
    | Item.``Targeting Computer`` -> "Targeting Computer"
    | Item.``Imp_ Targeting Computer`` -> "Imp_ Targeting Computer"
    | Item.``Adv_ Targeting Computer`` -> "Adv_ Targeting Computer"
    | Item.``Exp_ Targeting Computer`` -> "Exp_ Targeting Computer"
    | Item.``Multitargeting Array`` -> "Multitargeting Array"
    | Item.``Tactical Coordination Suite`` -> "Tactical Coordination Suite"
    | Item.``Melee Analysis Suite`` -> "Melee Analysis Suite"
    | Item.``Imp_ Melee Analysis Suite`` -> "Imp_ Melee Analysis Suite"
    | Item.``Adv_ Melee Analysis Suite`` -> "Adv_ Melee Analysis Suite"
    | Item.``Exp_ Melee Analysis Suite`` -> "Exp_ Melee Analysis Suite"
    | Item.``Launcher Guidance Computer`` -> "Launcher Guidance Computer"
    | Item.``Imp_ Launcher Guidance Computer`` -> "Imp_ Launcher Guidance Computer"
    | Item.``Adv_ Launcher Guidance Computer`` -> "Adv_ Launcher Guidance Computer"
    | Item.``Weapon Mount`` -> "Weapon Mount"
    | Item.``Target Analyzer`` -> "Target Analyzer"
    | Item.``Imp_ Target Analyzer`` -> "Imp_ Target Analyzer"
    | Item.``Adv_ Target Analyzer`` -> "Adv_ Target Analyzer"
    | Item.``Exp_ Target Analyzer`` -> "Exp_ Target Analyzer"
    | Item.``Core Analyzer`` -> "Core Analyzer"
    | Item.``Exp_ Core Analyzer`` -> "Exp_ Core Analyzer"
    | Item.``Armor Integrity Analyzer`` -> "Armor Integrity Analyzer"
    | Item.``Imp_ Armor Integrity Analyzer`` -> "Imp_ Armor Integrity Analyzer"
    | Item.``Exp_ Armor Integrity Analyzer`` -> "Exp_ Armor Integrity Analyzer"
    | Item.``Recoil Stabilizer`` -> "Recoil Stabilizer"
    | Item.``Recoil Nullifier`` -> "Recoil Nullifier"
    | Item.``Matter Filter`` -> "Matter Filter"
    | Item.``Prc_ Matter Filter`` -> "Prc_ Matter Filter"
    | Item.``Energy Filter`` -> "Energy Filter"
    | Item.``Prc_ Energy Filter`` -> "Prc_ Energy Filter"
    | Item.``Particle Charger`` -> "Particle Charger"
    | Item.``Imp_ Particle Charger`` -> "Imp_ Particle Charger"
    | Item.``Adv_ Particle Charger`` -> "Adv_ Particle Charger"
    | Item.``Particle Accelerator`` -> "Particle Accelerator"
    | Item.``Imp_ Particle Accelerator`` -> "Imp_ Particle Accelerator"
    | Item.``Adv_ Particle Accelerator`` -> "Adv_ Particle Accelerator"
    | Item.``Kinecellerator`` -> "Kinecellerator"
    | Item.``Imp_ Kinecellerator`` -> "Imp_ Kinecellerator"
    | Item.``Adv_ Kinecellerator`` -> "Adv_ Kinecellerator"
    | Item.``Heavy Servo Lattice`` -> "Heavy Servo Lattice"
    | Item.``VL-GR5's Timing Chip`` -> "VL-GR5's Timing Chip"
    | Item.``Launcher Loader`` -> "Launcher Loader"
    | Item.``Quantum Capacitor`` -> "Quantum Capacitor"
    | Item.``Weapon Cycler`` -> "Weapon Cycler"
    | Item.``Imp_ Weapon Cycler`` -> "Imp_ Weapon Cycler"
    | Item.``Adv_ Weapon Cycler`` -> "Adv_ Weapon Cycler"
    | Item.``Exp_ Weapon Cycler`` -> "Exp_ Weapon Cycler"
    | Item.``Microactuators`` -> "Microactuators"
    | Item.``Nanoactuators`` -> "Nanoactuators"
    | Item.``Femtoactuators`` -> "Femtoactuators"
    | Item.``Actuator Array`` -> "Actuator Array"
    | Item.``Imp_ Actuator Array`` -> "Imp_ Actuator Array"
    | Item.``Adv_ Actuator Array`` -> "Adv_ Actuator Array"
    | Item.``Exp_ Actuator Array`` -> "Exp_ Actuator Array"
    | Item.``Force Booster`` -> "Force Booster"
    | Item.``Imp_ Force Booster`` -> "Imp_ Force Booster"
    | Item.``Adv_ Force Booster`` -> "Adv_ Force Booster"
    | Item.``Stasis Canceller`` -> "Stasis Canceller"
    | Item.``Transmission Jammer`` -> "Transmission Jammer"
    | Item.``Mak_ Transmission Jammer`` -> "Mak_ Transmission Jammer"
    | Item.``Imp_ Transmission Jammer`` -> "Imp_ Transmission Jammer"
    | Item.``Adv_ Transmission Jammer`` -> "Adv_ Transmission Jammer"
    | Item.``Exp_ Transmission Jammer`` -> "Exp_ Transmission Jammer"
    | Item.``ECM Suite`` -> "ECM Suite"
    | Item.``Mak_ ECM Suite`` -> "Mak_ ECM Suite"
    | Item.``Adv_ ECM Suite`` -> "Adv_ ECM Suite"
    | Item.``Exp_ ECM Suite`` -> "Exp_ ECM Suite"
    | Item.``Active Sensor Spoofer`` -> "Active Sensor Spoofer"
    | Item.``Reaction Control System`` -> "Reaction Control System"
    | Item.``Imp_ Reaction Control System`` -> "Imp_ Reaction Control System"
    | Item.``Adv_ Reaction Control System`` -> "Adv_ Reaction Control System"
    | Item.``Exp_ Reaction Control System`` -> "Exp_ Reaction Control System"
    | Item.``Phase Shifter`` -> "Phase Shifter"
    | Item.``Imp_ Phase Shifter`` -> "Imp_ Phase Shifter"
    | Item.``Adv_ Phase Shifter`` -> "Adv_ Phase Shifter"
    | Item.``Exp_ Phase Shifter`` -> "Exp_ Phase Shifter"
    | Item.``Cloaking Device`` -> "Cloaking Device"
    | Item.``Mak_ Cloaking Device`` -> "Mak_ Cloaking Device"
    | Item.``Imp_ Cloaking Device`` -> "Imp_ Cloaking Device"
    | Item.``Adv_ Cloaking Device`` -> "Adv_ Cloaking Device"
    | Item.``Exp_ Cloaking Device`` -> "Exp_ Cloaking Device"
    | Item.``Cloak of Protection`` -> "Cloak of Protection"
    | Item.``5H-AD0's Cloak`` -> "5H-AD0's Cloak"
    | Item.``Core Shielding`` -> "Core Shielding"
    | Item.``Imp_ Core Shielding`` -> "Imp_ Core Shielding"
    | Item.``Exp_ Core Shielding`` -> "Exp_ Core Shielding"
    | Item.``Power Shielding`` -> "Power Shielding"
    | Item.``Imp_ Power Shielding`` -> "Imp_ Power Shielding"
    | Item.``Exp_ Power Shielding`` -> "Exp_ Power Shielding"
    | Item.``Propulsion Shielding`` -> "Propulsion Shielding"
    | Item.``Imp_ Propulsion Shielding`` -> "Imp_ Propulsion Shielding"
    | Item.``Exp_ Propulsion Shielding`` -> "Exp_ Propulsion Shielding"
    | Item.``Utility Shielding`` -> "Utility Shielding"
    | Item.``Imp_ Utility Shielding`` -> "Imp_ Utility Shielding"
    | Item.``Exp_ Utility Shielding`` -> "Exp_ Utility Shielding"
    | Item.``Weapon Shielding`` -> "Weapon Shielding"
    | Item.``Imp_ Weapon Shielding`` -> "Imp_ Weapon Shielding"
    | Item.``Exp_ Weapon Shielding`` -> "Exp_ Weapon Shielding"
    | Item.``Zio_ Weapon Casing`` -> "Zio_ Weapon Casing"
    | Item.``Backup Plating I`` -> "Backup Plating I"
    | Item.``Backup Plating III`` -> "Backup Plating III"
    | Item.``Backup Plating VII`` -> "Backup Plating VII"
    | Item.``Lgt_ Armor Plating`` -> "Lgt_ Armor Plating"
    | Item.``Med_ Armor Plating`` -> "Med_ Armor Plating"
    | Item.``Hvy_ Armor Plating`` -> "Hvy_ Armor Plating"
    | Item.``Zio_ Light Carapace`` -> "Zio_ Light Carapace"
    | Item.``Zio_ Heavy Carapace`` -> "Zio_ Heavy Carapace"
    | Item.``Hrd_ Light Armor Plating`` -> "Hrd_ Light Armor Plating"
    | Item.``Hrd_ Medium Armor Plating`` -> "Hrd_ Medium Armor Plating"
    | Item.``Hrd_ Heavy Armor Plating`` -> "Hrd_ Heavy Armor Plating"
    | Item.``Imp_ Light Armor Plating`` -> "Imp_ Light Armor Plating"
    | Item.``Imp_ Medium Armor Plating`` -> "Imp_ Medium Armor Plating"
    | Item.``Imp_ Heavy Armor Plating`` -> "Imp_ Heavy Armor Plating"
    | Item.``Lyr_ Light Armor Plating`` -> "Lyr_ Light Armor Plating"
    | Item.``Mak_ Armor Plating`` -> "Mak_ Armor Plating"
    | Item.``Lyr_ Medium Armor Plating`` -> "Lyr_ Medium Armor Plating"
    | Item.``Lyr_ Heavy Armor Plating`` -> "Lyr_ Heavy Armor Plating"
    | Item.``Gun Armor`` -> "Gun Armor"
    | Item.``Centrium Light Armor Plating`` -> "Centrium Light Armor Plating"
    | Item.``Centrium Medium Armor Plating`` -> "Centrium Medium Armor Plating"
    | Item.``Centrium Heavy Armor Plating`` -> "Centrium Heavy Armor Plating"
    | Item.``Centrium Linked Plating`` -> "Centrium Linked Plating"
    | Item.``Reactive Plating`` -> "Reactive Plating"
    | Item.``Med_ Reactive Plating`` -> "Med_ Reactive Plating"
    | Item.``Mak_ Kinetic Plating`` -> "Mak_ Kinetic Plating"
    | Item.``Hvy_ Reactive Plating`` -> "Hvy_ Reactive Plating"
    | Item.``Reflective Plating`` -> "Reflective Plating"
    | Item.``Med_ Reflective Plating`` -> "Med_ Reflective Plating"
    | Item.``Mak_ Thermal Plating`` -> "Mak_ Thermal Plating"
    | Item.``Hvy_ Reflective Plating`` -> "Hvy_ Reflective Plating"
    | Item.``8R-AWN's Armor_TH`` -> "8R-AWN's Armor_TH"
    | Item.``8R-AWN's Armor_EX`` -> "8R-AWN's Armor_EX"
    | Item.``Insulated Plating`` -> "Insulated Plating"
    | Item.``Med_ Insulated Plating`` -> "Med_ Insulated Plating"
    | Item.``Hvy_ Insulated Plating`` -> "Hvy_ Insulated Plating"
    | Item.``Damper Plating`` -> "Damper Plating"
    | Item.``Zio_ Shade Carapace`` -> "Zio_ Shade Carapace"
    | Item.``Zio_ Shade Armor`` -> "Zio_ Shade Armor"
    | Item.``Asb_ Alloy Armor`` -> "Asb_ Alloy Armor"
    | Item.``Mak_ Ablative Armor`` -> "Mak_ Ablative Armor"
    | Item.``Active Cooling Armor`` -> "Active Cooling Armor"
    | Item.``Scrap Shield`` -> "Scrap Shield"
    | Item.``Powered Armor`` -> "Powered Armor"
    | Item.``Imp_ Powered Armor`` -> "Imp_ Powered Armor"
    | Item.``Adv_ Powered Armor`` -> "Adv_ Powered Armor"
    | Item.``Exp_ Powered Armor`` -> "Exp_ Powered Armor"
    | Item.``1C-UTU's Buckler`` -> "1C-UTU's Buckler"
    | Item.``Lgt_ Regenerative Plating`` -> "Lgt_ Regenerative Plating"
    | Item.``Med_ Regenerative Plating`` -> "Med_ Regenerative Plating"
    | Item.``Hvy_ Regenerative Plating`` -> "Hvy_ Regenerative Plating"
    | Item.``SHELL Armor`` -> "SHELL Armor"
    | Item.``Phase Armor`` -> "Phase Armor"
    | Item.``Graphene Brace`` -> "Graphene Brace"
    | Item.``Focal Shield`` -> "Focal Shield"
    | Item.``Imp_ Focal Shield`` -> "Imp_ Focal Shield"
    | Item.``Adv_ Focal Shield`` -> "Adv_ Focal Shield"
    | Item.``Exp_ Focal Shield`` -> "Exp_ Focal Shield"
    | Item.``Thermal Shield`` -> "Thermal Shield"
    | Item.``Imp_ Thermal Shield`` -> "Imp_ Thermal Shield"
    | Item.``Adv_ Thermal Shield`` -> "Adv_ Thermal Shield"
    | Item.``Exp_ Thermal Shield`` -> "Exp_ Thermal Shield"
    | Item.``Thermal Barrier`` -> "Thermal Barrier"
    | Item.``Beam Splitter`` -> "Beam Splitter"
    | Item.``Thermal Defense Suite`` -> "Thermal Defense Suite"
    | Item.``Imp_ Thermal Defense Suite`` -> "Imp_ Thermal Defense Suite"
    | Item.``Adv_ Thermal Defense Suite`` -> "Adv_ Thermal Defense Suite"
    | Item.``Exp_ Thermal Defense Suite`` -> "Exp_ Thermal Defense Suite"
    | Item.``Shock Absorption System`` -> "Shock Absorption System"
    | Item.``Imp_ Shock Absorption System`` -> "Imp_ Shock Absorption System"
    | Item.``Exp_ Shock Absorption System`` -> "Exp_ Shock Absorption System"
    | Item.``EM Disruption Field`` -> "EM Disruption Field"
    | Item.``Adv_ EM Disruption Field`` -> "Adv_ EM Disruption Field"
    | Item.``Exp_ EM Disruption Field`` -> "Exp_ EM Disruption Field"
    | Item.``ME-RLN's Chromatic Screen`` -> "ME-RLN's Chromatic Screen"
    | Item.``Hardlight Generator`` -> "Hardlight Generator"
    | Item.``Imp_ Hardlight Generator`` -> "Imp_ Hardlight Generator"
    | Item.``Adv_ Hardlight Generator`` -> "Adv_ Hardlight Generator"
    | Item.``Exp_ Hardlight Generator`` -> "Exp_ Hardlight Generator"
    | Item.``Shield Generator`` -> "Shield Generator"
    | Item.``Imp_ Shield Generator`` -> "Imp_ Shield Generator"
    | Item.``Adv_ Shield Generator`` -> "Adv_ Shield Generator"
    | Item.``Exp_ Shield Generator`` -> "Exp_ Shield Generator"
    | Item.``Force Field`` -> "Force Field"
    | Item.``Imp_ Force Field`` -> "Imp_ Force Field"
    | Item.``Adv_ Force Field`` -> "Adv_ Force Field"
    | Item.``Exp_ Force Field`` -> "Exp_ Force Field"
    | Item.``7V-RTL's Ultimate Field`` -> "7V-RTL's Ultimate Field"
    | Item.``Vortex Field Projector`` -> "Vortex Field Projector"
    | Item.``Remote Shield`` -> "Remote Shield"
    | Item.``Imp_ Remote Shield`` -> "Imp_ Remote Shield"
    | Item.``Adv_ Remote Shield`` -> "Adv_ Remote Shield"
    | Item.``Remote Force Field`` -> "Remote Force Field"
    | Item.``Imp_ Remote Force Field`` -> "Imp_ Remote Force Field"
    | Item.``Energy Mantle`` -> "Energy Mantle"
    | Item.``Imp_ Energy Mantle`` -> "Imp_ Energy Mantle"
    | Item.``AEGIS Remote Shield`` -> "AEGIS Remote Shield"
    | Item.``Phase Redirector`` -> "Phase Redirector"
    | Item.``Point Defense System`` -> "Point Defense System"
    | Item.``Point Defense Array`` -> "Point Defense Array"
    | Item.``Antimissile System`` -> "Antimissile System"
    | Item.``EX Chip 1`` -> "EX Chip 1"
    | Item.``Hacking Suite`` -> "Hacking Suite"
    | Item.``Mak_ Hacking Suite`` -> "Mak_ Hacking Suite"
    | Item.``Imp_ Hacking Suite`` -> "Imp_ Hacking Suite"
    | Item.``Adv_ Hacking Suite`` -> "Adv_ Hacking Suite"
    | Item.``Exp_ Hacking Suite`` -> "Exp_ Hacking Suite"
    | Item.``System Mapper`` -> "System Mapper"
    | Item.``Deep Network Scanner`` -> "Deep Network Scanner"
    | Item.``Architect God Chip A`` -> "Architect God Chip A"
    | Item.``EX Chip 2`` -> "EX Chip 2"
    | Item.``System Shield`` -> "System Shield"
    | Item.``Mak_ System Shield`` -> "Mak_ System Shield"
    | Item.``Imp_ System Shield`` -> "Imp_ System Shield"
    | Item.``Adv_ System Shield`` -> "Adv_ System Shield"
    | Item.``Exp_ System Shield`` -> "Exp_ System Shield"
    | Item.``Ghost Barrier`` -> "Ghost Barrier"
    | Item.``Quantum Router`` -> "Quantum Router"
    | Item.``Architect God Chip D`` -> "Architect God Chip D"
    | Item.``Authchip _R_NC_`` -> "Authchip _R_NC_"
    | Item.``Authchip _R_Combat_`` -> "Authchip _R_Combat_"
    | Item.``Authchip _Power_`` -> "Authchip _Power_"
    | Item.``Authchip _Propulsion_`` -> "Authchip _Propulsion_"
    | Item.``Authchip _Device_`` -> "Authchip _Device_"
    | Item.``Authchip _Storage_`` -> "Authchip _Storage_"
    | Item.``Authchip _Processor_`` -> "Authchip _Processor_"
    | Item.``Authchip _Armor_`` -> "Authchip _Armor_"
    | Item.``Authchip _Weapon_`` -> "Authchip _Weapon_"
    | Item.``Relay Coupler _NC_`` -> "Relay Coupler _NC_"
    | Item.``Relay Coupler _C_`` -> "Relay Coupler _C_"
    | Item.``Relay Coupler _Swarmer_`` -> "Relay Coupler _Swarmer_"
    | Item.``Relay Coupler _Cutter_`` -> "Relay Coupler _Cutter_"
    | Item.``Relay Coupler _Grunt_`` -> "Relay Coupler _Grunt_"
    | Item.``Relay Coupler _Brawler_`` -> "Relay Coupler _Brawler_"
    | Item.``Relay Coupler _Duelist_`` -> "Relay Coupler _Duelist_"
    | Item.``Relay Coupler _Sentry_`` -> "Relay Coupler _Sentry_"
    | Item.``Relay Coupler _Demolisher_`` -> "Relay Coupler _Demolisher_"
    | Item.``Relay Coupler _Specialist_`` -> "Relay Coupler _Specialist_"
    | Item.``Relay Coupler _Hunter_`` -> "Relay Coupler _Hunter_"
    | Item.``Relay Coupler _Heavy_`` -> "Relay Coupler _Heavy_"
    | Item.``Relay Coupler _Behemoth_`` -> "Relay Coupler _Behemoth_"
    | Item.``Relay Coupler _Programmer_`` -> "Relay Coupler _Programmer_"
    | Item.``Relay Coupler _Proto_`` -> "Relay Coupler _Proto_"
    | Item.``Skeleton Box`` -> "Skeleton Box"
    | Item.``01-MTF's Autohacker`` -> "01-MTF's Autohacker"
    | Item.``Component Analysis Suite`` -> "Component Analysis Suite"
    | Item.``Imp_ Component Analysis Suite`` -> "Imp_ Component Analysis Suite"
    | Item.``Adv_ Component Analysis Suite`` -> "Adv_ Component Analysis Suite"
    | Item.``Dynamic Insulation System`` -> "Dynamic Insulation System"
    | Item.``Imp_ Dynamic Insulation System`` -> "Imp_ Dynamic Insulation System"
    | Item.``Adv_ Dynamic Insulation System`` -> "Adv_ Dynamic Insulation System"
    | Item.``System Guard`` -> "System Guard"
    | Item.``Imp_ System Guard`` -> "Imp_ System Guard"
    | Item.``Exp_ System Guard`` -> "Exp_ System Guard"
    | Item.``Corruption Screen`` -> "Corruption Screen"
    | Item.``Imp_ Corruption Screen`` -> "Imp_ Corruption Screen"
    | Item.``Adv_ Corruption Screen`` -> "Adv_ Corruption Screen"
    | Item.``System Restoration Module`` -> "System Restoration Module"
    | Item.``Mak_ System Restoration Module`` -> "Mak_ System Restoration Module"
    | Item.``Imp_ System Restoration Module`` -> "Imp_ System Restoration Module"
    | Item.``Adv_ System Restoration Module`` -> "Adv_ System Restoration Module"
    | Item.``System Purifier`` -> "System Purifier"
    | Item.``Exp_ System Purifier`` -> "Exp_ System Purifier"
    | Item.``Tractor Beam`` -> "Tractor Beam"
    | Item.``Hpw_ Tractor Beam`` -> "Hpw_ Tractor Beam"
    | Item.``Lrn_ Tractor Beam`` -> "Lrn_ Tractor Beam"
    | Item.``Mobile Refinery Mk_ CCLXVII`` -> "Mobile Refinery Mk_ CCLXVII"
    | Item.``Trap Extractor`` -> "Trap Extractor"
    | Item.``Imp_ Trap Extractor`` -> "Imp_ Trap Extractor"
    | Item.``Adv_ Trap Extractor`` -> "Adv_ Trap Extractor"
    | Item.``Trap Reconfigurator`` -> "Trap Reconfigurator"
    | Item.``Recalibrator`` -> "Recalibrator"
    | Item.``Imp_ Recalibrator`` -> "Imp_ Recalibrator"
    | Item.``Adv_ Recalibrator`` -> "Adv_ Recalibrator"
    | Item.``Field Recycling Unit`` -> "Field Recycling Unit"
    | Item.``Imp_ Field Recycling Unit`` -> "Imp_ Field Recycling Unit"
    | Item.``Adv_ Field Recycling Unit`` -> "Adv_ Field Recycling Unit"
    | Item.``Exp_ Field Recycling Unit`` -> "Exp_ Field Recycling Unit"
    | Item.``Drone Bay`` -> "Drone Bay"
    | Item.``Z-Drone Bay`` -> "Z-Drone Bay"
    | Item.``Mni_ Drone Bay`` -> "Mni_ Drone Bay"
    | Item.``Mapping Drone Bay`` -> "Mapping Drone Bay"
    | Item.``Adv_ Drone Bay`` -> "Adv_ Drone Bay"
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
    | Item.``Wardrone Bay`` -> "Wardrone Bay"
    | Item.``Cobbler Unit`` -> "Cobbler Unit"
    | Item.``Bomb Factory No_ 2`` -> "Bomb Factory No_ 2"
    | Item.``Mobile Assembly Unit`` -> "Mobile Assembly Unit"
    | Item.``Heart of Steel`` -> "Heart of Steel"
    | Item.``GOLEM Unit`` -> "GOLEM Unit"
    | Item.``PSU Rigger`` -> "PSU Rigger"
    | Item.``Phasing AFG`` -> "Phasing AFG"
    | Item.``AS-neutralizer No_ 17b`` -> "AS-neutralizer No_ 17b"
    | Item.``V3-11A's Pendant`` -> "V3-11A's Pendant"
    | Item.``Chronowheel`` -> "Chronowheel"
    | Item.``Power Bank`` -> "Power Bank"
    | Item.``Rainbow Chip`` -> "Rainbow Chip"
    | Item.``VL-GR5's Exoskeleton _Deathgrip_`` -> "VL-GR5's Exoskeleton _Deathgrip_"
    | Item.``Dimensional Node Initializer`` -> "Dimensional Node Initializer"
    | Item.``Transdimensional Reconstructor`` -> "Transdimensional Reconstructor"
    | Item.``Hpw_ Transdimensional Reconstructor`` -> "Hpw_ Transdimensional Reconstructor"
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
    | Item.``Spacefold Activator`` -> "Spacefold Activator"
    | Item.``Microwarp Drive`` -> "Microwarp Drive"
    | Item.``LC Capacitor`` -> "LC Capacitor"
    | Item.``LRC Armor`` -> "LRC Armor"
    | Item.``LRC Storage`` -> "LRC Storage"
    | Item.``LRC Energy Well`` -> "LRC Energy Well"
    | Item.``LRC Matter Compressor`` -> "LRC Matter Compressor"
    | Item.``LRC Boosters`` -> "LRC Boosters"
    | Item.``LRC Insulator`` -> "LRC Insulator"
    | Item.``EM Pulse Gun`` -> "EM Pulse Gun"
    | Item.``Hvy_ EM Pulse Gun`` -> "Hvy_ EM Pulse Gun"
    | Item.``EM Shotgun`` -> "EM Shotgun"
    | Item.``Imp_ EM Shotgun`` -> "Imp_ EM Shotgun"
    | Item.``Shock Rifle`` -> "Shock Rifle"
    | Item.``Riot Gun`` -> "Riot Gun"
    | Item.``Hvy_ EM Shotgun`` -> "Hvy_ EM Shotgun"
    | Item.``Lightning Gun`` -> "Lightning Gun"
    | Item.``Hvy_ Riot Gun`` -> "Hvy_ Riot Gun"
    | Item.``Arc Projector`` -> "Arc Projector"
    | Item.``Prc_ Shock Rifle`` -> "Prc_ Shock Rifle"
    | Item.``Hpw_ Shock Rifle`` -> "Hpw_ Shock Rifle"
    | Item.``Arc Thrower`` -> "Arc Thrower"
    | Item.``Imp_ Lightning Gun`` -> "Imp_ Lightning Gun"
    | Item.``Tesla Rifle`` -> "Tesla Rifle"
    | Item.``Imp_ Arc Projector`` -> "Imp_ Arc Projector"
    | Item.``Hvy_ Tesla Rifle`` -> "Hvy_ Tesla Rifle"
    | Item.``Hyp_ EM Gauss Rifle`` -> "Hyp_ EM Gauss Rifle"
    | Item.``Imp_ Arc Thrower`` -> "Imp_ Arc Thrower"
    | Item.``01-MTF's Shockpuncher`` -> "01-MTF's Shockpuncher"
    | Item.``Gamma Rifle`` -> "Gamma Rifle"
    | Item.``Tachyon Dispersion Ray`` -> "Tachyon Dispersion Ray"
    | Item.``Immobilizer`` -> "Immobilizer"
    | Item.``Modified EM Gauss Rifle`` -> "Modified EM Gauss Rifle"
    | Item.``AWS_EX-DEC`` -> "AWS_EX-DEC"
    | Item.``Enh_ Gamma Rifle`` -> "Enh_ Gamma Rifle"
    | Item.``Med_ Laser`` -> "Med_ Laser"
    | Item.``Sml_ Laser`` -> "Sml_ Laser"
    | Item.``Backup Laser I`` -> "Backup Laser I"
    | Item.``Beam Rifle`` -> "Beam Rifle"
    | Item.``Particle Gun`` -> "Particle Gun"
    | Item.``Spread Laser`` -> "Spread Laser"
    | Item.``Imp_ Medium Laser`` -> "Imp_ Medium Laser"
    | Item.``Sub_ Laser`` -> "Sub_ Laser"
    | Item.``Autobeam`` -> "Autobeam"
    | Item.``Field Laser`` -> "Field Laser"
    | Item.``Pulse Rifle`` -> "Pulse Rifle"
    | Item.``Backup Laser III`` -> "Backup Laser III"
    | Item.``Hvy_ Particle Gun`` -> "Hvy_ Particle Gun"
    | Item.``Prc_ Beam Rifle`` -> "Prc_ Beam Rifle"
    | Item.``Adv_ Beam Rifle`` -> "Adv_ Beam Rifle"
    | Item.``Hvy_ Laser`` -> "Hvy_ Laser"
    | Item.``Gatling Laser`` -> "Gatling Laser"
    | Item.``Cld_ Pulse Rifle`` -> "Cld_ Pulse Rifle"
    | Item.``Hpw_ Field Laser`` -> "Hpw_ Field Laser"
    | Item.``Imp_ Spread Laser`` -> "Imp_ Spread Laser"
    | Item.``Mak_ Laser`` -> "Mak_ Laser"
    | Item.``Plasma Rifle`` -> "Plasma Rifle"
    | Item.``Thermic Laser`` -> "Thermic Laser"
    | Item.``Beamcaster`` -> "Beamcaster"
    | Item.``Force Rifle`` -> "Force Rifle"
    | Item.``Imp_ Heavy Laser`` -> "Imp_ Heavy Laser"
    | Item.``Storm Laser`` -> "Storm Laser"
    | Item.``Zio_ Laser-S`` -> "Zio_ Laser-S"
    | Item.``Wave Gun`` -> "Wave Gun"
    | Item.``Variable Charge Gun`` -> "Variable Charge Gun"
    | Item.``Hvy_ Beamcaster`` -> "Hvy_ Beamcaster"
    | Item.``Cld_ Plasma Rifle`` -> "Cld_ Plasma Rifle"
    | Item.``Enh_ Force Rifle`` -> "Enh_ Force Rifle"
    | Item.``Hvy_ Gatling Laser`` -> "Hvy_ Gatling Laser"
    | Item.``Zio_ Phaser-S`` -> "Zio_ Phaser-S"
    | Item.``Phase Gun`` -> "Phase Gun"
    | Item.``Dispersion Rifle`` -> "Dispersion Rifle"
    | Item.``Backup Laser VII`` -> "Backup Laser VII"
    | Item.``Plasma Storm`` -> "Plasma Storm"
    | Item.``Adv_ Plasma Rifle`` -> "Adv_ Plasma Rifle"
    | Item.``Hvy_ Wave Gun`` -> "Hvy_ Wave Gun"
    | Item.``Adv_ Variable Charge Gun`` -> "Adv_ Variable Charge Gun"
    | Item.``Cld_ Phase Gun`` -> "Cld_ Phase Gun"
    | Item.``Lrn_ Gatling Laser`` -> "Lrn_ Gatling Laser"
    | Item.``Warp Gun`` -> "Warp Gun"
    | Item.``Vortex Rifle`` -> "Vortex Rifle"
    | Item.``Zio_ Laser-M`` -> "Zio_ Laser-M"
    | Item.``AWS_Thermal`` -> "AWS_Thermal"
    | Item.``PD Laser`` -> "PD Laser"
    | Item.``Quantum Rifle`` -> "Quantum Rifle"
    | Item.``Prc_ Phase Gun`` -> "Prc_ Phase Gun"
    | Item.``Hvy_ Dispersion Rifle`` -> "Hvy_ Dispersion Rifle"
    | Item.``Vortex Shotgun`` -> "Vortex Shotgun"
    | Item.``Vortex Rail`` -> "Vortex Rail"
    | Item.``Zio_ Phaser-M`` -> "Zio_ Phaser-M"
    | Item.``Enh_ Quantum Rifle`` -> "Enh_ Quantum Rifle"
    | Item.``Zio_ Laser-H`` -> "Zio_ Laser-H"
    | Item.``Hvy_ Quantum Rifle`` -> "Hvy_ Quantum Rifle"
    | Item.``Zio_ Phaser-H`` -> "Zio_ Phaser-H"
    | Item.``Gatling Beam`` -> "Gatling Beam"
    | Item.``Sigix Sheargun`` -> "Sigix Sheargun"
    | Item.``Modified Sigix Sheargun`` -> "Modified Sigix Sheargun"
    | Item.``Lgt_ EM Pulse Cannon`` -> "Lgt_ EM Pulse Cannon"
    | Item.``EM Pulse Cannon`` -> "EM Pulse Cannon"
    | Item.``Imp_ EM Pulse Cannon`` -> "Imp_ EM Pulse Cannon"
    | Item.``Proton Cannon`` -> "Proton Cannon"
    | Item.``Lrn_ Proton Cannon`` -> "Lrn_ Proton Cannon"
    | Item.``Disruptor Cannon`` -> "Disruptor Cannon"
    | Item.``Hvy_ Proton Cannon`` -> "Hvy_ Proton Cannon"
    | Item.``HERF Cannon`` -> "HERF Cannon"
    | Item.``Hvy_ Disruptor Cannon`` -> "Hvy_ Disruptor Cannon"
    | Item.``Cld_ Proton Cannon`` -> "Cld_ Proton Cannon"
    | Item.``Proton Burst Cannon`` -> "Proton Burst Cannon"
    | Item.``Com_ HERF Cannon`` -> "Com_ HERF Cannon"
    | Item.``Latent Energy Streamer`` -> "Latent Energy Streamer"
    | Item.``NK-0LA's Tesla Doomcannon`` -> "NK-0LA's Tesla Doomcannon"
    | Item.``EMDS`` -> "EMDS"
    | Item.``Hpw_ Disruptor Cannon`` -> "Hpw_ Disruptor Cannon"
    | Item.``Beam Cannon`` -> "Beam Cannon"
    | Item.``Particle Cannon`` -> "Particle Cannon"
    | Item.``Adv_ Beam Cannon`` -> "Adv_ Beam Cannon"
    | Item.``Sub_ Beam Cannon`` -> "Sub_ Beam Cannon"
    | Item.``Hvy_ Particle Cannon`` -> "Hvy_ Particle Cannon"
    | Item.``Ion Cannon`` -> "Ion Cannon"
    | Item.``Plasma Cannon`` -> "Plasma Cannon"
    | Item.``Hvy_ Ion Cannon`` -> "Hvy_ Ion Cannon"
    | Item.``Cld_ Particle Cannon`` -> "Cld_ Particle Cannon"
    | Item.``Phase Cannon`` -> "Phase Cannon"
    | Item.``Hvy_ Plasma Cannon`` -> "Hvy_ Plasma Cannon"
    | Item.``Cld_ Plasma Cannon`` -> "Cld_ Plasma Cannon"
    | Item.``Com_ Ion Cannon`` -> "Com_ Ion Cannon"
    | Item.``Ion Burst Cannon`` -> "Ion Burst Cannon"
    | Item.``Adv_ Plasma Cannon`` -> "Adv_ Plasma Cannon"
    | Item.``Hvy_ Phase Cannon`` -> "Hvy_ Phase Cannon"
    | Item.``Neutron Cannon`` -> "Neutron Cannon"
    | Item.``Powered Cannon`` -> "Powered Cannon"
    | Item.``Matter Neutralizer`` -> "Matter Neutralizer"
    | Item.``Hvy_ Neutron Cannon`` -> "Hvy_ Neutron Cannon"
    | Item.``Lrn_ Phase Cannon`` -> "Lrn_ Phase Cannon"
    | Item.``Cld_ Phase Cannon`` -> "Cld_ Phase Cannon"
    | Item.``Vortex Cannon`` -> "Vortex Cannon"
    | Item.``Gui_ Plasma Cannon`` -> "Gui_ Plasma Cannon"
    | Item.``Nova Cannon`` -> "Nova Cannon"
    | Item.``Imp_ Matter Neutralizer`` -> "Imp_ Matter Neutralizer"
    | Item.``Exp_ Thermic Cannon`` -> "Exp_ Thermic Cannon"
    | Item.``Vortex Driver`` -> "Vortex Driver"
    | Item.``Zio_ Alpha Cannon`` -> "Zio_ Alpha Cannon"
    | Item.``Asb_ Focal Cannon`` -> "Asb_ Focal Cannon"
    | Item.``Enh_ Nova Cannon`` -> "Enh_ Nova Cannon"
    | Item.``Firepult`` -> "Firepult"
    | Item.``YOLO Cannon`` -> "YOLO Cannon"
    | Item.``Potential Cannon`` -> "Potential Cannon"
    | Item.``Warp Cannon`` -> "Warp Cannon"
    | Item.``Cld_ Nova Cannon`` -> "Cld_ Nova Cannon"
    | Item.``Null Cannon`` -> "Null Cannon"
    | Item.``Imp_ Potential Cannon`` -> "Imp_ Potential Cannon"
    | Item.``Multinova Projection Cannon`` -> "Multinova Projection Cannon"
    | Item.``Disintegrator`` -> "Disintegrator"
    | Item.``Core Cannon`` -> "Core Cannon"
    | Item.``Sigix Shearcannon`` -> "Sigix Shearcannon"
    | Item.``Drained L-Cannon`` -> "Drained L-Cannon"
    | Item.``L-Cannon`` -> "L-Cannon"
    | Item.``Zio_ Alpha Cannon Mk_ II`` -> "Zio_ Alpha Cannon Mk_ II"
    | Item.``BFG-9k Vortex Edition`` -> "BFG-9k Vortex Edition"
    | Item.``Assault Rifle`` -> "Assault Rifle"
    | Item.``Asb_ Rifle`` -> "Asb_ Rifle"
    | Item.``Lgt_ Assault Rifle`` -> "Lgt_ Assault Rifle"
    | Item.``Hvy_ Assault Rifle`` -> "Hvy_ Assault Rifle"
    | Item.``Autogun`` -> "Autogun"
    | Item.``Shotgun`` -> "Shotgun"
    | Item.``Battle Rifle`` -> "Battle Rifle"
    | Item.``Asb_ Heavy Rifle`` -> "Asb_ Heavy Rifle"
    | Item.``Sub_ Machine Gun`` -> "Sub_ Machine Gun"
    | Item.``Imp_ Assault Rifle`` -> "Imp_ Assault Rifle"
    | Item.``Minigun`` -> "Minigun"
    | Item.``Hpw_ Shotgun`` -> "Hpw_ Shotgun"
    | Item.``Asb_ Shotgun`` -> "Asb_ Shotgun"
    | Item.``Barrage Gun`` -> "Barrage Gun"
    | Item.``Enh_ Autogun`` -> "Enh_ Autogun"
    | Item.``Gauss Rifle`` -> "Gauss Rifle"
    | Item.``Asb_ Gauss Rifle`` -> "Asb_ Gauss Rifle"
    | Item.``Flak Gun`` -> "Flak Gun"
    | Item.``Prc_ Assault Rifle`` -> "Prc_ Assault Rifle"
    | Item.``Hvy_ Battle Rifle`` -> "Hvy_ Battle Rifle"
    | Item.``Mak_ Shrapnel Gun`` -> "Mak_ Shrapnel Gun"
    | Item.``Coil Gun`` -> "Coil Gun"
    | Item.``Hyp_ Gauss Rifle`` -> "Hyp_ Gauss Rifle"
    | Item.``Hvy_ Machine Gun`` -> "Hvy_ Machine Gun"
    | Item.``Imp_ Heavy Machine Gun`` -> "Imp_ Heavy Machine Gun"
    | Item.``Com_ Gauss Rifle`` -> "Com_ Gauss Rifle"
    | Item.``XL Autogun Subcomponent`` -> "XL Autogun Subcomponent"
    | Item.``KE Penetrator`` -> "KE Penetrator"
    | Item.``Hyp_ Coil Gun`` -> "Hyp_ Coil Gun"
    | Item.``Imp_ KE Penetrator`` -> "Imp_ KE Penetrator"
    | Item.``Enh_ Coil Gun`` -> "Enh_ Coil Gun"
    | Item.``Com_ Coil Gun`` -> "Com_ Coil Gun"
    | Item.``Railgun`` -> "Railgun"
    | Item.``Adv_ KE Penetrator`` -> "Adv_ KE Penetrator"
    | Item.``Linked Autogun`` -> "Linked Autogun"
    | Item.``AWS_Gauss`` -> "AWS_Gauss"
    | Item.``Hyp_ Railgun`` -> "Hyp_ Railgun"
    | Item.``Helical Railgun`` -> "Helical Railgun"
    | Item.``Com_ Railgun`` -> "Com_ Railgun"
    | Item.``XL Autogun Array`` -> "XL Autogun Array"
    | Item.``12-ASH's Boomstick`` -> "12-ASH's Boomstick"
    | Item.``8R-AWN's Boregun`` -> "8R-AWN's Boregun"
    | Item.``Multirail`` -> "Multirail"
    | Item.``Hyp_ Multirail`` -> "Hyp_ Multirail"
    | Item.``5H-AD0's Sniper Rifle`` -> "5H-AD0's Sniper Rifle"
    | Item.``A3's Sniper Rifle`` -> "A3's Sniper Rifle"
    | Item.``Lgt_ Cannon`` -> "Lgt_ Cannon"
    | Item.``Imp_ Light Cannon`` -> "Imp_ Light Cannon"
    | Item.``Battle Cannon`` -> "Battle Cannon"
    | Item.``Assault Cannon`` -> "Assault Cannon"
    | Item.``Hvy_ Assault Cannon`` -> "Hvy_ Assault Cannon"
    | Item.``Flak Cannon`` -> "Flak Cannon"
    | Item.``Adv_ Assault Cannon`` -> "Adv_ Assault Cannon"
    | Item.``Gauss Cannon`` -> "Gauss Cannon"
    | Item.``Slug Cannon`` -> "Slug Cannon"
    | Item.``Mni_ Assault Cannon`` -> "Mni_ Assault Cannon"
    | Item.``Magnetic Acceleration Cannon`` -> "Magnetic Acceleration Cannon"
    | Item.``Hvy_ Flak Cannon`` -> "Hvy_ Flak Cannon"
    | Item.``Bore Cannon`` -> "Bore Cannon"
    | Item.``Antimatter Cannon`` -> "Antimatter Cannon"
    | Item.``Mass Driver`` -> "Mass Driver"
    | Item.``Hvy_ Mass Driver`` -> "Hvy_ Mass Driver"
    | Item.``Enh_ Gauss Cannon`` -> "Enh_ Gauss Cannon"
    | Item.``Hyp_ Gauss Cannon`` -> "Hyp_ Gauss Cannon"
    | Item.``Tri-rail Accelerator`` -> "Tri-rail Accelerator"
    | Item.``Hardcell Cannon`` -> "Hardcell Cannon"
    | Item.``Hvy_ Gauss Cannon`` -> "Hvy_ Gauss Cannon"
    | Item.``Hyp_ Mass Driver`` -> "Hyp_ Mass Driver"
    | Item.``Hvy_ Autocannon`` -> "Hvy_ Autocannon"
    | Item.``DAS Cannon`` -> "DAS Cannon"
    | Item.``Lgt_ Antimatter Cannon`` -> "Lgt_ Antimatter Cannon"
    | Item.``Linear Accelerator`` -> "Linear Accelerator"
    | Item.``Hvy_ Linear Accelerator`` -> "Hvy_ Linear Accelerator"
    | Item.``Com_ Mass Driver`` -> "Com_ Mass Driver"
    | Item.``Hvy_ Hardcell Cannon`` -> "Hvy_ Hardcell Cannon"
    | Item.``Com_ Linear Accelerator`` -> "Com_ Linear Accelerator"
    | Item.``Hyp_ Linear Accelerator`` -> "Hyp_ Linear Accelerator"
    | Item.``Hcl_ Linear Accelerator`` -> "Hcl_ Linear Accelerator"
    | Item.``Graviton Cannon`` -> "Graviton Cannon"
    | Item.``Blast Cannon`` -> "Blast Cannon"
    | Item.``P1-3CE's Gatling Flakker`` -> "P1-3CE's Gatling Flakker"
    | Item.``AWS_Autocannon`` -> "AWS_Autocannon"
    | Item.``Perforator`` -> "Perforator"
    | Item.``Omega Cannon`` -> "Omega Cannon"
    | Item.``EMP Blaster`` -> "EMP Blaster"
    | Item.``Shock Bomb Launcher`` -> "Shock Bomb Launcher"
    | Item.``Adv_ EMP Blaster`` -> "Adv_ EMP Blaster"
    | Item.``Proton Missile Launcher`` -> "Proton Missile Launcher"
    | Item.``Imp_ Proton Missile Launcher`` -> "Imp_ Proton Missile Launcher"
    | Item.``Gui_ EMP Blaster`` -> "Gui_ EMP Blaster"
    | Item.``Hvy_ Shock Bomb Launcher`` -> "Hvy_ Shock Bomb Launcher"
    | Item.``Tesla Bomb Launcher`` -> "Tesla Bomb Launcher"
    | Item.``Hvy_ Proton Missile Launcher`` -> "Hvy_ Proton Missile Launcher"
    | Item.``Com_ Tesla Bomb Launcher`` -> "Com_ Tesla Bomb Launcher"
    | Item.``Gamma Bomb Array`` -> "Gamma Bomb Array"
    | Item.``Enh_ Gamma Bomb Array`` -> "Enh_ Gamma Bomb Array"
    | Item.``Grenade Launcher`` -> "Grenade Launcher"
    | Item.``Rocket Launcher`` -> "Rocket Launcher"
    | Item.``Mni_ Grenade Launcher`` -> "Mni_ Grenade Launcher"
    | Item.``Sub_ Shrapnel Launcher`` -> "Sub_ Shrapnel Launcher"
    | Item.``Imp_ Grenade Launcher`` -> "Imp_ Grenade Launcher"
    | Item.``Missile Launcher`` -> "Missile Launcher"
    | Item.``Concussive RPG`` -> "Concussive RPG"
    | Item.``YI-UF0's Doublenader`` -> "YI-UF0's Doublenader"
    | Item.``Hvy_ Rocket Launcher`` -> "Hvy_ Rocket Launcher"
    | Item.``Hvy_ Missile Launcher`` -> "Hvy_ Missile Launcher"
    | Item.``Gui_ Missile Launcher`` -> "Gui_ Missile Launcher"
    | Item.``Prc_ Grenade Launcher`` -> "Prc_ Grenade Launcher"
    | Item.``Rocket Array`` -> "Rocket Array"
    | Item.``Lrn_ Missile Launcher`` -> "Lrn_ Missile Launcher"
    | Item.``Imp_ Concussive RPG`` -> "Imp_ Concussive RPG"
    | Item.``Prc_ Rocket Launcher`` -> "Prc_ Rocket Launcher"
    | Item.``Scatter Rocket Array`` -> "Scatter Rocket Array"
    | Item.``Smartbomb Launcher`` -> "Smartbomb Launcher"
    | Item.``Mni_ Smartbomb Launcher`` -> "Mni_ Smartbomb Launcher"
    | Item.``Tiamat Missile Launcher`` -> "Tiamat Missile Launcher"
    | Item.``Thermoblaster`` -> "Thermoblaster"
    | Item.``Micro-nuke Launcher`` -> "Micro-nuke Launcher"
    | Item.``Adv_ Concussive RPG`` -> "Adv_ Concussive RPG"
    | Item.``Neutron Missile Launcher`` -> "Neutron Missile Launcher"
    | Item.``Fusion Bomb Launcher`` -> "Fusion Bomb Launcher"
    | Item.``Hellfire Missile Launcher`` -> "Hellfire Missile Launcher"
    | Item.``Adv_ Micro-nuke Launcher`` -> "Adv_ Micro-nuke Launcher"
    | Item.``Tactical Quantum Warhead`` -> "Tactical Quantum Warhead"
    | Item.``Vortex Catalyst Activator`` -> "Vortex Catalyst Activator"
    | Item.``Chain Missile Launcher`` -> "Chain Missile Launcher"
    | Item.``Ragnarok Missile Launcher`` -> "Ragnarok Missile Launcher"
    | Item.``Point Singularity Launcher`` -> "Point Singularity Launcher"
    | Item.``Gui_ Micro-nuke Launcher`` -> "Gui_ Micro-nuke Launcher"
    | Item.``99-TNT's Nukerbomber`` -> "99-TNT's Nukerbomber"
    | Item.``Z-bomb Delivery System`` -> "Z-bomb Delivery System"
    | Item.``Sigix Terminator`` -> "Sigix Terminator"
    | Item.``Supercharged Sigix Terminator`` -> "Supercharged Sigix Terminator"
    | Item.``Containment Facilitator`` -> "Containment Facilitator"
    | Item.``Detonator`` -> "Detonator"
    | Item.``Dirty Datajack`` -> "Dirty Datajack"
    | Item.``Splice Injector`` -> "Splice Injector"
    | Item.``Datajack`` -> "Datajack"
    | Item.``Imp_ Datajack`` -> "Imp_ Datajack"
    | Item.``Adv_ Datajack`` -> "Adv_ Datajack"
    | Item.``Remote Datajack`` -> "Remote Datajack"
    | Item.``Imp_ Remote Datajack`` -> "Imp_ Remote Datajack"
    | Item.``Adv_ Remote Datajack`` -> "Adv_ Remote Datajack"
    | Item.``Exp_ Remote Datajack`` -> "Exp_ Remote Datajack"
    | Item.``Gui_ Remote Datajack`` -> "Gui_ Remote Datajack"
    | Item.``ME-RLN's Wand`` -> "ME-RLN's Wand"
    | Item.``Field Lobotomy Kit`` -> "Field Lobotomy Kit"
    | Item.``Mining Laser`` -> "Mining Laser"
    | Item.``Welding Torch`` -> "Welding Torch"
    | Item.``Plasma Cutter`` -> "Plasma Cutter"
    | Item.``Imp_ Plasma Cutter`` -> "Imp_ Plasma Cutter"
    | Item.``CPS Tube`` -> "CPS Tube"
    | Item.``Multitool`` -> "Multitool"
    | Item.``Flamer`` -> "Flamer"
    | Item.``Asb_ F-torch`` -> "Asb_ F-torch"
    | Item.``Enh_ Flamer`` -> "Enh_ Flamer"
    | Item.``Plasma Flamer`` -> "Plasma Flamer"
    | Item.``Asb_ P-torch`` -> "Asb_ P-torch"
    | Item.``RU-N14's Throwing Claymores`` -> "RU-N14's Throwing Claymores"
    | Item.``RU-N14's Throwing Claymores v3`` -> "RU-N14's Throwing Claymores v3"
    | Item.``AD-0RF's Magmablaster`` -> "AD-0RF's Magmablaster"
    | Item.``Stasis Beam`` -> "Stasis Beam"
    | Item.``Stasis Projector`` -> "Stasis Projector"
    | Item.``Exp_ Stasis Projector`` -> "Exp_ Stasis Projector"
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
    | Item.``Asb_ Maul`` -> "Asb_ Maul"
    | Item.``Hvy_ Hammer`` -> "Hvy_ Hammer"
    | Item.``Hvy_ Mace`` -> "Hvy_ Mace"
    | Item.``Hvy_ Flail`` -> "Hvy_ Flail"
    | Item.``Great Maul`` -> "Great Maul"
    | Item.``Powered Hammer`` -> "Powered Hammer"
    | Item.``Mak_ Hammer`` -> "Mak_ Hammer"
    | Item.``Power Maul`` -> "Power Maul"
    | Item.``Asb_ P-maul`` -> "Asb_ P-maul"
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
    | Item.``Asb_ Blade`` -> "Asb_ Blade"
    | Item.``Scythe`` -> "Scythe"
    | Item.``Axe`` -> "Axe"
    | Item.``Blade Saw`` -> "Blade Saw"
    | Item.``EC_3`` -> "EC_3"
    | Item.``Chainsword`` -> "Chainsword"
    | Item.``Ripper`` -> "Ripper"
    | Item.``Mak_ Axe`` -> "Mak_ Axe"
    | Item.``Mak_ Sword`` -> "Mak_ Sword"
    | Item.``Great Axe`` -> "Great Axe"
    | Item.``Greatsword`` -> "Greatsword"
    | Item.``Power Sword`` -> "Power Sword"
    | Item.``Asb_ P-sword`` -> "Asb_ P-sword"
    | Item.``Falx`` -> "Falx"
    | Item.``Carbide Saw`` -> "Carbide Saw"
    | Item.``Segregator`` -> "Segregator"
    | Item.``Tearclaws`` -> "Tearclaws"
    | Item.``EC_5`` -> "EC_5"
    | Item.``Phasing Sabre`` -> "Phasing Sabre"
    | Item.``Plasma Sword`` -> "Plasma Sword"
    | Item.``Ionic Axe`` -> "Ionic Axe"
    | Item.``Mni_ Tearclaws`` -> "Mni_ Tearclaws"
    | Item.``Dual-blade Saw`` -> "Dual-blade Saw"
    | Item.``Vibroblade`` -> "Vibroblade"
    | Item.``Molecular Scythe`` -> "Molecular Scythe"
    | Item.``Centrium Greatsword`` -> "Centrium Greatsword"
    | Item.``Master Tearclaws`` -> "Master Tearclaws"
    | Item.``Longsword _1`` -> "Longsword _1"
    | Item.``EC_7`` -> "EC_7"
    | Item.``Nanosword`` -> "Nanosword"
    | Item.``Particle Cleaver`` -> "Particle Cleaver"
    | Item.``Centrium Claws`` -> "Centrium Claws"
    | Item.``1C-UTU's Sword _Lootmaker_`` -> "1C-UTU's Sword _Lootmaker_"
    | Item.``1C-UTU's Sword _Choppy_`` -> "1C-UTU's Sword _Choppy_"
    | Item.``Vortex Shredder`` -> "Vortex Shredder"
    | Item.``EC_9`` -> "EC_9"
    | Item.``Sigix Broadsword`` -> "Sigix Broadsword"
    | Item.``Spear`` -> "Spear"
    | Item.``Mak_ Spear`` -> "Mak_ Spear"
    | Item.``CR-A16's Pointy Stick`` -> "CR-A16's Pointy Stick"
    | Item.``Hvy_ Pick`` -> "Hvy_ Pick"
    | Item.``Lance`` -> "Lance"
    | Item.``Kinetic Spear`` -> "Kinetic Spear"
    | Item.``Force Lance`` -> "Force Lance"
    | Item.``Plasma Lance`` -> "Plasma Lance"
    | Item.``Enh_ Force Lance`` -> "Enh_ Force Lance"
    | Item.``Vortex Lance`` -> "Vortex Lance"
    | Item.``CR-A16's Behemoth Slayer`` -> "CR-A16's Behemoth Slayer"
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
    | Item.``Piercing Trap`` -> "Piercing Trap"
    | Item.``Shock Trap`` -> "Shock Trap"
    | Item.``EM Surge Trap`` -> "EM Surge Trap"
    | Item.``Fire Trap`` -> "Fire Trap"
    | Item.``Stasis Trap`` -> "Stasis Trap"
    | Item.``Scrap Shield Fragment`` -> "Scrap Shield Fragment"
    | Item.``Signal Generator`` -> "Signal Generator"
    | Item.``Self-destruct Interrupter`` -> "Self-destruct Interrupter"
    | Item.``Sapper Charge`` -> "Sapper Charge"
    | Item.``Zhirov Special`` -> "Zhirov Special"
    | Item.``Deploy-a-Sentry`` -> "Deploy-a-Sentry"
    | Item.``GAL Module`` -> "GAL Module"
    | Item.``Portable AFG`` -> "Portable AFG"
    | Item.``SGEMP Prototype`` -> "SGEMP Prototype"
    | Item.``Terrabomb Derivative`` -> "Terrabomb Derivative"
    | Item.``Sigix Containment Pod`` -> "Sigix Containment Pod"
    | Item.``Sigix Corpse`` -> "Sigix Corpse"
    | Item.``Meganuke`` -> "Meganuke"
    | Item.``Gamma Refractor`` -> "Gamma Refractor"

[<RequireQualifiedAccess>]
type Prop =
    | ``Concrete Rubble``
    | ``Metal Rubble``
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
    | ``Piercing Trap``
    | ``Shock Trap``
    | ``EM Surge Trap``
    | ``Fire Trap``
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
    | ``ARM_Shell_Shootable``
    | ``ARM_Dimension_Slip_Node``
    | ``NO ENTRY``
    | ``LAB_Door_Hackable``
    | ``Active System Cloaker``
    | ``A0 Command``
    | ``hN 3sDk7Qc``
    | ``A0 Storage 04-B``
    | ``UC xVqbSdU M7q4``
    | ``Suspension Chamber``
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
    | ``JUN_Black_Space``
    | ``JUN_New_Year_City``

let getProp =
    function
    | 0 -> Prop.``Concrete Rubble``
    | 1 -> Prop.``Metal Rubble``
    | 2 -> Prop.``GENERIC_MACHINE_10``
    | 3 -> Prop.``GENERIC_MACHINE_9``
    | 4 -> Prop.``GENERIC_MACHINE_8``
    | 5 -> Prop.``GENERIC_MACHINE_7``
    | 6 -> Prop.``GENERIC_MACHINE_6``
    | 7 -> Prop.``GENERIC_MACHINE_5``
    | 8 -> Prop.``GENERIC_MACHINE_4``
    | 9 -> Prop.``GENERIC_MACHINE_3``
    | 10 -> Prop.``GENERIC_MACHINE_2``
    | 11 -> Prop.``GENERIC_MACHINE_1``
    | 12 -> Prop.``Terminal vFe_01a``
    | 13 -> Prop.``Terminal vNi_03a``
    | 14 -> Prop.``Terminal vCu_03a``
    | 15 -> Prop.``Terminal vZn_06a``
    | 16 -> Prop.``Terminal vAg_06a``
    | 17 -> Prop.``Terminal vTi_06n``
    | 18 -> Prop.``Terminal vCo_08n``
    | 19 -> Prop.``Terminal vMn_10n``
    | 20 -> Prop.``Terminal vMo_07n``
    | 21 -> Prop.``Terminal vPd_10n``
    | 22 -> Prop.``Terminal vCd_08n``
    | 23 -> Prop.``Terminal vZr_10n``
    | 24 -> Prop.``Terminal vY_10n``
    | 25 -> Prop.``Terminal vW_10x``
    | 26 -> Prop.``Terminal vIr_12x``
    | 27 -> Prop.``Terminal vPt_12x``
    | 28 -> Prop.``Terminal vAu_13x``
    | 29 -> Prop.``Terminal vHg_20x``
    | 30 -> Prop.``Terminal vRh_10x``
    | 31 -> Prop.``Fabricator vLi_07a``
    | 32 -> Prop.``Fabricator vNa_07a``
    | 33 -> Prop.``Fabricator vK_08a``
    | 34 -> Prop.``Fabricator vCs_10n``
    | 35 -> Prop.``Fabricator vBe_12n``
    | 36 -> Prop.``Fabricator vMg_13n``
    | 37 -> Prop.``Fabricator vCa_14x``
    | 38 -> Prop.``Fabricator vSr_14x``
    | 39 -> Prop.``Fabricator vBa_16x``
    | 40 -> Prop.``Fabricator vRa_19x``
    | 41 -> Prop.``Repair vAl_08a``
    | 42 -> Prop.``Repair vGa_08a``
    | 43 -> Prop.``Repair vIn_08a``
    | 44 -> Prop.``Repair vSn_08n``
    | 45 -> Prop.``Repair vTl_10n``
    | 46 -> Prop.``Repair vPb_11n``
    | 47 -> Prop.``Repair vBi_12x``
    | 48 -> Prop.``Repair vPo_13x``
    | 49 -> Prop.``Recycling vH_06a``
    | 50 -> Prop.``Recycling vN_06a``
    | 51 -> Prop.``Recycling vO_08n``
    | 52 -> Prop.``Recycling vF_08n``
    | 53 -> Prop.``Recycling vP_10x``
    | 54 -> Prop.``Recycling vI_14x``
    | 55 -> Prop.``Scanalyzer vHe_07a``
    | 56 -> Prop.``Scanalyzer vNe_13n``
    | 57 -> Prop.``Scanalyzer vAr_15x``
    | 58 -> Prop.``Scanalyzer vXe_13x``
    | 59 -> Prop.``Garrison vCe_6a``
    | 60 -> Prop.``Garrison vPr_8a``
    | 61 -> Prop.``Garrison vNd_9n``
    | 62 -> Prop.``Garrison vPm_7n``
    | 63 -> Prop.``Garrison vSm_13x``
    | 64 -> Prop.``Garrison vEu_9x``
    | 65 -> Prop.``T1``
    | 66 -> Prop.``Core Extractor``
    | 67 -> Prop.``Pulverizer``
    | 68 -> Prop.``Laser Drill``
    | 69 -> Prop.``Plasma Injector``
    | 70 -> Prop.``Seismic Survey Station``
    | 71 -> Prop.``Matter Pump``
    | 72 -> Prop.``Pressure Siphon``
    | 73 -> Prop.``Nuclear Reactor``
    | 74 -> Prop.``Neutrino Reactor``
    | 75 -> Prop.``Fusion Modulator``
    | 76 -> Prop.``Quantum Generator``
    | 77 -> Prop.``Dark Matter Chamber``
    | 78 -> Prop.``Hypermatter Reactor``
    | 79 -> Prop.``Compression Vault``
    | 80 -> Prop.``Component Storage``
    | 81 -> Prop.``Holding Depot``
    | 82 -> Prop.``Packing Station``
    | 83 -> Prop.``Arsenal Racks``
    | 84 -> Prop.``Extraspacial Lockers``
    | 85 -> Prop.``Energy Cycler``
    | 86 -> Prop.``Transport Mainframe``
    | 87 -> Prop.``Transfer Shaft``
    | 88 -> Prop.``Hadron Collector``
    | 89 -> Prop.``Electrolysis Chamber``
    | 90 -> Prop.``Processing Tank``
    | 91 -> Prop.``Atomic Centrifuge``
    | 92 -> Prop.``Purification Channel``
    | 93 -> Prop.``Integration Channel``
    | 94 -> Prop.``Material Processor``
    | 95 -> Prop.``Material Compactor``
    | 96 -> Prop.``Matter Filter``
    | 97 -> Prop.``Manufacturing Mainframe``
    | 98 -> Prop.``Construction Platform``
    | 99 -> Prop.``Assembly Bed``
    | 100 -> Prop.``Megafabricator``
    | 101 -> Prop.``Subcomponent Replicator``
    | 102 -> Prop.``Power Conduit``
    | 103 -> Prop.``Research Mainframe``
    | 104 -> Prop.``Antiparticle Reservoir``
    | 105 -> Prop.``Reaction Chamber``
    | 106 -> Prop.``Vacuum Chamber``
    | 107 -> Prop.``Subatomic Condenser``
    | 108 -> Prop.``Catalytron``
    | 109 -> Prop.``Meson Extractor``
    | 110 -> Prop.``Antimatter Diverter``
    | 111 -> Prop.``Field Manipulator``
    | 112 -> Prop.``Particle Synthesizer``
    | 113 -> Prop.``Quantum Separator``
    | 114 -> Prop.``Wave Intensifier``
    | 115 -> Prop.``Proton Scatter Basin``
    | 116 -> Prop.``Ion Accelerator``
    | 117 -> Prop.``Magnetic Photon System``
    | 118 -> Prop.``Hypercollider``
    | 119 -> Prop.``Graviton Restrictor``
    | 120 -> Prop.``Potential Refractor``
    | 121 -> Prop.``Prototyping Station``
    | 122 -> Prop.``Engineering Station``
    | 123 -> Prop.``Biostasis Chamber``
    | 124 -> Prop.``Organic Neutralizer``
    | 125 -> Prop.``Containment Shield``
    | 126 -> Prop.``Testing Mainframe``
    | 127 -> Prop.``Sonic Impulse Analyzer``
    | 128 -> Prop.``Field Warper``
    | 129 -> Prop.``Gravity Sphere``
    | 130 -> Prop.``Quantum Transformer``
    | 131 -> Prop.``Focalizer``
    | 132 -> Prop.``Phase Constrictor``
    | 133 -> Prop.``Resonance Scanner``
    | 134 -> Prop.``Tau Charger``
    | 135 -> Prop.``Harmonic Fracturing Unit``
    | 136 -> Prop.``Antiparticle Suffusor``
    | 137 -> Prop.``Thermocompressor Array``
    | 138 -> Prop.``Cryocooling Duct``
    | 139 -> Prop.``Artifact Storage``
    | 140 -> Prop.``Cryopreservation Unit``
    | 141 -> Prop.``Biostim Tank``
    | 142 -> Prop.``Quarantine Pod``
    | 143 -> Prop.``Aeration Cycler``
    | 144 -> Prop.``Deconstruction Unit``
    | 145 -> Prop.``Anatomizer``
    | 146 -> Prop.``Cloning Tubes``
    | 147 -> Prop.``Cell Assembler``
    | 148 -> Prop.``Molecular Binding Bank``
    | 149 -> Prop.``Anti-Ion Cluster``
    | 150 -> Prop.``Deuterium Array``
    | 151 -> Prop.``Mainframe``
    | 152 -> Prop.``Storage``
    | 153 -> Prop.``Retrofitting Station``
    | 154 -> Prop.``Signal Jammer``
    | 155 -> Prop.``Cloak Generator``
    | 156 -> Prop.``Decryption Engine``
    | 157 -> Prop.``Backup Mainframe``
    | 158 -> Prop.``Archive Unit``
    | 159 -> Prop.``Control Node``
    | 160 -> Prop.``Operations Mainframe``
    | 161 -> Prop.``Quantum Router``
    | 162 -> Prop.``Hyperwave Decoder``
    | 163 -> Prop.``Sealed Freight Elevator``
    | 164 -> Prop.``Radio-Gravity Array``
    | 165 -> Prop.``Anti-Orbital Battery``
    | 166 -> Prop.``Spectral Interrupter``
    | 167 -> Prop.``Wave Collapse Detector``
    | 168 -> Prop.``Signal Shield``
    | 169 -> Prop.``Longscan Aggregator``
    | 170 -> Prop.``Blade Trap``
    | 171 -> Prop.``Segregator Trap``
    | 172 -> Prop.``Explosive Trap``
    | 173 -> Prop.``Heavy Explosive Trap``
    | 174 -> Prop.``Tiamat Bomb Trap``
    | 175 -> Prop.``Fusion Bomb Trap``
    | 176 -> Prop.``Hellfire Trap``
    | 177 -> Prop.``Armageddon Trap``
    | 178 -> Prop.``Dirty Bomb Trap``
    | 179 -> Prop.``EMP Trap``
    | 180 -> Prop.``Proton Bomb Trap``
    | 181 -> Prop.``Tesla Bomb Trap``
    | 182 -> Prop.``Gamma Bomb Trap``
    | 183 -> Prop.``Shrapnel Trap``
    | 184 -> Prop.``Piercing Trap``
    | 185 -> Prop.``Shock Trap``
    | 186 -> Prop.``EM Surge Trap``
    | 187 -> Prop.``Fire Trap``
    | 188 -> Prop.``Stasis Trap``
    | 189 -> Prop.``Alarm Trap``
    | 190 -> Prop.``Ambush Trap``
    | 191 -> Prop.``Chute Trap``
    | 197 -> Prop.``Collapsed Tunnel``
    | 215 -> Prop.``Door Terminal``
    | 216 -> Prop.``DSF Access``
    | 217 -> Prop.``Broken Shaft Lining``
    | 218 -> Prop.``XXX_Blast_Door_Open``
    | 219 -> Prop.``XXX_Blast_Door_Hackable``
    | 220 -> Prop.``ACC_Door_Shootable_SUR``
    | 221 -> Prop.``ACC_Door_Shootable_COM``
    | 222 -> Prop.``ACC_Door_Hackable``
    | 223 -> Prop.``ACC_Shell_Shootable``
    | 224 -> Prop.``Main Access Lift``
    | 226 -> Prop.``STO_Door_Open``
    | 227 -> Prop.``STO_Door_Hackable``
    | 228 -> Prop.``STO_Shell_Shootable``
    | 229 -> Prop.``GAR_Door_Shootable``
    | 230 -> Prop.``GAR_Relay``
    | 231 -> Prop.``GAR_Generator``
    | 232 -> Prop.``GAR_RIF_Installer``
    | 233 -> Prop.``Garrison Terminal``
    | 234 -> Prop.``GAR_Heavy_Assembler``
    | 235 -> Prop.``GAR_QS_Assembler``
    | 236 -> Prop.``SHOP_Sys``
    | 237 -> Prop.``MIN_Door_Hackable_Weak``
    | 238 -> Prop.``Assembled Analyzer``
    | 239 -> Prop.``Components``
    | 240 -> Prop.``Testing Chamber Shield``
    | 241 -> Prop.``Testing Apparatus``
    | 242 -> Prop.``EX-Generator``
    | 243 -> Prop.``BIN's Workstation``
    | 244 -> Prop.``DEC's Workstation``
    | 245 -> Prop.``HEX's Workstation``
    | 246 -> Prop.``BIN's Terminal``
    | 247 -> Prop.``DEC's Terminal``
    | 248 -> Prop.``HEX's Terminal``
    | 249 -> Prop.``EXI_Farcom``
    | 250 -> Prop.``EX-Vault Access``
    | 251 -> Prop.``EX-Prototypes Database``
    | 252 -> Prop.``EX-Message Board``
    | 253 -> Prop.``Repaired_Machine_T``
    | 254 -> Prop.``Repaired_Machine_F``
    | 255 -> Prop.``Repaired_Machine_R``
    | 256 -> Prop.``Repaired_Machine_Y``
    | 257 -> Prop.``Repaired_Machine_S``
    | 258 -> Prop.``Testing Chamber``
    | 259 -> Prop.``4L-MR0's Prototype Logs``
    | 260 -> Prop.``SUB_Autodoor``
    | 261 -> Prop.``Clippyterm``
    | 262 -> Prop.``Triangle-emblazoned Door``
    | 263 -> Prop.``WAR_Sys``
    | 264 -> Prop.``Prototyping Terminal``
    | 265 -> Prop.``CAV_Door_Hackable``
    | 266 -> Prop.``Outpost Terminal``
    | 267 -> Prop.``CAV_Base_Generator``
    | 268 -> Prop.``CAV_Junk_Machine``
    | 269 -> Prop.``CAV_Reinforcement``
    | 270 -> Prop.``CAV_Door_Shootable``
    | 271 -> Prop.``CAV_Door_No_Terminal``
    | 272 -> Prop.``Private``
    | 273 -> Prop.``CAV_Thief_Den``
    | 274 -> Prop.``W-Fans Enter Here``
    | 275 -> Prop.``LOW_Warlord_Fan_Stuff``
    | 276 -> Prop.``PRO_Base_Generator``
    | 277 -> Prop.``PRO_Target_Dispatcher``
    | 278 -> Prop.``PRO_Test_Aggregator``
    | 279 -> Prop.``PRO_Data_Receptor``
    | 280 -> Prop.``Matter Repository``
    | 281 -> Prop.``Twisting Tunnel``
    | 282 -> Prop.``DAT_Data_Conduit``
    | 283 -> Prop.``ORACLE Interface``
    | 284 -> Prop.``ZHI_Cloak_Generator``
    | 286 -> Prop.``ZHI_Main_Door``
    | 287 -> Prop.``Zhirov's Terminal``
    | 288 -> Prop.``Quantum Analyzer``
    | 289 -> Prop.``Zhirov's Workstation``
    | 290 -> Prop.``WAR_Door_Hackable``
    | 291 -> Prop.``Vortex Lab Terminal``
    | 292 -> Prop.``Hacking Lab Terminal``
    | 293 -> Prop.``Relay Lab Terminal``
    | 294 -> Prop.``Fabnet Lab Terminal``
    | 295 -> Prop.``Intel Room Terminal``
    | 296 -> Prop.``WAR_Staging_Area``
    | 297 -> Prop.``RES_Staging_Area``
    | 298 -> Prop.``WAR_Mainc_Tunnel``
    | 299 -> Prop.``ZIO_Machinery``
    | 300 -> Prop.``Deep Containment System``
    | 301 -> Prop.``ZIOWAR_Quarantine_Array``
    | 302 -> Prop.``ZIO_Cloak_Generator``
    | 303 -> Prop.``ZIO_Stockpile_Wall``
    | 304 -> Prop.``ZIO_Prototype_Hold``
    | 305 -> Prop.``ZIO_Lab_Wall``
    | 306 -> Prop.``ZIO_Repair_Shop_Wall``
    | 307 -> Prop.``Zion Terminal``
    | 308 -> Prop.``ZIO_Machinery_Fake``
    | 309 -> Prop.``Conduit Teleporter``
    | 310 -> Prop.``ZIO_Memory_Banks``
    | 311 -> Prop.``ZIO_Imprinter``
    | 312 -> Prop.``DEE_Z_Facility``
    | 313 -> Prop.``Z-Power``
    | 315 -> Prop.``DEE_Sigix_Wall``
    | 316 -> Prop.``DEE_Sigix_Gate``
    | 317 -> Prop.``DEE_Wall_Chamber``
    | 318 -> Prop.``DEE_Survey_Way_Station``
    | 319 -> Prop.``EXT_Door_Hackable``
    | 321 -> Prop.``EXT_Transfer_Station``
    | 322 -> Prop.``Cetus Terminal``
    | 323 -> Prop.``Cetus Manufacturing Controls``
    | 324 -> Prop.``CET_Door_Hackable``
    | 325 -> Prop.``Doors``
    | 326 -> Prop.``Bed``
    | 327 -> Prop.``Lockers``
    | 328 -> Prop.``Table``
    | 329 -> Prop.``Lab Station``
    | 330 -> Prop.``Research Interface``
    | 331 -> Prop.``Cetus Mainframe``
    | 332 -> Prop.``Cetus Manufacturing Module``
    | 333 -> Prop.``Archive Terminal``
    | 334 -> Prop.``Archive Hub``
    | 335 -> Prop.``HUB_Transfer_Station``
    | 336 -> Prop.``HUB_Network_Hub``
    | 337 -> Prop.``ARM_Door_Hackable``
    | 338 -> Prop.``ARM_Shell_Shootable``
    | 339 -> Prop.``ARM_Dimension_Slip_Node``
    | 340 -> Prop.``NO ENTRY``
    | 341 -> Prop.``LAB_Door_Hackable``
    | 342 -> Prop.``Active System Cloaker``
    | 343 -> Prop.``A0 Command``
    | 344 -> Prop.``hN 3sDk7Qc``
    | 345 -> Prop.``A0 Storage 04-B``
    | 346 -> Prop.``UC xVqbSdU M7q4``
    | 347 -> Prop.``Suspension Chamber``
    | 349 -> Prop.``TES_Door_Hackable``
    | 350 -> Prop.``TES_Shell_Shootable``
    | 351 -> Prop.``Regeneration Lab``
    | 352 -> Prop.``TES_Terrabomb``
    | 353 -> Prop.``QUA_Door_Hackable``
    | 354 -> Prop.``QUA_Door_Hackable_Hard``
    | 355 -> Prop.``Sigix Lab``
    | 356 -> Prop.``Sigix Quarantine Controls``
    | 357 -> Prop.``Sigix Quarantine Chamber``
    | 358 -> Prop.``Teleportation Lab``
    | 359 -> Prop.``Autopsy Lab``
    | 360 -> Prop.``Research Terminal``
    | 361 -> Prop.``SEC_Door_Hackable``
    | 362 -> Prop.``L2 Monitoring Station``
    | 363 -> Prop.``Power Cell Monitoring``
    | 364 -> Prop.``Thrusters``
    | 365 -> Prop.``SEC_L2_Power_Cell``
    | 366 -> Prop.``Wing Frame``
    | 367 -> Prop.``FTL Facilitator``
    | 368 -> Prop.``Core Housing``
    | 369 -> Prop.``Hull``
    | 370 -> Prop.``Armor Plating``
    | 371 -> Prop.``Navigation``
    | 372 -> Prop.``Construction Supplies``
    | 373 -> Prop.``L2 Fabricator``
    | 374 -> Prop.``Exoskeleton Controls``
    | 375 -> Prop.``Cave Seal Controls``
    | 376 -> Prop.``COM_Cave_Spawn``
    | 377 -> Prop.``COM_Shell_Shootable``
    | 378 -> Prop.``Access Lift``
    | 379 -> Prop.``COM_Teleport_Inhibitor``
    | 380 -> Prop.``COM_Door_Hackable``
    | 381 -> Prop.``COM_0b10_Conduit``
    | 382 -> Prop.``COM_Alternative_Access``
    | 384 -> Prop.``COM_Cache_Door``
    | 385 -> Prop.``AC0_Singularity_Gate``
    | 386 -> Prop.``Gate Controls``
    | 388 -> Prop.``AC0_Subspace_Node``
    | 389 -> Prop.``AC0_Subspace_Node_Mid``
    | 390 -> Prop.``AC0_Architect_Shell``
    | 391 -> Prop.``Architect Logs``
    | 392 -> Prop.``AC0_Abandoned_Machinery``
    | 393 -> Prop.``AC0_Shell_Shootable``
    | 394 -> Prop.``Analysis Chamber``
    | 395 -> Prop.``AC0_Workstation``
    | 396 -> Prop.``JUN_Black_Space``
    | 397 -> Prop.``JUN_New_Year_City``
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
    | ``Advanced Drone`` = 10
    | ``Stealth Drone`` = 11
    | ``Trailblazer`` = 12
    | ``Thief Drone`` = 13
    | ``Army Drone`` = 14
    | ``Swarm Drone`` = 15
    | ``Combat Drone`` = 16
    | ``Assault Drone`` = 17
    | ``Bomb Drone`` = 18
    | ``Wardrone`` = 19
    | ``DAS Turret`` = 20
    | ``Autobeam Turret`` = 21
    | ``K-01 Serf`` = 22
    | ``U-05 Engineer`` = 23
    | ``T-07 Excavator`` = 24
    | ``A-02 Transporter`` = 25
    | ``A-15 Conveyor`` = 26
    | ``A-27 Freighter`` = 27
    | ``R-06 Scavenger`` = 28
    | ``R-10 Processor`` = 29
    | ``C-30 ARC`` = 30
    | ``M-14 Sweeper`` = 31
    | ``M-22 Extractor`` = 32
    | ``M-30 Cleanser`` = 33
    | ``M-13 Machinist`` = 34
    | ``M-28 Smith`` = 35
    | ``M-36 Artificer`` = 36
    | ``O-16 Technician`` = 37
    | ``O-24 Administrator`` = 38
    | ``O-32 Director`` = 39
    | ``N-00 Fly`` = 40
    | ``N-01 Spotter`` = 41
    | ``W-16 Scout`` = 42
    | ``W-25 Informer`` = 43
    | ``W-44 Eye`` = 44
    | ``S-10 Pest`` = 45
    | ``S-27 Virus`` = 46
    | ``S-43 Plague`` = 47
    | ``C-17 Slicer`` = 48
    | ``C-35 Carver`` = 49
    | ``C-57 Dissector`` = 50
    | ``E-15 Imp`` = 51
    | ``G-34 Mercenary`` = 52
    | ``G-47 Trooper`` = 53
    | ``G-50 Soldier`` = 54
    | ``G-67 Veteran`` = 55
    | ``G-73 Enforcer`` = 56
    | ``B-36 Bruiser`` = 57
    | ``B-48 Gladiator`` = 58
    | ``B-60 Warrior`` = 59
    | ``B-74 Champion`` = 60
    | ``L-31 Rogue`` = 61
    | ``L-41 Fighter`` = 62
    | ``L-61 Swordsman`` = 63
    | ``I-25 Savior`` = 64
    | ``I-36 Angel`` = 65
    | ``I-47 Archangel`` = 66
    | ``C-55 Analyst`` = 67
    | ``C-65 Expert`` = 68
    | ``Y-45 Defender`` = 69
    | ``Y-54 Guardian`` = 70
    | ``Y-64 Sentinel`` = 71
    | ``Y-72 Warden`` = 72
    | ``D-53 Grenadier`` = 73
    | ``D-63 Destroyer`` = 74
    | ``D-83 Annihilator`` = 75
    | ``X-57 Shotgunner`` = 76
    | ``X-62 Marksman`` = 77
    | ``X-67 Chaingunner`` = 78
    | ``X-72 Disruptor`` = 79
    | ``X-77 Beamer`` = 80
    | ``X-82 Rainmaker`` = 81
    | ``X-87 Electro`` = 82
    | ``H-55 Commando`` = 83
    | ``H-66 Slayer`` = 84
    | ``H-77 Assassin`` = 85
    | ``H-88 Terminator`` = 86
    | ``P-60 Hacker`` = 87
    | ``P-70 Sage`` = 88
    | ``P-80 Master`` = 89
    | ``H-61 Shepherd`` = 90
    | ``H-71 Marshal`` = 91
    | ``H-81 Overseer`` = 92
    | ``Q-Series`` = 93
    | ``B-75 Beast`` = 94
    | ``B-86 Titan`` = 95
    | ``B-90 Cyclops`` = 96
    | ``B-99 Colossus`` = 97
    | ``C-40 Crusher`` = 98
    | ``Cetus Guard`` = 99
    | ``Quarantine Guard`` = 100
    | ``S7 Guard`` = 101
    | ``M Guard`` = 102
    | ``M Shell_Atk`` = 103
    | ``M Shell_Def`` = 104
    | ``Enhanced Grunt`` = 105
    | ``Enhanced Sentry`` = 106
    | ``Enhanced Demolisher`` = 107
    | ``Enhanced Hunter`` = 108
    | ``Enhanced Programmer`` = 109
    | ``Enhanced Q-Series`` = 110
    | ``Lightning`` = 111
    | ``Tracker`` = 112
    | ``Combat Programmer`` = 113
    | ``Investigator`` = 114
    | ``Striker`` = 115
    | ``Executioner`` = 116
    | ``Superbehemoth`` = 117
    | ``Alpha 7`` = 118
    | ``Fortress`` = 119
    | ``LRC-V4`` = 120
    | ``LRC-V5`` = 121
    | ``LRC-V6`` = 122
    | ``P_Grunt`` = 123
    | ``P_Duelist`` = 124
    | ``P_Sentry`` = 125
    | ``P_Demolisher`` = 126
    | ``P_Specialist`` = 127
    | ``P_Hunter`` = 128
    | ``P_Programmer`` = 129
    | ``Artisan`` = 130
    | ``Cobbler`` = 131
    | ``Subdweller`` = 132
    | ``Zionite`` = 133
    | ``Z-Technician`` = 134
    | ``Z_Courier`` = 135
    | ``Z_Recon`` = 136
    | ``Z_Light_5`` = 137
    | ``Z_Light_7`` = 138
    | ``Z_Light_9`` = 139
    | ``Z_Heavy_5`` = 140
    | ``Z_Heavy_7`` = 141
    | ``Z_Heavy_9`` = 142
    | ``Z_Experiment_8`` = 143
    | ``Z_Experiment_10`` = 144
    | ``Decomposer`` = 145
    | ``Packrat`` = 146
    | ``Samaritan`` = 147
    | ``Tinkerer`` = 148
    | ``Demented`` = 149
    | ``Furnace`` = 150
    | ``Parasite`` = 151
    | ``Thief_5`` = 152
    | ``Thief_7`` = 153
    | ``Assembler`` = 154
    | ``Assembled_4`` = 155
    | ``Assembled_7`` = 156
    | ``Golem_8`` = 157
    | ``Golem_0`` = 158
    | ``Surgeon_4`` = 159
    | ``Surgeon_6`` = 160
    | ``Wasp_5`` = 161
    | ``Wasp_7`` = 162
    | ``Thug_5`` = 163
    | ``Thug_7`` = 164
    | ``Savage_5`` = 165
    | ``Savage_7`` = 166
    | ``Butcher_5`` = 167
    | ``Butcher_7`` = 168
    | ``Bouncer_7`` = 169
    | ``Martyr_5`` = 170
    | ``Martyr_7`` = 171
    | ``Guerilla_5`` = 172
    | ``Guerilla_7`` = 173
    | ``Wizard_5`` = 174
    | ``Wizard_7`` = 175
    | ``Marauder_6`` = 176
    | ``Marauder_8`` = 177
    | ``Fireman_5`` = 178
    | ``Fireman_7`` = 179
    | ``Mutant_5`` = 180
    | ``Mutant_6`` = 181
    | ``Mutant_7`` = 182
    | ``Mutant_8`` = 183
    | ``Infiltrator_6`` = 184
    | ``Infiltrator_7`` = 185
    | ``Infiltrator_8`` = 186
    | ``Sapper`` = 187
    | ``Commander`` = 188
    | ``Knight`` = 189
    | ``Troll`` = 190
    | ``Dragon`` = 191
    | ``Hydra`` = 192
    | ``Borebot`` = 193
    | ``Revision`` = 194
    | ``Anomaly`` = 195
    | ``Lesser Abomination`` = 196
    | ``Minor Abomination`` = 197
    | ``Greater Abomination`` = 198
    | ``Major Abomination`` = 199
    | ``Ultimate Abomination`` = 200
    | ``Final Abomination`` = 201
    | ``Player`` = 202
    | ``Player 2`` = 203
    | ``Sauler`` = 204
    | ``Elf`` = 205
    | ``YI-UF0`` = 206
    | ``01-MTF`` = 207
    | ``Warlord Statue`` = 208
    | ``Warbot`` = 209
    | ``5H-AD0`` = 210
    | ``Surveybot 24`` = 211
    | ``AZ-K3N`` = 212
    | ``HV-R5K`` = 213
    | ``7R-MNS`` = 214
    | ``VL-GR5`` = 215
    | ``8R-AWN`` = 216
    | ``EX-BIN`` = 217
    | ``EX-DEC`` = 218
    | ``EX-HEX`` = 219
    | ``Zion_Hero_01`` = 220
    | ``Zion_Hero_02`` = 221
    | ``Zion_Hero_03`` = 222
    | ``Zion_Hero_04`` = 223
    | ``Zion_Hero_05`` = 224
    | ``Zion_Hero_06`` = 225
    | ``Zion_Hero_07`` = 226
    | ``Zion_Hero_08`` = 227
    | ``Zion_Hero_09`` = 228
    | ``Revision 17`` = 229
    | ``Revision 17__`` = 230
    | ``Imprinter`` = 231
    | ``Z-Imprinter`` = 232
    | ``A8`` = 233
    | ``A7`` = 234
    | ``A6`` = 235
    | ``A5`` = 236
    | ``A4`` = 237
    | ``A3`` = 238
    | ``A2`` = 239
    | ``Zhirov`` = 240
    | ``Perun`` = 241
    | ``Svarog`` = 242
    | ``Data Miner`` = 243
    | ``Fake_God_Mode`` = 244
    | ``God_Mode`` = 245
    | ``Warlord`` = 246
    | ``Warlord_B`` = 247
    | ``Warlord AM-PH4`` = 248
    | ``Warlord MG-163`` = 249
    | ``Warlord HL-1SK`` = 250
    | ``Warlord SH-K8T`` = 251
    | ``Warlord D3-CKR`` = 252
    | ``Warlord 4Z-XS3`` = 253
    | ``Warlord KY-Z71`` = 254
    | ``Sigix Containment Pod`` = 255
    | ``Sigix Exoskeleton`` = 256
    | ``Sigix Warrior`` = 257
    | ``MAINC_A`` = 258
    | ``MAINC_B`` = 259
    | ``Architect`` = 260

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
    | 10 -> Entity.``Advanced Drone``
    | 11 -> Entity.``Stealth Drone``
    | 12 -> Entity.``Trailblazer``
    | 13 -> Entity.``Thief Drone``
    | 14 -> Entity.``Army Drone``
    | 15 -> Entity.``Swarm Drone``
    | 16 -> Entity.``Combat Drone``
    | 17 -> Entity.``Assault Drone``
    | 18 -> Entity.``Bomb Drone``
    | 19 -> Entity.``Wardrone``
    | 20 -> Entity.``DAS Turret``
    | 21 -> Entity.``Autobeam Turret``
    | 22 -> Entity.``K-01 Serf``
    | 23 -> Entity.``U-05 Engineer``
    | 24 -> Entity.``T-07 Excavator``
    | 25 -> Entity.``A-02 Transporter``
    | 26 -> Entity.``A-15 Conveyor``
    | 27 -> Entity.``A-27 Freighter``
    | 28 -> Entity.``R-06 Scavenger``
    | 29 -> Entity.``R-10 Processor``
    | 30 -> Entity.``C-30 ARC``
    | 31 -> Entity.``M-14 Sweeper``
    | 32 -> Entity.``M-22 Extractor``
    | 33 -> Entity.``M-30 Cleanser``
    | 34 -> Entity.``M-13 Machinist``
    | 35 -> Entity.``M-28 Smith``
    | 36 -> Entity.``M-36 Artificer``
    | 37 -> Entity.``O-16 Technician``
    | 38 -> Entity.``O-24 Administrator``
    | 39 -> Entity.``O-32 Director``
    | 40 -> Entity.``N-00 Fly``
    | 41 -> Entity.``N-01 Spotter``
    | 42 -> Entity.``W-16 Scout``
    | 43 -> Entity.``W-25 Informer``
    | 44 -> Entity.``W-44 Eye``
    | 45 -> Entity.``S-10 Pest``
    | 46 -> Entity.``S-27 Virus``
    | 47 -> Entity.``S-43 Plague``
    | 48 -> Entity.``C-17 Slicer``
    | 49 -> Entity.``C-35 Carver``
    | 50 -> Entity.``C-57 Dissector``
    | 51 -> Entity.``E-15 Imp``
    | 52 -> Entity.``G-34 Mercenary``
    | 53 -> Entity.``G-47 Trooper``
    | 54 -> Entity.``G-50 Soldier``
    | 55 -> Entity.``G-67 Veteran``
    | 56 -> Entity.``G-73 Enforcer``
    | 57 -> Entity.``B-36 Bruiser``
    | 58 -> Entity.``B-48 Gladiator``
    | 59 -> Entity.``B-60 Warrior``
    | 60 -> Entity.``B-74 Champion``
    | 61 -> Entity.``L-31 Rogue``
    | 62 -> Entity.``L-41 Fighter``
    | 63 -> Entity.``L-61 Swordsman``
    | 64 -> Entity.``I-25 Savior``
    | 65 -> Entity.``I-36 Angel``
    | 66 -> Entity.``I-47 Archangel``
    | 67 -> Entity.``C-55 Analyst``
    | 68 -> Entity.``C-65 Expert``
    | 69 -> Entity.``Y-45 Defender``
    | 70 -> Entity.``Y-54 Guardian``
    | 71 -> Entity.``Y-64 Sentinel``
    | 72 -> Entity.``Y-72 Warden``
    | 73 -> Entity.``D-53 Grenadier``
    | 74 -> Entity.``D-63 Destroyer``
    | 75 -> Entity.``D-83 Annihilator``
    | 76 -> Entity.``X-57 Shotgunner``
    | 77 -> Entity.``X-62 Marksman``
    | 78 -> Entity.``X-67 Chaingunner``
    | 79 -> Entity.``X-72 Disruptor``
    | 80 -> Entity.``X-77 Beamer``
    | 81 -> Entity.``X-82 Rainmaker``
    | 82 -> Entity.``X-87 Electro``
    | 83 -> Entity.``H-55 Commando``
    | 84 -> Entity.``H-66 Slayer``
    | 85 -> Entity.``H-77 Assassin``
    | 86 -> Entity.``H-88 Terminator``
    | 87 -> Entity.``P-60 Hacker``
    | 88 -> Entity.``P-70 Sage``
    | 89 -> Entity.``P-80 Master``
    | 90 -> Entity.``H-61 Shepherd``
    | 91 -> Entity.``H-71 Marshal``
    | 92 -> Entity.``H-81 Overseer``
    | 93 -> Entity.``Q-Series``
    | 94 -> Entity.``B-75 Beast``
    | 95 -> Entity.``B-86 Titan``
    | 96 -> Entity.``B-90 Cyclops``
    | 97 -> Entity.``B-99 Colossus``
    | 98 -> Entity.``C-40 Crusher``
    | 99 -> Entity.``Cetus Guard``
    | 100 -> Entity.``Quarantine Guard``
    | 101 -> Entity.``S7 Guard``
    | 102 -> Entity.``M Guard``
    | 103 -> Entity.``M Shell_Atk``
    | 104 -> Entity.``M Shell_Def``
    | 105 -> Entity.``Enhanced Grunt``
    | 106 -> Entity.``Enhanced Sentry``
    | 107 -> Entity.``Enhanced Demolisher``
    | 108 -> Entity.``Enhanced Hunter``
    | 109 -> Entity.``Enhanced Programmer``
    | 110 -> Entity.``Enhanced Q-Series``
    | 111 -> Entity.``Lightning``
    | 112 -> Entity.``Tracker``
    | 113 -> Entity.``Combat Programmer``
    | 114 -> Entity.``Investigator``
    | 115 -> Entity.``Striker``
    | 116 -> Entity.``Executioner``
    | 117 -> Entity.``Superbehemoth``
    | 118 -> Entity.``Alpha 7``
    | 119 -> Entity.``Fortress``
    | 120 -> Entity.``LRC-V4``
    | 121 -> Entity.``LRC-V5``
    | 122 -> Entity.``LRC-V6``
    | 123 -> Entity.``P_Grunt``
    | 124 -> Entity.``P_Duelist``
    | 125 -> Entity.``P_Sentry``
    | 126 -> Entity.``P_Demolisher``
    | 127 -> Entity.``P_Specialist``
    | 128 -> Entity.``P_Hunter``
    | 129 -> Entity.``P_Programmer``
    | 130 -> Entity.``Artisan``
    | 131 -> Entity.``Cobbler``
    | 132 -> Entity.``Subdweller``
    | 133 -> Entity.``Zionite``
    | 134 -> Entity.``Z-Technician``
    | 135 -> Entity.``Z_Courier``
    | 136 -> Entity.``Z_Recon``
    | 137 -> Entity.``Z_Light_5``
    | 138 -> Entity.``Z_Light_7``
    | 139 -> Entity.``Z_Light_9``
    | 140 -> Entity.``Z_Heavy_5``
    | 141 -> Entity.``Z_Heavy_7``
    | 142 -> Entity.``Z_Heavy_9``
    | 143 -> Entity.``Z_Experiment_8``
    | 144 -> Entity.``Z_Experiment_10``
    | 145 -> Entity.``Decomposer``
    | 146 -> Entity.``Packrat``
    | 147 -> Entity.``Samaritan``
    | 148 -> Entity.``Tinkerer``
    | 149 -> Entity.``Demented``
    | 150 -> Entity.``Furnace``
    | 151 -> Entity.``Parasite``
    | 152 -> Entity.``Thief_5``
    | 153 -> Entity.``Thief_7``
    | 154 -> Entity.``Assembler``
    | 155 -> Entity.``Assembled_4``
    | 156 -> Entity.``Assembled_7``
    | 157 -> Entity.``Golem_8``
    | 158 -> Entity.``Golem_0``
    | 159 -> Entity.``Surgeon_4``
    | 160 -> Entity.``Surgeon_6``
    | 161 -> Entity.``Wasp_5``
    | 162 -> Entity.``Wasp_7``
    | 163 -> Entity.``Thug_5``
    | 164 -> Entity.``Thug_7``
    | 165 -> Entity.``Savage_5``
    | 166 -> Entity.``Savage_7``
    | 167 -> Entity.``Butcher_5``
    | 168 -> Entity.``Butcher_7``
    | 169 -> Entity.``Bouncer_7``
    | 170 -> Entity.``Martyr_5``
    | 171 -> Entity.``Martyr_7``
    | 172 -> Entity.``Guerilla_5``
    | 173 -> Entity.``Guerilla_7``
    | 174 -> Entity.``Wizard_5``
    | 175 -> Entity.``Wizard_7``
    | 176 -> Entity.``Marauder_6``
    | 177 -> Entity.``Marauder_8``
    | 178 -> Entity.``Fireman_5``
    | 179 -> Entity.``Fireman_7``
    | 180 -> Entity.``Mutant_5``
    | 181 -> Entity.``Mutant_6``
    | 182 -> Entity.``Mutant_7``
    | 183 -> Entity.``Mutant_8``
    | 184 -> Entity.``Infiltrator_6``
    | 185 -> Entity.``Infiltrator_7``
    | 186 -> Entity.``Infiltrator_8``
    | 187 -> Entity.``Sapper``
    | 188 -> Entity.``Commander``
    | 189 -> Entity.``Knight``
    | 190 -> Entity.``Troll``
    | 191 -> Entity.``Dragon``
    | 192 -> Entity.``Hydra``
    | 193 -> Entity.``Borebot``
    | 194 -> Entity.``Revision``
    | 195 -> Entity.``Anomaly``
    | 196 -> Entity.``Lesser Abomination``
    | 197 -> Entity.``Minor Abomination``
    | 198 -> Entity.``Greater Abomination``
    | 199 -> Entity.``Major Abomination``
    | 200 -> Entity.``Ultimate Abomination``
    | 201 -> Entity.``Final Abomination``
    | 202 -> Entity.``Player``
    | 203 -> Entity.``Player 2``
    | 204 -> Entity.``Sauler``
    | 205 -> Entity.``Elf``
    | 206 -> Entity.``YI-UF0``
    | 207 -> Entity.``01-MTF``
    | 208 -> Entity.``Warlord Statue``
    | 209 -> Entity.``Warbot``
    | 210 -> Entity.``5H-AD0``
    | 211 -> Entity.``Surveybot 24``
    | 212 -> Entity.``AZ-K3N``
    | 213 -> Entity.``HV-R5K``
    | 214 -> Entity.``7R-MNS``
    | 215 -> Entity.``VL-GR5``
    | 216 -> Entity.``8R-AWN``
    | 217 -> Entity.``EX-BIN``
    | 218 -> Entity.``EX-DEC``
    | 219 -> Entity.``EX-HEX``
    | 220 -> Entity.``Zion_Hero_01``
    | 221 -> Entity.``Zion_Hero_02``
    | 222 -> Entity.``Zion_Hero_03``
    | 223 -> Entity.``Zion_Hero_04``
    | 224 -> Entity.``Zion_Hero_05``
    | 225 -> Entity.``Zion_Hero_06``
    | 226 -> Entity.``Zion_Hero_07``
    | 227 -> Entity.``Zion_Hero_08``
    | 228 -> Entity.``Zion_Hero_09``
    | 229 -> Entity.``Revision 17``
    | 230 -> Entity.``Revision 17__``
    | 231 -> Entity.``Imprinter``
    | 232 -> Entity.``Z-Imprinter``
    | 233 -> Entity.``A8``
    | 234 -> Entity.``A7``
    | 235 -> Entity.``A6``
    | 236 -> Entity.``A5``
    | 237 -> Entity.``A4``
    | 238 -> Entity.``A3``
    | 239 -> Entity.``A2``
    | 240 -> Entity.``Zhirov``
    | 241 -> Entity.``Perun``
    | 242 -> Entity.``Svarog``
    | 243 -> Entity.``Data Miner``
    | 244 -> Entity.``Fake_God_Mode``
    | 245 -> Entity.``God_Mode``
    | 246 -> Entity.``Warlord``
    | 247 -> Entity.``Warlord_B``
    | 248 -> Entity.``Warlord AM-PH4``
    | 249 -> Entity.``Warlord MG-163``
    | 250 -> Entity.``Warlord HL-1SK``
    | 251 -> Entity.``Warlord SH-K8T``
    | 252 -> Entity.``Warlord D3-CKR``
    | 253 -> Entity.``Warlord 4Z-XS3``
    | 254 -> Entity.``Warlord KY-Z71``
    | 255 -> Entity.``Sigix Containment Pod``
    | 256 -> Entity.``Sigix Exoskeleton``
    | 257 -> Entity.``Sigix Warrior``
    | 258 -> Entity.``MAINC_A``
    | 259 -> Entity.``MAINC_B``
    | 260 -> Entity.``Architect``
    | x -> raise (System.ArgumentException(sprintf "Invalid value for entity type: %A" x))

/// Represents the location in-world
type MapType =
    | MAP_NONE = 0
    | MAP_SAN = 1
    | MAP_SCR = 2
    | MAP_MAT = 3
    | MAP_FAC = 4
    | MAP_RES = 5
    | MAP_ACC = 6
    | MAP_SUR = 7
    | MAP_MIN = 8
    | MAP_EXI = 9
    | MAP_STO = 10
    | MAP_REC = 11
    | MAP_WAS = 12
    | MAP_GAR = 13
    | MAP_DSF = 35
    | MAP_LOW = 14
    | MAP_UPP = 15
    | MAP_PRO = 16
    | MAP_DEE = 17
    | MAP_ZIO = 18
    | MAP_DAT = 19
    | MAP_ZHI = 20
    | MAP_WAR = 21
    | MAP_EXT = 22
    | MAP_CET = 23
    | MAP_ARC = 24
    | MAP_HUB = 25
    | MAP_ARM = 26
    | MAP_LAB = 27
    | MAP_QUA = 28
    | MAP_TES = 29
    | MAP_SEC = 30
    | MAP_COM = 31
    | MAP_AC0 = 32
    | MAP_LAI = 33
    | MAP_TOW = 34
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
