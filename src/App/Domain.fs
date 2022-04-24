module Domain

type cell =
    | NO_CELL = -1
    | EARTH = 0
    | EARTH_EXC = 1
    | GROUND = 2
    | FLOOR_SAN = 3
    | FLOOR_SCR = 4
    | FLOOR_MAT = 5
    | FLOOR_FAC = 6
    | FLOOR_RES = 7
    | FLOOR_ACC = 8
    | FLOOR_SUR = 9
    | FLOOR_MIN = 10
    | FLOOR_EXI = 11
    | FLOOR_STO = 12
    | FLOOR_REC = 13
    | FLOOR_WAS = 14
    | FLOOR_GAR = 15
    | FLOOR_DSF = 16
    | FLOOR_LOW = 17
    | FLOOR_UPP = 18
    | FLOOR_PRO = 19
    | FLOOR_DEE = 20
    | FLOOR_ZIO = 21
    | FLOOR_DAT = 22
    | FLOOR_ZHI = 23
    | FLOOR_WAR = 24
    | FLOOR_EXT = 25
    | FLOOR_CET = 26
    | FLOOR_ARC = 27
    | FLOOR_HUB = 28
    | FLOOR_ARM = 29
    | FLOOR_LAB = 30
    | FLOOR_QUA = 31
    | FLOOR_TES = 32
    | FLOOR_SEC = 33
    | FLOOR_COM = 34
    | FLOOR_AC0 = 35
    | FLOOR_LAI = 36
    | FLOOR_TOW = 37
    | TEMP_WALL = 38
    | WALL_SAN = 39
    | WALL_SCR = 40
    | WALL_MAT = 41
    | WALL_FAC = 42
    | WALL_RES = 43
    | WALL_ACC = 44
    | WALL_SUR = 45
    | WALL_MIN = 46
    | WALL_EXI = 47
    | WALL_STO = 48
    | WALL_REC = 49
    | WALL_WAS = 50
    | WALL_GAR = 51
    | WALL_DSF = 52
    | WALL_LOW = 53
    | WALL_UPP = 54
    | WALL_PRO = 55
    | WALL_DEE = 56
    | WALL_ZIO = 57
    | WALL_DAT = 58
    | WALL_ZHI = 59
    | WALL_WAR = 60
    | WALL_EXT = 61
    | WALL_CET = 62
    | WALL_ARC = 63
    | WALL_HUB = 64
    | WALL_ARM = 65
    | WALL_LAB = 66
    | WALL_QUA = 67
    | WALL_TES = 68
    | WALL_SEC = 69
    | WALL_COM = 70
    | WALL_AC0 = 71
    | WALL_LAI = 72
    | WALL_TOW = 73
    | BARRIER_SAN = 74
    | BARRIER_SCR = 75
    | BARRIER_MAT = 76
    | BARRIER_FAC = 77
    | BARRIER_RES = 78
    | BARRIER_ACC = 79
    | BARRIER_SUR = 80
    | BARRIER_MIN = 81
    | BARRIER_EXI = 82
    | BARRIER_STO = 83
    | BARRIER_REC = 84
    | BARRIER_WAS = 85
    | BARRIER_GAR = 86
    | BARRIER_DSF = 87
    | BARRIER_LOW = 88
    | BARRIER_UPP = 89
    | BARRIER_PRO = 90
    | BARRIER_DEE = 91
    | BARRIER_ZIO = 92
    | BARRIER_DAT = 93
    | BARRIER_ZHI = 94
    | BARRIER_WAR = 95
    | BARRIER_EXT = 96
    | BARRIER_CET = 97
    | BARRIER_ARC = 98
    | BARRIER_HUB = 99
    | BARRIER_ARM = 100
    | BARRIER_LAB = 101
    | BARRIER_QUA = 102
    | BARRIER_TES = 103
    | BARRIER_SEC = 104
    | BARRIER_COM = 105
    | BARRIER_AC0 = 106
    | BARRIER_LAI = 107
    | BARRIER_TOW = 108
    | SHORTCUT_SAN = 109
    | SHORTCUT_SCR = 110
    | SHORTCUT_MAT = 111
    | SHORTCUT_FAC = 112
    | SHORTCUT_RES = 113
    | SHORTCUT_ACC = 114
    | SHORTCUT_SUR = 115
    | SHORTCUT_MIN = 116
    | SHORTCUT_EXI = 117
    | SHORTCUT_STO = 118
    | SHORTCUT_REC = 119
    | SHORTCUT_WAS = 120
    | SHORTCUT_GAR = 121
    | SHORTCUT_DSF = 122
    | SHORTCUT_LOW = 123
    | SHORTCUT_UPP = 124
    | SHORTCUT_PRO = 125
    | SHORTCUT_DEE = 126
    | SHORTCUT_ZIO = 127
    | SHORTCUT_DAT = 128
    | SHORTCUT_ZHI = 129
    | SHORTCUT_WAR = 130
    | SHORTCUT_EXT = 131
    | SHORTCUT_CET = 132
    | SHORTCUT_ARC = 133
    | SHORTCUT_HUB = 134
    | SHORTCUT_ARM = 135
    | SHORTCUT_LAB = 136
    | SHORTCUT_QUA = 137
    | SHORTCUT_TES = 138
    | SHORTCUT_SEC = 139
    | SHORTCUT_COM = 140
    | SHORTCUT_AC0 = 141
    | SHORTCUT_LAI = 142
    | SHORTCUT_TOW = 143
    | SHORTCUT_KNOWN = 144
    | PHASEWALL_SAN = 145
    | PHASEWALL_SCR = 146
    | PHASEWALL_MAT = 147
    | PHASEWALL_FAC = 148
    | PHASEWALL_RES = 149
    | PHASEWALL_ACC = 150
    | PHASEWALL_SUR = 151
    | PHASEWALL_MIN = 152
    | PHASEWALL_EXI = 153
    | PHASEWALL_STO = 154
    | PHASEWALL_REC = 155
    | PHASEWALL_WAS = 156
    | PHASEWALL_GAR = 157
    | PHASEWALL_DSF = 158
    | PHASEWALL_LOW = 159
    | PHASEWALL_UPP = 160
    | PHASEWALL_PRO = 161
    | PHASEWALL_DEE = 162
    | PHASEWALL_ZIO = 163
    | PHASEWALL_DAT = 164
    | PHASEWALL_ZHI = 165
    | PHASEWALL_WAR = 166
    | PHASEWALL_EXT = 167
    | PHASEWALL_CET = 168
    | PHASEWALL_ARC = 169
    | PHASEWALL_HUB = 170
    | PHASEWALL_ARM = 171
    | PHASEWALL_LAB = 172
    | PHASEWALL_QUA = 173
    | PHASEWALL_TES = 174
    | PHASEWALL_SEC = 175
    | PHASEWALL_COM = 176
    | PHASEWALL_AC0 = 177
    | PHASEWALL_LAI = 178
    | PHASEWALL_TOW = 179
    | PHASEWALL_KNOWN = 180
    | SEALED_DOOR = 181
    | DOOR_SAN = 182
    | DOOR_SCR = 183
    | DOOR_MAT = 184
    | DOOR_FAC = 185
    | DOOR_RES = 186
    | DOOR_ACC = 187
    | DOOR_SUR = 188
    | DOOR_MIN = 189
    | DOOR_EXI = 190
    | DOOR_STO = 191
    | DOOR_REC = 192
    | DOOR_WAS = 193
    | DOOR_GAR = 194
    | DOOR_DSF = 195
    | DOOR_LOW = 196
    | DOOR_UPP = 197
    | DOOR_PRO = 198
    | DOOR_DEE = 199
    | DOOR_ZIO = 200
    | DOOR_DAT = 201
    | DOOR_ZHI = 202
    | DOOR_WAR = 203
    | DOOR_EXT = 204
    | DOOR_CET = 205
    | DOOR_ARC = 206
    | DOOR_HUB = 207
    | DOOR_ARM = 208
    | DOOR_LAB = 209
    | DOOR_QUA = 210
    | DOOR_TES = 211
    | DOOR_SEC = 212
    | DOOR_COM = 213
    | DOOR_AC0 = 214
    | DOOR_LAI = 215
    | DOOR_TOW = 216
    | STAIRS_SAN = 217
    | STAIRS_SCR = 218
    | STAIRS_MAT = 219
    | STAIRS_FAC = 220
    | STAIRS_RES = 221
    | STAIRS_SUR = 222
    | STAIRS_ACC = 223
    | STAIRS_MIN = 224
    | STAIRS_EXI = 225
    | STAIRS_STO = 226
    | STAIRS_REC = 227
    | STAIRS_WAS = 228
    | STAIRS_GAR = 229
    | STAIRS_DSF = 230
    | STAIRS_LOW = 231
    | STAIRS_UPP = 232
    | STAIRS_PRO = 233
    | STAIRS_DEE = 234
    | STAIRS_ZIO = 235
    | STAIRS_DAT = 236
    | STAIRS_ZHI = 237
    | STAIRS_WAR = 238
    | STAIRS_EXT = 239
    | STAIRS_CET = 240
    | STAIRS_ARC = 241
    | STAIRS_HUB = 242
    | STAIRS_ARM = 243
    | STAIRS_LAB = 244
    | STAIRS_QUA = 245
    | STAIRS_TES = 246
    | STAIRS_SEC = 247
    | STAIRS_COM = 248
    | STAIRS_AC0 = 249
    | STAIRS_LAI = 250
    | STAIRS_TOW = 251
    | STAIRS_NOACCESS = 252
    | STAIRS_BLOCKED = 253
    | STAIRS_GAR_OPEN = 254
    | STAIRS_DSF_OPEN = 255
    | STAIRS_SHORTCUT = 256

type Item =
    | Matter
    | DataCore
    | DerelictLog
    | SchematicArchive
    | ImprinterDataCore
    | A2DataCore
    | A7DataCore
    | MaincDataCore
    | ArchitectDataCore
    | Scrap
    | Protomatter
    | IonEngine
    | LgtIonEngine
    | BackupPowerI
    | ImpIonEngine
    | RnfIonEngine
    | HvyIonEngine
    | CldIonEngine
    | DeuteriumEngine
    | LgtDeuteriumEngine
    | BackupPowerIii
    | NuclearCore
    | LgtNuclearCore
    | ImpDeuteriumEngine
    | RnfDeuteriumEngine
    | HybDeuteriumEngine
    | HvyDeuteriumEngine
    | CldDeuteriumEngine
    | EnhNuclearCore
    | MicNuclearCore
    | MakPowerSource
    | AngularMomentumEngine
    | LgtAngularMomentumEngine
    | FcellEngine
    | FissionCore
    | LgtFissionCore
    | HybFissionCore
    | FusionCompressor
    | ColdFusionReactor
    | NeutrinoCore
    | LgtNeutrinoCore
    | RnfFissionCore
    | EnhFissionCore
    | CldFissionCore
    | MicFissionCore
    | FusionReactor
    | AntimatterReactor
    | LgtAntimatterReactor
    | RnfAntimatterReactor
    | HybAntimatterReactor
    | BackupPowerVii
    | HvyAntimatterReactor
    | MniFusionReactor
    | ImpFusionCompressor
    | MicNeutrinoCore
    | ZioLightDmReactor
    | ZioHeavyDmReactor
    | ParticleReactor
    | LgtParticleReactor
    | MicAntimatterReactor
    | ComParticleReactor
    | CldAntimatterReactor
    | GravitonReactor
    | AsbFluxGenerator
    | QuantumReactor
    | LgtQuantumReactor
    | RnfQuantumReactor
    | ImpQuantumReactor
    | ZeropointReactor
    | VortexChainReactor
    | SingularityReactor
    | MatterDrive
    | LgtTreads
    | ImpTreads
    | SpkTreads
    | ArmTreads
    | AdvTreads
    | MedTreads
    | ImpMediumTreads
    | SpkMediumTreads
    | ArmMediumTreads
    | HvyTreads
    | AdvMediumTreads
    | EnhArmoredMediumTreads
    | ImpHeavyTreads
    | HvySiegeTreads
    | SpkHeavyTreads
    | BiometalMediumTreads
    | ArmHeavyTreads
    | AdvHeavyTreads
    | ImpHeavySiegeTreads
    | CentriumHeavyTreads
    | Megatreads
    | BiometalHeavyTreads
    | ExpBiometalHeavyTreads
    | EnhArmoredHeavyTreads
    | AdvHeavySiegeTreads
    | HdnCentriumHeavyTreads
    | ExpBiometalMediumTreads
    | AluminumLeg
    | ImpAluminumLeg
    | CarbonfiberLeg
    | TitaniumLeg
    | VssLeg
    | ImpCarbonfiberLeg
    | ImpTitaniumLeg
    | MakLeg
    | FlexicarbonLeg
    | ArmLeg
    | ImpVssLeg
    | ZioCompositeLegI
    | EnhFlexicarbonLeg
    | EnhArmoredLeg
    | MyomerLeg
    | AdvVssLeg
    | AdvMyomerLeg
    | ExpFlexicarbonLeg
    | ZioCompositeLegIi
    | EtherialTendrils
    | BiometalLeg
    | EnhBiometalLeg
    | ExpMyomerLeg
    | TrollExoskeleton
    | AsbAlloyLeg
    | CentriumLeg
    | HdnCentriumLeg
    | ExpBiometalLeg
    | SigixExoskeleton
    | ZioSupercompositeLeg
    | PotentialLeg
    | MyomerExoskeleton
    | Wheel
    | ComWheel
    | ArmWheel
    | ArmHugeWheel
    | CentriumWheel
    | HdnCentriumWheel
    | HoverUnit
    | BackupPropulsionI
    | ImpHoverUnit
    | Airjet
    | AerolevUnit
    | AsbHoverUnit
    | BackupPropulsionIii
    | GravmagSystem
    | AsbHoverSystem
    | ImpAirjet
    | CldAirjet
    | ImpGravmagSystem
    | CldAerolevUnit
    | CmbAirjet
    | GravmagArray
    | MakHoverUnit
    | ZioGlidesysI
    | AntigravSystem
    | GyrokineticInverter
    | LinearGravjet
    | CldGravmagSystem
    | CmbGravmagSystem
    | ImpAntigravSystem
    | ImpGyrokineticInverter
    | ImpLinearGravjet
    | BackupPropulsionVii
    | ZioGlidesysIi
    | CldAntigravSystem
    | CmbAntigravSystem
    | AntigravArray
    | ExpGyrokineticInverter
    | CldLinearGravjet
    | CmbLinearGravjet
    | FlightUnit
    | VtolModule
    | ImpFlightUnit
    | CesiumionThruster
    | SurgeThruster
    | ImpVtolModule
    | XenonBombardmentThruster
    | ImpCesiumionThruster
    | CldVtolModule
    | MakFlightUnit
    | NuclearPulseThruster
    | ImpSurgeThruster
    | MniNuclearPulseThruster
    | CldCesiumionThruster
    | BiomechanicalWings
    | FieldPropulsionDrive
    | CldNuclearPulseThruster
    | ExpCesiumionThruster
    | NuclearPulseArray
    | MakMicrothruster
    | ImpulseThruster
    | AdvSurgeThruster
    | CldFieldPropulsionDrive
    | FieldPropulsionArray
    | DiametricDrive
    | FlyingFortressV7
    | Tthruster
    | IntegratedTrackerDrive
    | EtherialPropulsion
    | Qthruster
    | ElectronDiverter
    | ImpDiametricDrive
    | CldImpulseThruster
    | ImpulseThrusterArray
    | ImpQthruster
    | CldQthruster
    | ExpQthruster
    | Desublimator
    | PowerAmplifier
    | AdvPowerAmplifier
    | ExpPowerAmplifier
    | ThermalGenerator
    | ImpThermalGenerator
    | AdvThermalGenerator
    | ExpThermalGenerator
    | CryofiberWeb
    | ImpCryofiberWeb
    | AdvCryofiberWeb
    | HeatSink
    | ImpHeatSink
    | AdvHeatSink
    | ExpHeatSink
    | CoolingSystem
    | ImpCoolingSystem
    | AdvCoolingSystem
    | ExpCoolingSystem
    | CoolantNetwork
    | AsbNanovents
    | FrostArray
    | DisposableHeatSink
    | CoolantInjector
    | ImpCoolantInjector
    | AdvCoolantInjector
    | ExpCoolantInjector
    | SmlStorageUnit
    | MedStorageUnit
    | LrgStorageUnit
    | HcpStorageUnit
    | HugeStorageUnit
    | CargoStorageUnit
    | Humpback
    | Lightpack20
    | SmlBattery
    | MedBattery
    | LrgBattery
    | HcpBattery
    | ComBattery
    | EnergyWell
    | ImpEnergyWell
    | AdvEnergyWell
    | ExpEnergyWell
    | ZioBiocell
    | AsbBiocellArray
    | ZioBiocellArray
    | Superbattery
    | SmlMatterPod
    | MedMatterPod
    | LrgMatterPod
    | HcpMatterPod
    | ComMatterPod
    | MatterCompressor
    | ImpMatterCompressor
    | AdvMatterCompressor
    | ExpMatterCompressor
    | Yiuf0sBottomlessMatterPit
    | WeightRedistSystem
    | AdvWeightRedistSystem
    | GravityNeutralizer
    | AdvGravityNeutralizer
    | QuantumShadingMachine
    | AsbSuspensionFrame
    | AdvQuantumShadingMachine
    | AsbMetafiberNetwork
    | ZioMetafieldGenerator
    | StFieldCompressor
    | StructuralScanner
    | TrapScanner
    | ImpTrapScanner
    | MakTrapScanner
    | AdvTrapScanner
    | MachineAnalyzer
    | Triangulator
    | VisualProcessingUnit
    | AdvVisualProcessingUnit
    | EnhOpticalArray
    | ExpOpticalArray
    | SpectralAnalyzer
    | SensorArray
    | ImpSensorArray
    | AdvSensorArray
    | LrnSensorArray
    | MakSensorArray
    | ExpSensorArray
    | SignalInterpreter
    | ImpSignalInterpreter
    | AdvSignalInterpreter
    | ExpSignalInterpreter
    | ActiveSensorSuite
    | TerrainScanner
    | ImpTerrainScanner
    | AdvTerrainScanner
    | MakTerrainScanner
    | LrnTerrainScanner
    | ExpTerrainScanner
    | Surveybot24Scanner
    | TerrainScanProcessor
    | ImpTerrainScanProcessor
    | MakTerrainScanProcessor
    | AdvTerrainScanProcessor
    | ExpTerrainScanProcessor
    | Surveybot24Chip
    | SeismicDetector
    | TransportNetworkCoupler
    | ModifiedTnc
    | B10DecoderChipgeneric
    | B10DecoderChiplooter
    | B10DecoderChipscout
    | B10DecoderChipskirmisher
    | B10AlertChip
    | SalvageTargetingComputer
    | ImpSalvageTargetingComputer
    | MakSalvageTargetingComputer
    | AdvSalvageTargetingComputer
    | AsbCombatSuite
    | TargetingComputer
    | ImpTargetingComputer
    | AdvTargetingComputer
    | ExpTargetingComputer
    | TacticalCoordinationSuite
    | MeleeAnalysisSuite
    | ImpMeleeAnalysisSuite
    | AdvMeleeAnalysisSuite
    | ExpMeleeAnalysisSuite
    | LauncherGuidanceComputer
    | ImpLauncherGuidanceComputer
    | AdvLauncherGuidanceComputer
    | TargetAnalyzer
    | ImpTargetAnalyzer
    | AdvTargetAnalyzer
    | ExpTargetAnalyzer
    | CoreAnalyzer
    | ExpCoreAnalyzer
    | ArmorIntegrityAnalyzer
    | ImpArmorIntegrityAnalyzer
    | ExpArmorIntegrityAnalyzer
    | RecoilStabilizer
    | RecoilNullifier
    | MatterFilter
    | PrcMatterFilter
    | EnergyFilter
    | PrcEnergyFilter
    | ParticleCharger
    | ImpParticleCharger
    | AdvParticleCharger
    | ParticleAccelerator
    | ImpParticleAccelerator
    | AdvParticleAccelerator
    | Kinecellerator
    | ImpKinecellerator
    | AdvKinecellerator
    | LauncherLoader
    | QuantumCapacitor
    | WeaponCycler
    | ImpWeaponCycler
    | AdvWeaponCycler
    | ExpWeaponCycler
    | Microactuators
    | Nanoactuators
    | Femtoactuators
    | ActuatorArray
    | ImpActuatorArray
    | AdvActuatorArray
    | ExpActuatorArray
    | ForceBooster
    | ImpForceBooster
    | AdvForceBooster
    | StasisCanceller
    | TransmissionJammer
    | MakTransmissionJammer
    | ImpTransmissionJammer
    | AdvTransmissionJammer
    | ExpTransmissionJammer
    | EcmSuite
    | MakEcmSuite
    | AdvEcmSuite
    | ExpEcmSuite
    | ReactionControlSystem
    | ImpReactionControlSystem
    | AdvReactionControlSystem
    | ExpReactionControlSystem
    | PhaseShifter
    | ImpPhaseShifter
    | AdvPhaseShifter
    | ExpPhaseShifter
    | CloakingDevice
    | MakCloakingDevice
    | ImpCloakingDevice
    | AdvCloakingDevice
    | ExpCloakingDevice
    | CloakOfProtection
    | Shad0sCloak
    | CoreShielding
    | ImpCoreShielding
    | ExpCoreShielding
    | PowerShielding
    | ImpPowerShielding
    | ExpPowerShielding
    | PropulsionShielding
    | ImpPropulsionShielding
    | ExpPropulsionShielding
    | UtilityShielding
    | ImpUtilityShielding
    | ExpUtilityShielding
    | WeaponShielding
    | ImpWeaponShielding
    | ExpWeaponShielding
    | ZioWeaponCasing
    | LgtArmorPlating
    | MedArmorPlating
    | HvyArmorPlating
    | ZioLightCarapace
    | ZioHeavyCarapace
    | HrdLightArmorPlating
    | HrdMediumArmorPlating
    | HrdHeavyArmorPlating
    | ImpLightArmorPlating
    | ImpMediumArmorPlating
    | ImpHeavyArmorPlating
    | LyrLightArmorPlating
    | MakArmorPlating
    | LyrMediumArmorPlating
    | LyrHeavyArmorPlating
    | CentriumLightArmorPlating
    | CentriumMediumArmorPlating
    | CentriumHeavyArmorPlating
    | CentriumLinkedPlating
    | ReactivePlating
    | MedReactivePlating
    | MakKineticPlating
    | HvyReactivePlating
    | ReflectivePlating
    | MedReflectivePlating
    | MakThermalPlating
    | HvyReflectivePlating
    | BrawnsArmorth
    | BrawnsArmorex
    | InsulatedPlating
    | MedInsulatedPlating
    | HvyInsulatedPlating
    | DamperPlating
    | ZioShadeCarapace
    | ZioShadeArmor
    | AsbAlloyArmor
    | MakAblativeArmor
    | ActiveCoolingArmor
    | PoweredArmor
    | ImpPoweredArmor
    | AdvPoweredArmor
    | ExpPoweredArmor
    | IcutusBuckler
    | LgtRegenerativePlating
    | MedRegenerativePlating
    | HvyRegenerativePlating
    | ShellArmor
    | PhaseArmor
    | GrapheneBrace
    | FocalShield
    | ImpFocalShield
    | AdvFocalShield
    | ExpFocalShield
    | ThermalShield
    | ImpThermalShield
    | AdvThermalShield
    | ExpThermalShield
    | ThermalBarrier
    | BeamSplitter
    | ThermalDefenseSuite
    | ImpThermalDefenseSuite
    | AdvThermalDefenseSuite
    | ExpThermalDefenseSuite
    | ShockAbsorptionSystem
    | ImpShockAbsorptionSystem
    | ExpShockAbsorptionSystem
    | EmDisruptionField
    | AdvEmDisruptionField
    | ExpEmDisruptionField
    | MerlnsChromaticScreen
    | HardlightGenerator
    | ImpHardlightGenerator
    | AdvHardlightGenerator
    | ExpHardlightGenerator
    | ShieldGenerator
    | ImpShieldGenerator
    | AdvShieldGenerator
    | ExpShieldGenerator
    | ForceField
    | ImpForceField
    | AdvForceField
    | ExpForceField
    | TvrtlsUltimateField
    | VortexFieldProjector
    | RemoteShield
    | ImpRemoteShield
    | AdvRemoteShield
    | RemoteForceField
    | ImpRemoteForceField
    | EnergyMantle
    | ImpEnergyMantle
    | AegisRemoteShield
    | PhaseRedirector
    | PointDefenseSystem
    | PointDefenseArray
    | AntimissileSystem
    | ExChip1
    | HackingSuite
    | MakHackingSuite
    | ImpHackingSuite
    | AdvHackingSuite
    | ExpHackingSuite
    | SystemMapper
    | DeepNetworkScanner
    | ArchitectGodChipA
    | ExChip2
    | SystemShield
    | MakSystemShield
    | ImpSystemShield
    | AdvSystemShield
    | ExpSystemShield
    | GhostBarrier
    | QuantumRouter
    | ArchitectGodChipD
    | Authchiprnc
    | Authchiprcombat
    | Authchippower
    | Authchippropulsion
    | Authchipdevice
    | Authchipstorage
    | Authchipprocessor
    | Authchiparmor
    | Authchipweapon
    | RelayCouplernc
    | RelayCouplerc
    | RelayCouplerarc
    | RelayCouplerswarmer
    | RelayCouplercutter
    | RelayCouplergrunt
    | RelayCouplerbrawler
    | RelayCouplerduelist
    | RelayCouplersentry
    | RelayCouplerdemolisher
    | RelayCouplerspecialist
    | RelayCouplerhunter
    | RelayCouplerheavy
    | RelayCouplerbehemoth
    | RelayCouplerprogrammer
    | SkeletonBox
    | O1mtfsAutohacker
    | ComponentAnalysisSuite
    | ImpComponentAnalysisSuite
    | AdvComponentAnalysisSuite
    | DynamicInsulationSystem
    | ImpDynamicInsulationSystem
    | AdvDynamicInsulationSystem
    | SystemGuard
    | ImpSystemGuard
    | ExpSystemGuard
    | CorruptionScreen
    | ImpCorruptionScreen
    | AdvCorruptionScreen
    | SystemRestorationModule
    | MakSystemRestorationModule
    | ImpSystemRestorationModule
    | AdvSystemRestorationModule
    | SystemPurifier
    | ExpSystemPurifier
    | TractorBeam
    | HpwTractorBeam
    | LrnTractorBeam
    | MobileRefineryMkCclxvii
    | TrapExtractor
    | ImpTrapExtractor
    | AdvTrapExtractor
    | TrapReconfigurator
    | Recalibrator
    | ImpRecalibrator
    | AdvRecalibrator
    | FieldRecyclingUnit
    | ImpFieldRecyclingUnit
    | AdvFieldRecyclingUnit
    | ExpFieldRecyclingUnit
    | DroneBay
    | ZdroneBay
    | MniDroneBay
    | MappingDroneBay
    | AdvDroneBay
    | BombDroneBay
    | ThiefDroneBay
    | DecoyDroneBay
    | SpliceDroneBay
    | CombatDroneBay
    | AssaultDroneBay
    | StealthDroneBay
    | SwarmDroneBay
    | SupersonicDroneBay
    | SensorDroneBay
    | HackingDroneBay
    | MinesnifferDroneBay
    | Armyinabox
    | WardroneBay
    | BombFactoryNo2
    | MobileAssemblyUnit
    | HeartOfSteel
    | GolemUnit
    | PsuRigger
    | PhasingAfg
    | AsneutralizerNo17b
    | Chronowheel
    | DimensionalNodeInitializer
    | TransdimensionalReconstructor
    | HpwTransdimensionalReconstructor
    | CoreExpander
    | CoreRegenerator
    | IntegrityRedistributor
    | IntegratedDissipator
    | SuperchargedIntegratedDissipator
    | IntegratedThermoelectricNetwork
    | IntegratedReactor
    | SuperchargedIntegratedReactor
    | IntegratedMediator
    | CoreMembrane
    | NavigationEfficiencyMatrix
    | CoreResetMatrix
    | SubatomicReplicator
    | Terrabomb
    | CorePhysicsCalibrator
    | SpacefoldActivator
    | MicrowarpDrive
    | LcCapacitor
    | LrcArmor
    | LrcStorage
    | LrcEnergyWell
    | LrcMatterCompressor
    | LrcBoosters
    | LrcInsulator
    | EmPulseGun
    | HvyEmPulseGun
    | EmShotgun
    | ImpEmShotgun
    | ShockRifle
    | RiotGun
    | HvyEmShotgun
    | LightningGun
    | HvyRiotGun
    | ArcProjector
    | PrcShockRifle
    | HpwShockRifle
    | ArcThrower
    | ImpLightningGun
    | TeslaRifle
    | ImpArcProjector
    | HvyTeslaRifle
    | HypEmGaussRifle
    | ImpArcThrower
    | O1mtfsShockpuncher
    | GammaRifle
    | TachyonDispersionRay
    | Immobilizer
    | ModifiedEmGaussRifle
    | Awsexdec
    | EnhGammaRifle
    | MedLaser
    | SmlLaser
    | BackupLaserI
    | BeamRifle
    | ParticleGun
    | SpreadLaser
    | ImpMediumLaser
    | FieldLaser
    | PulseRifle
    | BackupLaserIii
    | HvyParticleGun
    | PrcBeamRifle
    | AdvBeamRifle
    | HvyLaser
    | GatlingLaser
    | CldPulseRifle
    | HpwFieldLaser
    | ImpSpreadLaser
    | MakLaser
    | PlasmaRifle
    | ThermicLaser
    | Beamcaster
    | ForceRifle
    | ImpHeavyLaser
    | StormLaser
    | ZioLasers
    | WaveGun
    | VariableChargeGun
    | HvyBeamcaster
    | CldPlasmaRifle
    | EnhForceRifle
    | HvyGatlingLaser
    | ZioPhasers
    | PhaseGun
    | DispersionRifle
    | BackupLaserVii
    | PlasmaStorm
    | AdvPlasmaRifle
    | HvyWaveGun
    | AdvVariableChargeGun
    | CldPhaseGun
    | LrnGatlingLaser
    | WarpGun
    | VortexRifle
    | ZioLaserm
    | Awsthermal
    | PdLaser
    | QuantumRifle
    | PrcPhaseGun
    | HvyDispersionRifle
    | VortexShotgun
    | VortexRail
    | ZioPhaserm
    | EnhQuantumRifle
    | ZioLaserh
    | HvyQuantumRifle
    | ZioPhaserh
    | GatlingBeam
    | SigixSheargun
    | ModifiedSigixSheargun
    | LgtEmPulseCannon
    | EmPulseCannon
    | ImpEmPulseCannon
    | ProtonCannon
    | LrnProtonCannon
    | DisruptorCannon
    | HvyProtonCannon
    | HerfCannon
    | HvyDisruptorCannon
    | CldProtonCannon
    | ProtonBurstCannon
    | ComHerfCannon
    | LatentEnergyStreamer
    | Nk0lasTeslaDoomcannon
    | Emds
    | HpwDisruptorCannon
    | BeamCannon
    | ParticleCannon
    | AdvBeamCannon
    | HvyParticleCannon
    | IonCannon
    | PlasmaCannon
    | HvyIonCannon
    | CldParticleCannon
    | PhaseCannon
    | HvyPlasmaCannon
    | CldPlasmaCannon
    | ComIonCannon
    | IonBurstCannon
    | AdvPlasmaCannon
    | HvyPhaseCannon
    | NeutronCannon
    | MatterNeutralizer
    | HvyNeutronCannon
    | LrnPhaseCannon
    | CldPhaseCannon
    | VortexCannon
    | GuiPlasmaCannon
    | NovaCannon
    | ImpMatterNeutralizer
    | VortexDriver
    | ZioAlphaCannon
    | AsbFocalCannon
    | EnhNovaCannon
    | Firepult
    | YoloCannon
    | PotentialCannon
    | WarpCannon
    | CldNovaCannon
    | NullCannon
    | ImpPotentialCannon
    | Disintegrator
    | CoreCannon
    | SigixShearcannon
    | DrainedLcannon
    | Lcannon
    | ZioAlphaCannonMkIi
    | Bfg9kVortexEdition
    | AssaultRifle
    | AsbRifle
    | LgtAssaultRifle
    | HvyAssaultRifle
    | Autogun
    | Shotgun
    | BattleRifle
    | AsbHeavyRifle
    | ImpAssaultRifle
    | Minigun
    | HpwShotgun
    | AsbShotgun
    | BarrageGun
    | EnhAutogun
    | GaussRifle
    | AsbGaussRifle
    | FlakGun
    | PrcAssaultRifle
    | HvyBattleRifle
    | MakShrapnelGun
    | CoilGun
    | HypGaussRifle
    | HvyMachineGun
    | ImpHeavyMachineGun
    | ComGaussRifle
    | XlAutogunSubcomponent
    | KePenetrator
    | HypCoilGun
    | ImpKePenetrator
    | EnhCoilGun
    | ComCoilGun
    | Railgun
    | AdvKePenetrator
    | LinkedAutogun
    | Awsgauss
    | HypRailgun
    | HelicalRailgun
    | ComRailgun
    | XlAutogunArray
    | AshsBoomstick
    | BrawnsBoregun
    | Multirail
    | HypMultirail
    | Shad0sSniperRifle
    | A3sSniperRifle
    | LgtCannon
    | ImpLightCannon
    | BattleCannon
    | AssaultCannon
    | HvyAssaultCannon
    | FlakCannon
    | AdvAssaultCannon
    | GaussCannon
    | SlugCannon
    | MniAssaultCannon
    | MagneticAccelerationCannon
    | HvyFlakCannon
    | BoreCannon
    | AntimatterCannon
    | MassDriver
    | HvyMassDriver
    | EnhGaussCannon
    | HypGaussCannon
    | TrirailAccelerator
    | HardcellCannon
    | HvyGaussCannon
    | HypMassDriver
    | HvyAutocannon
    | DasCannon
    | LgtAntimatterCannon
    | LinearAccelerator
    | HvyLinearAccelerator
    | ComMassDriver
    | HvyHardcellCannon
    | ComLinearAccelerator
    | HypLinearAccelerator
    | HclLinearAccelerator
    | GravitonCannon
    | BlastCannon
    | P13cesGatlingFlakker
    | Awsautocannon
    | Perforator
    | OmegaCannon
    | EmpBlaster
    | ShockBombLauncher
    | AdvEmpBlaster
    | ProtonMissileLauncher
    | ImpProtonMissileLauncher
    | GuiEmpBlaster
    | HvyShockBombLauncher
    | TeslaBombLauncher
    | HvyProtonMissileLauncher
    | ComTeslaBombLauncher
    | GammaBombArray
    | EnhGammaBombArray
    | GrenadeLauncher
    | RocketLauncher
    | MniGrenadeLauncher
    | ImpGrenadeLauncher
    | MissileLauncher
    | ConcussiveRpg
    | Yiuf0sDoublenader
    | HvyRocketLauncher
    | HvyMissileLauncher
    | GuiMissileLauncher
    | PrcGrenadeLauncher
    | RocketArray
    | LrnMissileLauncher
    | ImpConcussiveRpg
    | PrcRocketLauncher
    | ScatterRocketArray
    | SmartbombLauncher
    | MniSmartbombLauncher
    | TiamatMissileLauncher
    | Thermoblaster
    | MicronukeLauncher
    | AdvConcussiveRpg
    | NeutronMissileLauncher
    | FusionBombLauncher
    | HellfireMissileLauncher
    | AdvMicronukeLauncher
    | TacticalQuantumWarhead
    | VortexCatalystActivator
    | ChainMissileLauncher
    | RagnarokMissileLauncher
    | PointSingularityLauncher
    | GuiMicronukeLauncher
    | NinteyNineTntsNukerbomber
    | ZbombDeliverySystem
    | SigixTerminator
    | SuperchargedSigixTerminator
    | ContainmentFacilitator
    | Detonator
    | DirtyDatajack
    | SpliceInjector
    | Datajack
    | ImpDatajack
    | AdvDatajack
    | RemoteDatajack
    | ImpRemoteDatajack
    | AdvRemoteDatajack
    | ExpRemoteDatajack
    | GuiRemoteDatajack
    | MerlnsWand
    | FieldLobotomyKit
    | MiningLaser
    | WeldingTorch
    | PlasmaCutter
    | ImpPlasmaCutter
    | Flamer
    | AsbFtorch
    | EnhFlamer
    | PlasmaFlamer
    | AsbPtorch
    | Run14sThrowingClaymores
    | Run14sThrowingClaymoresV3
    | Ad0rfsMagmablaster
    | StasisBeam
    | StasisProjector
    | ExpStasisProjector
    | MolecularDeconstructor
    | Hammer
    | Mace
    | Flail
    | Maul
    | AsbMaul
    | HvyHammer
    | HvyMace
    | HvyFlail
    | GreatMaul
    | PoweredHammer
    | MakHammer
    | PowerMaul
    | AsbPmaul
    | ImpactMace
    | ShockMaul
    | ThunderHammer
    | Compactor
    | GravityFlail
    | ClanksMallet
    | CoreStripper
    | MiningClaw
    | Ec_1
    | Katana
    | AsbBlade
    | Scythe
    | Axe
    | BladeSaw
    | Ec_3
    | Chainsword
    | Ripper
    | MakAxe
    | MakSword
    | GreatAxe
    | Greatsword
    | PowerSword
    | AsbPsword
    | Falx
    | CarbideSaw
    | Segregator
    | Tearclaws
    | Ec_5
    | PhasingSabre
    | PlasmaSword
    | IonicAxe
    | MniTearclaws
    | DualbladeSaw
    | Vibroblade
    | MolecularScythe
    | CentriumGreatsword
    | MasterTearclaws
    | Longsword1
    | Ec_7
    | Nanosword
    | ParticleCleaver
    | CentriumClaws
    | IcutusSwordlootmaker
    | IcutusSwordchoppy
    | VortexShredder
    | Ec_9
    | SigixBroadsword
    | Spear
    | MakSpear
    | Cra16sPointyStick
    | HvyPick
    | Lance
    | KineticSpear
    | ForceLance
    | PlasmaLance
    | EnhForceLance
    | VortexLance
    | Cra16sBehemothSlayer
    | BladeTrap
    | SegregatorTrap
    | ExplosiveTrap
    | HeavyExplosiveTrap
    | TiamatBombTrap
    | FusionBombTrap
    | HellfireTrap
    | ArmageddonTrap
    | DirtyBombTrap
    | EmpTrap
    | ProtonBombTrap
    | TeslaBombTrap
    | GammaBombTrap
    | ShockTrap
    | EmSurgeTrap
    | FireTrap
    | StasisTrap
    | SignalGenerator
    | SelfdestructInterrupter
    | SapperCharge
    | Deployasentry
    | GalModule
    | PortableAfg
    | SgempPrototype
    | TerrabombDerivative
    | SigixContainmentPod
    | SigixCorpse
    | Meganuke
    | GammaRefractor

let itemId =
    function
    | 0 -> Matter
    | 1 -> DataCore
    | 2 -> DerelictLog
    | 3 -> SchematicArchive
    | 4 -> ImprinterDataCore
    | 5 -> A2DataCore
    | 6 -> A7DataCore
    | 7 -> MaincDataCore
    | 8 -> ArchitectDataCore
    | 9 -> Scrap
    | 10 -> Protomatter
    | 11 -> IonEngine
    | 12 -> LgtIonEngine
    | 13 -> BackupPowerI
    | 14 -> ImpIonEngine
    | 15 -> RnfIonEngine
    | 16 -> HvyIonEngine
    | 17 -> CldIonEngine
    | 18 -> DeuteriumEngine
    | 19 -> LgtDeuteriumEngine
    | 20 -> BackupPowerIii
    | 21 -> NuclearCore
    | 22 -> LgtNuclearCore
    | 23 -> ImpDeuteriumEngine
    | 24 -> RnfDeuteriumEngine
    | 25 -> HybDeuteriumEngine
    | 26 -> HvyDeuteriumEngine
    | 27 -> CldDeuteriumEngine
    | 28 -> EnhNuclearCore
    | 29 -> MicNuclearCore
    | 30 -> MakPowerSource
    | 31 -> AngularMomentumEngine
    | 32 -> LgtAngularMomentumEngine
    | 33 -> FcellEngine
    | 34 -> FissionCore
    | 35 -> LgtFissionCore
    | 36 -> HybFissionCore
    | 37 -> FusionCompressor
    | 38 -> ColdFusionReactor
    | 39 -> NeutrinoCore
    | 40 -> LgtNeutrinoCore
    | 41 -> RnfFissionCore
    | 42 -> EnhFissionCore
    | 43 -> CldFissionCore
    | 44 -> MicFissionCore
    | 45 -> FusionReactor
    | 46 -> AntimatterReactor
    | 47 -> LgtAntimatterReactor
    | 48 -> RnfAntimatterReactor
    | 49 -> HybAntimatterReactor
    | 50 -> BackupPowerVii
    | 51 -> HvyAntimatterReactor
    | 52 -> MniFusionReactor
    | 53 -> ImpFusionCompressor
    | 54 -> MicNeutrinoCore
    | 55 -> ZioLightDmReactor
    | 56 -> ZioHeavyDmReactor
    | 57 -> ParticleReactor
    | 58 -> LgtParticleReactor
    | 59 -> MicAntimatterReactor
    | 60 -> ComParticleReactor
    | 61 -> CldAntimatterReactor
    | 62 -> GravitonReactor
    | 63 -> AsbFluxGenerator
    | 64 -> QuantumReactor
    | 65 -> LgtQuantumReactor
    | 66 -> RnfQuantumReactor
    | 67 -> ImpQuantumReactor
    | 68 -> ZeropointReactor
    | 69 -> VortexChainReactor
    | 70 -> SingularityReactor
    | 71 -> MatterDrive
    | 72 -> LgtTreads
    | 73 -> ImpTreads
    | 74 -> SpkTreads
    | 75 -> ArmTreads
    | 76 -> AdvTreads
    | 77 -> MedTreads
    | 78 -> ImpMediumTreads
    | 79 -> SpkMediumTreads
    | 80 -> ArmMediumTreads
    | 81 -> HvyTreads
    | 82 -> AdvMediumTreads
    | 83 -> EnhArmoredMediumTreads
    | 84 -> ImpHeavyTreads
    | 85 -> HvySiegeTreads
    | 86 -> SpkHeavyTreads
    | 87 -> BiometalMediumTreads
    | 88 -> ArmHeavyTreads
    | 89 -> AdvHeavyTreads
    | 90 -> ImpHeavySiegeTreads
    | 91 -> CentriumHeavyTreads
    | 92 -> Megatreads
    | 93 -> BiometalHeavyTreads
    | 94 -> ExpBiometalHeavyTreads
    | 95 -> EnhArmoredHeavyTreads
    | 96 -> AdvHeavySiegeTreads
    | 97 -> HdnCentriumHeavyTreads
    | 98 -> ExpBiometalMediumTreads
    | 99 -> AluminumLeg
    | 100 -> ImpAluminumLeg
    | 101 -> CarbonfiberLeg
    | 102 -> TitaniumLeg
    | 103 -> VssLeg
    | 104 -> ImpCarbonfiberLeg
    | 105 -> ImpTitaniumLeg
    | 106 -> MakLeg
    | 107 -> FlexicarbonLeg
    | 108 -> ArmLeg
    | 109 -> ImpVssLeg
    | 110 -> ZioCompositeLegI
    | 111 -> EnhFlexicarbonLeg
    | 112 -> EnhArmoredLeg
    | 113 -> MyomerLeg
    | 114 -> AdvVssLeg
    | 115 -> AdvMyomerLeg
    | 116 -> ExpFlexicarbonLeg
    | 117 -> ZioCompositeLegIi
    | 118 -> EtherialTendrils
    | 119 -> BiometalLeg
    | 120 -> EnhBiometalLeg
    | 121 -> ExpMyomerLeg
    | 122 -> TrollExoskeleton
    | 123 -> AsbAlloyLeg
    | 124 -> CentriumLeg
    | 125 -> HdnCentriumLeg
    | 126 -> ExpBiometalLeg
    | 127 -> SigixExoskeleton
    | 128 -> ZioSupercompositeLeg
    | 129 -> PotentialLeg
    | 130 -> MyomerExoskeleton
    | 131 -> Wheel
    | 132 -> ComWheel
    | 133 -> ArmWheel
    | 134 -> ArmHugeWheel
    | 135 -> CentriumWheel
    | 136 -> HdnCentriumWheel
    | 137 -> HoverUnit
    | 138 -> BackupPropulsionI
    | 139 -> ImpHoverUnit
    | 140 -> Airjet
    | 141 -> AerolevUnit
    | 142 -> AsbHoverUnit
    | 143 -> BackupPropulsionIii
    | 144 -> GravmagSystem
    | 145 -> AsbHoverSystem
    | 146 -> ImpAirjet
    | 147 -> CldAirjet
    | 148 -> ImpGravmagSystem
    | 149 -> CldAerolevUnit
    | 150 -> CmbAirjet
    | 151 -> GravmagArray
    | 152 -> MakHoverUnit
    | 153 -> ZioGlidesysI
    | 154 -> AntigravSystem
    | 155 -> GyrokineticInverter
    | 156 -> LinearGravjet
    | 157 -> CldGravmagSystem
    | 158 -> CmbGravmagSystem
    | 159 -> ImpAntigravSystem
    | 160 -> ImpGyrokineticInverter
    | 161 -> ImpLinearGravjet
    | 162 -> BackupPropulsionVii
    | 163 -> ZioGlidesysIi
    | 164 -> CldAntigravSystem
    | 165 -> CmbAntigravSystem
    | 166 -> AntigravArray
    | 167 -> ExpGyrokineticInverter
    | 168 -> CldLinearGravjet
    | 169 -> CmbLinearGravjet
    | 170 -> FlightUnit
    | 171 -> VtolModule
    | 172 -> ImpFlightUnit
    | 173 -> CesiumionThruster
    | 174 -> SurgeThruster
    | 175 -> ImpVtolModule
    | 176 -> XenonBombardmentThruster
    | 177 -> ImpCesiumionThruster
    | 178 -> CldVtolModule
    | 179 -> MakFlightUnit
    | 180 -> NuclearPulseThruster
    | 181 -> ImpSurgeThruster
    | 182 -> MniNuclearPulseThruster
    | 183 -> CldCesiumionThruster
    | 184 -> BiomechanicalWings
    | 185 -> FieldPropulsionDrive
    | 186 -> CldNuclearPulseThruster
    | 187 -> ExpCesiumionThruster
    | 188 -> NuclearPulseArray
    | 189 -> MakMicrothruster
    | 190 -> ImpulseThruster
    | 191 -> AdvSurgeThruster
    | 192 -> CldFieldPropulsionDrive
    | 193 -> FieldPropulsionArray
    | 194 -> DiametricDrive
    | 195 -> FlyingFortressV7
    | 196 -> Tthruster
    | 197 -> IntegratedTrackerDrive
    | 198 -> EtherialPropulsion
    | 199 -> Qthruster
    | 200 -> ElectronDiverter
    | 201 -> ImpDiametricDrive
    | 202 -> CldImpulseThruster
    | 203 -> ImpulseThrusterArray
    | 204 -> ImpQthruster
    | 205 -> CldQthruster
    | 206 -> ExpQthruster
    | 207 -> Desublimator
    | 208 -> PowerAmplifier
    | 209 -> AdvPowerAmplifier
    | 210 -> ExpPowerAmplifier
    | 211 -> ThermalGenerator
    | 212 -> ImpThermalGenerator
    | 213 -> AdvThermalGenerator
    | 214 -> ExpThermalGenerator
    | 215 -> CryofiberWeb
    | 216 -> ImpCryofiberWeb
    | 217 -> AdvCryofiberWeb
    | 218 -> HeatSink
    | 219 -> ImpHeatSink
    | 220 -> AdvHeatSink
    | 221 -> ExpHeatSink
    | 222 -> CoolingSystem
    | 223 -> ImpCoolingSystem
    | 224 -> AdvCoolingSystem
    | 225 -> ExpCoolingSystem
    | 226 -> CoolantNetwork
    | 227 -> AsbNanovents
    | 228 -> FrostArray
    | 229 -> DisposableHeatSink
    | 230 -> CoolantInjector
    | 231 -> ImpCoolantInjector
    | 232 -> AdvCoolantInjector
    | 233 -> ExpCoolantInjector
    | 234 -> SmlStorageUnit
    | 235 -> MedStorageUnit
    | 236 -> LrgStorageUnit
    | 237 -> HcpStorageUnit
    | 238 -> HugeStorageUnit
    | 239 -> CargoStorageUnit
    | 240 -> Humpback
    | 241 -> Lightpack20
    | 242 -> SmlBattery
    | 243 -> MedBattery
    | 244 -> LrgBattery
    | 245 -> HcpBattery
    | 246 -> ComBattery
    | 247 -> EnergyWell
    | 248 -> ImpEnergyWell
    | 249 -> AdvEnergyWell
    | 250 -> ExpEnergyWell
    | 251 -> ZioBiocell
    | 252 -> AsbBiocellArray
    | 253 -> ZioBiocellArray
    | 254 -> Superbattery
    | 255 -> SmlMatterPod
    | 256 -> MedMatterPod
    | 257 -> LrgMatterPod
    | 258 -> HcpMatterPod
    | 259 -> ComMatterPod
    | 260 -> MatterCompressor
    | 261 -> ImpMatterCompressor
    | 262 -> AdvMatterCompressor
    | 263 -> ExpMatterCompressor
    | 264 -> Yiuf0sBottomlessMatterPit
    | 265 -> WeightRedistSystem
    | 266 -> AdvWeightRedistSystem
    | 267 -> GravityNeutralizer
    | 268 -> AdvGravityNeutralizer
    | 269 -> QuantumShadingMachine
    | 270 -> AsbSuspensionFrame
    | 271 -> AdvQuantumShadingMachine
    | 272 -> AsbMetafiberNetwork
    | 273 -> ZioMetafieldGenerator
    | 274 -> StFieldCompressor
    | 275 -> StructuralScanner
    | 276 -> TrapScanner
    | 277 -> ImpTrapScanner
    | 278 -> MakTrapScanner
    | 279 -> AdvTrapScanner
    | 280 -> MachineAnalyzer
    | 281 -> Triangulator
    | 282 -> VisualProcessingUnit
    | 283 -> AdvVisualProcessingUnit
    | 284 -> EnhOpticalArray
    | 285 -> ExpOpticalArray
    | 286 -> SpectralAnalyzer
    | 287 -> SensorArray
    | 288 -> ImpSensorArray
    | 289 -> AdvSensorArray
    | 290 -> LrnSensorArray
    | 291 -> MakSensorArray
    | 292 -> ExpSensorArray
    | 293 -> SignalInterpreter
    | 294 -> ImpSignalInterpreter
    | 295 -> AdvSignalInterpreter
    | 296 -> ExpSignalInterpreter
    | 297 -> ActiveSensorSuite
    | 298 -> TerrainScanner
    | 299 -> ImpTerrainScanner
    | 300 -> AdvTerrainScanner
    | 301 -> MakTerrainScanner
    | 302 -> LrnTerrainScanner
    | 303 -> ExpTerrainScanner
    | 304 -> Surveybot24Scanner
    | 305 -> TerrainScanProcessor
    | 306 -> ImpTerrainScanProcessor
    | 307 -> MakTerrainScanProcessor
    | 308 -> AdvTerrainScanProcessor
    | 309 -> ExpTerrainScanProcessor
    | 310 -> Surveybot24Chip
    | 311 -> SeismicDetector
    | 312 -> TransportNetworkCoupler
    | 313 -> ModifiedTnc
    | 314 -> B10DecoderChipgeneric
    | 315 -> B10DecoderChiplooter
    | 316 -> B10DecoderChipscout
    | 317 -> B10DecoderChipskirmisher
    | 318 -> B10AlertChip
    | 319 -> SalvageTargetingComputer
    | 320 -> ImpSalvageTargetingComputer
    | 321 -> MakSalvageTargetingComputer
    | 322 -> AdvSalvageTargetingComputer
    | 323 -> AsbCombatSuite
    | 324 -> TargetingComputer
    | 325 -> ImpTargetingComputer
    | 326 -> AdvTargetingComputer
    | 327 -> ExpTargetingComputer
    | 328 -> TacticalCoordinationSuite
    | 329 -> MeleeAnalysisSuite
    | 330 -> ImpMeleeAnalysisSuite
    | 331 -> AdvMeleeAnalysisSuite
    | 332 -> ExpMeleeAnalysisSuite
    | 333 -> LauncherGuidanceComputer
    | 334 -> ImpLauncherGuidanceComputer
    | 335 -> AdvLauncherGuidanceComputer
    | 336 -> TargetAnalyzer
    | 337 -> ImpTargetAnalyzer
    | 338 -> AdvTargetAnalyzer
    | 339 -> ExpTargetAnalyzer
    | 340 -> CoreAnalyzer
    | 341 -> ExpCoreAnalyzer
    | 342 -> ArmorIntegrityAnalyzer
    | 343 -> ImpArmorIntegrityAnalyzer
    | 344 -> ExpArmorIntegrityAnalyzer
    | 345 -> RecoilStabilizer
    | 346 -> RecoilNullifier
    | 347 -> MatterFilter
    | 348 -> PrcMatterFilter
    | 349 -> EnergyFilter
    | 350 -> PrcEnergyFilter
    | 351 -> ParticleCharger
    | 352 -> ImpParticleCharger
    | 353 -> AdvParticleCharger
    | 354 -> ParticleAccelerator
    | 355 -> ImpParticleAccelerator
    | 356 -> AdvParticleAccelerator
    | 357 -> Kinecellerator
    | 358 -> ImpKinecellerator
    | 359 -> AdvKinecellerator
    | 360 -> LauncherLoader
    | 361 -> QuantumCapacitor
    | 362 -> WeaponCycler
    | 363 -> ImpWeaponCycler
    | 364 -> AdvWeaponCycler
    | 365 -> ExpWeaponCycler
    | 366 -> Microactuators
    | 367 -> Nanoactuators
    | 368 -> Femtoactuators
    | 369 -> ActuatorArray
    | 370 -> ImpActuatorArray
    | 371 -> AdvActuatorArray
    | 372 -> ExpActuatorArray
    | 373 -> ForceBooster
    | 374 -> ImpForceBooster
    | 375 -> AdvForceBooster
    | 376 -> StasisCanceller
    | 377 -> TransmissionJammer
    | 378 -> MakTransmissionJammer
    | 379 -> ImpTransmissionJammer
    | 380 -> AdvTransmissionJammer
    | 381 -> ExpTransmissionJammer
    | 382 -> EcmSuite
    | 383 -> MakEcmSuite
    | 384 -> AdvEcmSuite
    | 385 -> ExpEcmSuite
    | 386 -> ReactionControlSystem
    | 387 -> ImpReactionControlSystem
    | 388 -> AdvReactionControlSystem
    | 389 -> ExpReactionControlSystem
    | 390 -> PhaseShifter
    | 391 -> ImpPhaseShifter
    | 392 -> AdvPhaseShifter
    | 393 -> ExpPhaseShifter
    | 394 -> CloakingDevice
    | 395 -> MakCloakingDevice
    | 396 -> ImpCloakingDevice
    | 397 -> AdvCloakingDevice
    | 398 -> ExpCloakingDevice
    | 399 -> CloakOfProtection
    | 400 -> Shad0sCloak
    | 401 -> CoreShielding
    | 402 -> ImpCoreShielding
    | 403 -> ExpCoreShielding
    | 404 -> PowerShielding
    | 405 -> ImpPowerShielding
    | 406 -> ExpPowerShielding
    | 407 -> PropulsionShielding
    | 408 -> ImpPropulsionShielding
    | 409 -> ExpPropulsionShielding
    | 410 -> UtilityShielding
    | 411 -> ImpUtilityShielding
    | 412 -> ExpUtilityShielding
    | 413 -> WeaponShielding
    | 414 -> ImpWeaponShielding
    | 415 -> ExpWeaponShielding
    | 416 -> ZioWeaponCasing
    | 417 -> LgtArmorPlating
    | 418 -> MedArmorPlating
    | 419 -> HvyArmorPlating
    | 420 -> ZioLightCarapace
    | 421 -> ZioHeavyCarapace
    | 422 -> HrdLightArmorPlating
    | 423 -> HrdMediumArmorPlating
    | 424 -> HrdHeavyArmorPlating
    | 425 -> ImpLightArmorPlating
    | 426 -> ImpMediumArmorPlating
    | 427 -> ImpHeavyArmorPlating
    | 428 -> LyrLightArmorPlating
    | 429 -> MakArmorPlating
    | 430 -> LyrMediumArmorPlating
    | 431 -> LyrHeavyArmorPlating
    | 432 -> CentriumLightArmorPlating
    | 433 -> CentriumMediumArmorPlating
    | 434 -> CentriumHeavyArmorPlating
    | 435 -> CentriumLinkedPlating
    | 436 -> ReactivePlating
    | 437 -> MedReactivePlating
    | 438 -> MakKineticPlating
    | 439 -> HvyReactivePlating
    | 440 -> ReflectivePlating
    | 441 -> MedReflectivePlating
    | 442 -> MakThermalPlating
    | 443 -> HvyReflectivePlating
    | 444 -> BrawnsArmorth
    | 445 -> BrawnsArmorex
    | 446 -> InsulatedPlating
    | 447 -> MedInsulatedPlating
    | 448 -> HvyInsulatedPlating
    | 449 -> DamperPlating
    | 450 -> ZioShadeCarapace
    | 451 -> ZioShadeArmor
    | 452 -> AsbAlloyArmor
    | 453 -> MakAblativeArmor
    | 454 -> ActiveCoolingArmor
    | 455 -> PoweredArmor
    | 456 -> ImpPoweredArmor
    | 457 -> AdvPoweredArmor
    | 458 -> ExpPoweredArmor
    | 459 -> IcutusBuckler
    | 460 -> LgtRegenerativePlating
    | 461 -> MedRegenerativePlating
    | 462 -> HvyRegenerativePlating
    | 463 -> ShellArmor
    | 464 -> PhaseArmor
    | 465 -> GrapheneBrace
    | 466 -> FocalShield
    | 467 -> ImpFocalShield
    | 468 -> AdvFocalShield
    | 469 -> ExpFocalShield
    | 470 -> ThermalShield
    | 471 -> ImpThermalShield
    | 472 -> AdvThermalShield
    | 473 -> ExpThermalShield
    | 474 -> ThermalBarrier
    | 475 -> BeamSplitter
    | 476 -> ThermalDefenseSuite
    | 477 -> ImpThermalDefenseSuite
    | 478 -> AdvThermalDefenseSuite
    | 479 -> ExpThermalDefenseSuite
    | 480 -> ShockAbsorptionSystem
    | 481 -> ImpShockAbsorptionSystem
    | 482 -> ExpShockAbsorptionSystem
    | 483 -> EmDisruptionField
    | 484 -> AdvEmDisruptionField
    | 485 -> ExpEmDisruptionField
    | 486 -> MerlnsChromaticScreen
    | 487 -> HardlightGenerator
    | 488 -> ImpHardlightGenerator
    | 489 -> AdvHardlightGenerator
    | 490 -> ExpHardlightGenerator
    | 491 -> ShieldGenerator
    | 492 -> ImpShieldGenerator
    | 493 -> AdvShieldGenerator
    | 494 -> ExpShieldGenerator
    | 495 -> ForceField
    | 496 -> ImpForceField
    | 497 -> AdvForceField
    | 498 -> ExpForceField
    | 499 -> TvrtlsUltimateField
    | 500 -> VortexFieldProjector
    | 501 -> RemoteShield
    | 502 -> ImpRemoteShield
    | 503 -> AdvRemoteShield
    | 504 -> RemoteForceField
    | 505 -> ImpRemoteForceField
    | 506 -> EnergyMantle
    | 507 -> ImpEnergyMantle
    | 508 -> AegisRemoteShield
    | 509 -> PhaseRedirector
    | 510 -> PointDefenseSystem
    | 511 -> PointDefenseArray
    | 512 -> AntimissileSystem
    | 513 -> ExChip1
    | 514 -> HackingSuite
    | 515 -> MakHackingSuite
    | 516 -> ImpHackingSuite
    | 517 -> AdvHackingSuite
    | 518 -> ExpHackingSuite
    | 519 -> SystemMapper
    | 520 -> DeepNetworkScanner
    | 521 -> ArchitectGodChipA
    | 522 -> ExChip2
    | 523 -> SystemShield
    | 524 -> MakSystemShield
    | 525 -> ImpSystemShield
    | 526 -> AdvSystemShield
    | 527 -> ExpSystemShield
    | 528 -> GhostBarrier
    | 529 -> QuantumRouter
    | 530 -> ArchitectGodChipD
    | 531 -> Authchiprnc
    | 532 -> Authchiprcombat
    | 533 -> Authchippower
    | 534 -> Authchippropulsion
    | 535 -> Authchipdevice
    | 536 -> Authchipstorage
    | 537 -> Authchipprocessor
    | 538 -> Authchiparmor
    | 539 -> Authchipweapon
    | 540 -> RelayCouplernc
    | 541 -> RelayCouplerc
    | 542 -> RelayCouplerarc
    | 543 -> RelayCouplerswarmer
    | 544 -> RelayCouplercutter
    | 545 -> RelayCouplergrunt
    | 546 -> RelayCouplerbrawler
    | 547 -> RelayCouplerduelist
    | 548 -> RelayCouplersentry
    | 549 -> RelayCouplerdemolisher
    | 550 -> RelayCouplerspecialist
    | 551 -> RelayCouplerhunter
    | 552 -> RelayCouplerheavy
    | 553 -> RelayCouplerbehemoth
    | 554 -> RelayCouplerprogrammer
    | 555 -> SkeletonBox
    | 556 -> O1mtfsAutohacker
    | 557 -> ComponentAnalysisSuite
    | 558 -> ImpComponentAnalysisSuite
    | 559 -> AdvComponentAnalysisSuite
    | 560 -> DynamicInsulationSystem
    | 561 -> ImpDynamicInsulationSystem
    | 562 -> AdvDynamicInsulationSystem
    | 563 -> SystemGuard
    | 564 -> ImpSystemGuard
    | 565 -> ExpSystemGuard
    | 566 -> CorruptionScreen
    | 567 -> ImpCorruptionScreen
    | 568 -> AdvCorruptionScreen
    | 569 -> SystemRestorationModule
    | 570 -> MakSystemRestorationModule
    | 571 -> ImpSystemRestorationModule
    | 572 -> AdvSystemRestorationModule
    | 573 -> SystemPurifier
    | 574 -> ExpSystemPurifier
    | 575 -> TractorBeam
    | 576 -> HpwTractorBeam
    | 577 -> LrnTractorBeam
    | 578 -> MobileRefineryMkCclxvii
    | 579 -> TrapExtractor
    | 580 -> ImpTrapExtractor
    | 581 -> AdvTrapExtractor
    | 582 -> TrapReconfigurator
    | 583 -> Recalibrator
    | 584 -> ImpRecalibrator
    | 585 -> AdvRecalibrator
    | 586 -> FieldRecyclingUnit
    | 587 -> ImpFieldRecyclingUnit
    | 588 -> AdvFieldRecyclingUnit
    | 589 -> ExpFieldRecyclingUnit
    | 590 -> DroneBay
    | 591 -> ZdroneBay
    | 592 -> MniDroneBay
    | 593 -> MappingDroneBay
    | 594 -> AdvDroneBay
    | 595 -> BombDroneBay
    | 596 -> ThiefDroneBay
    | 597 -> DecoyDroneBay
    | 598 -> SpliceDroneBay
    | 599 -> CombatDroneBay
    | 600 -> AssaultDroneBay
    | 601 -> StealthDroneBay
    | 602 -> SwarmDroneBay
    | 603 -> SupersonicDroneBay
    | 604 -> SensorDroneBay
    | 605 -> HackingDroneBay
    | 606 -> MinesnifferDroneBay
    | 607 -> Armyinabox
    | 608 -> WardroneBay
    | 609 -> BombFactoryNo2
    | 610 -> MobileAssemblyUnit
    | 611 -> HeartOfSteel
    | 612 -> GolemUnit
    | 613 -> PsuRigger
    | 614 -> PhasingAfg
    | 615 -> AsneutralizerNo17b
    | 616 -> Chronowheel
    | 617 -> DimensionalNodeInitializer
    | 618 -> TransdimensionalReconstructor
    | 619 -> HpwTransdimensionalReconstructor
    | 620 -> CoreExpander
    | 621 -> CoreRegenerator
    | 622 -> IntegrityRedistributor
    | 623 -> IntegratedDissipator
    | 624 -> SuperchargedIntegratedDissipator
    | 625 -> IntegratedThermoelectricNetwork
    | 626 -> IntegratedReactor
    | 627 -> SuperchargedIntegratedReactor
    | 628 -> IntegratedMediator
    | 629 -> CoreMembrane
    | 630 -> NavigationEfficiencyMatrix
    | 631 -> CoreResetMatrix
    | 632 -> SubatomicReplicator
    | 633 -> Terrabomb
    | 634 -> CorePhysicsCalibrator
    | 635 -> SpacefoldActivator
    | 636 -> MicrowarpDrive
    | 637 -> LcCapacitor
    | 638 -> LrcArmor
    | 639 -> LrcStorage
    | 640 -> LrcEnergyWell
    | 641 -> LrcMatterCompressor
    | 642 -> LrcBoosters
    | 643 -> LrcInsulator
    | 644 -> EmPulseGun
    | 645 -> HvyEmPulseGun
    | 646 -> EmShotgun
    | 647 -> ImpEmShotgun
    | 648 -> ShockRifle
    | 649 -> RiotGun
    | 650 -> HvyEmShotgun
    | 651 -> LightningGun
    | 652 -> HvyRiotGun
    | 653 -> ArcProjector
    | 654 -> PrcShockRifle
    | 655 -> HpwShockRifle
    | 656 -> ArcThrower
    | 657 -> ImpLightningGun
    | 658 -> TeslaRifle
    | 659 -> ImpArcProjector
    | 660 -> HvyTeslaRifle
    | 661 -> HypEmGaussRifle
    | 662 -> ImpArcThrower
    | 663 -> O1mtfsShockpuncher
    | 664 -> GammaRifle
    | 665 -> TachyonDispersionRay
    | 666 -> Immobilizer
    | 667 -> ModifiedEmGaussRifle
    | 668 -> Awsexdec
    | 669 -> EnhGammaRifle
    | 670 -> MedLaser
    | 671 -> SmlLaser
    | 672 -> BackupLaserI
    | 673 -> BeamRifle
    | 674 -> ParticleGun
    | 675 -> SpreadLaser
    | 676 -> ImpMediumLaser
    | 677 -> FieldLaser
    | 678 -> PulseRifle
    | 679 -> BackupLaserIii
    | 680 -> HvyParticleGun
    | 681 -> PrcBeamRifle
    | 682 -> AdvBeamRifle
    | 683 -> HvyLaser
    | 684 -> GatlingLaser
    | 685 -> CldPulseRifle
    | 686 -> HpwFieldLaser
    | 687 -> ImpSpreadLaser
    | 688 -> MakLaser
    | 689 -> PlasmaRifle
    | 690 -> ThermicLaser
    | 691 -> Beamcaster
    | 692 -> ForceRifle
    | 693 -> ImpHeavyLaser
    | 694 -> StormLaser
    | 695 -> ZioLasers
    | 696 -> WaveGun
    | 697 -> VariableChargeGun
    | 698 -> HvyBeamcaster
    | 699 -> CldPlasmaRifle
    | 700 -> EnhForceRifle
    | 701 -> HvyGatlingLaser
    | 702 -> ZioPhasers
    | 703 -> PhaseGun
    | 704 -> DispersionRifle
    | 705 -> BackupLaserVii
    | 706 -> PlasmaStorm
    | 707 -> AdvPlasmaRifle
    | 708 -> HvyWaveGun
    | 709 -> AdvVariableChargeGun
    | 710 -> CldPhaseGun
    | 711 -> LrnGatlingLaser
    | 712 -> WarpGun
    | 713 -> VortexRifle
    | 714 -> ZioLaserm
    | 715 -> Awsthermal
    | 716 -> PdLaser
    | 717 -> QuantumRifle
    | 718 -> PrcPhaseGun
    | 719 -> HvyDispersionRifle
    | 720 -> VortexShotgun
    | 721 -> VortexRail
    | 722 -> ZioPhaserm
    | 723 -> EnhQuantumRifle
    | 724 -> ZioLaserh
    | 725 -> HvyQuantumRifle
    | 726 -> ZioPhaserh
    | 727 -> GatlingBeam
    | 728 -> SigixSheargun
    | 729 -> ModifiedSigixSheargun
    | 730 -> LgtEmPulseCannon
    | 731 -> EmPulseCannon
    | 732 -> ImpEmPulseCannon
    | 733 -> ProtonCannon
    | 734 -> LrnProtonCannon
    | 735 -> DisruptorCannon
    | 736 -> HvyProtonCannon
    | 737 -> HerfCannon
    | 738 -> HvyDisruptorCannon
    | 739 -> CldProtonCannon
    | 740 -> ProtonBurstCannon
    | 741 -> ComHerfCannon
    | 742 -> LatentEnergyStreamer
    | 743 -> Nk0lasTeslaDoomcannon
    | 744 -> Emds
    | 745 -> HpwDisruptorCannon
    | 746 -> BeamCannon
    | 747 -> ParticleCannon
    | 748 -> AdvBeamCannon
    | 749 -> HvyParticleCannon
    | 750 -> IonCannon
    | 751 -> PlasmaCannon
    | 752 -> HvyIonCannon
    | 753 -> CldParticleCannon
    | 754 -> PhaseCannon
    | 755 -> HvyPlasmaCannon
    | 756 -> CldPlasmaCannon
    | 757 -> ComIonCannon
    | 758 -> IonBurstCannon
    | 759 -> AdvPlasmaCannon
    | 760 -> HvyPhaseCannon
    | 761 -> NeutronCannon
    | 762 -> MatterNeutralizer
    | 763 -> HvyNeutronCannon
    | 764 -> LrnPhaseCannon
    | 765 -> CldPhaseCannon
    | 766 -> VortexCannon
    | 767 -> GuiPlasmaCannon
    | 768 -> NovaCannon
    | 769 -> ImpMatterNeutralizer
    | 770 -> VortexDriver
    | 771 -> ZioAlphaCannon
    | 772 -> AsbFocalCannon
    | 773 -> EnhNovaCannon
    | 774 -> Firepult
    | 775 -> YoloCannon
    | 776 -> PotentialCannon
    | 777 -> WarpCannon
    | 778 -> CldNovaCannon
    | 779 -> NullCannon
    | 780 -> ImpPotentialCannon
    | 781 -> Disintegrator
    | 782 -> CoreCannon
    | 783 -> SigixShearcannon
    | 784 -> DrainedLcannon
    | 785 -> Lcannon
    | 786 -> ZioAlphaCannonMkIi
    | 787 -> Bfg9kVortexEdition
    | 788 -> AssaultRifle
    | 789 -> AsbRifle
    | 790 -> LgtAssaultRifle
    | 791 -> HvyAssaultRifle
    | 792 -> Autogun
    | 793 -> Shotgun
    | 794 -> BattleRifle
    | 795 -> AsbHeavyRifle
    | 796 -> ImpAssaultRifle
    | 797 -> Minigun
    | 798 -> HpwShotgun
    | 799 -> AsbShotgun
    | 800 -> BarrageGun
    | 801 -> EnhAutogun
    | 802 -> GaussRifle
    | 803 -> AsbGaussRifle
    | 804 -> FlakGun
    | 805 -> PrcAssaultRifle
    | 806 -> HvyBattleRifle
    | 807 -> MakShrapnelGun
    | 808 -> CoilGun
    | 809 -> HypGaussRifle
    | 810 -> HvyMachineGun
    | 811 -> ImpHeavyMachineGun
    | 812 -> ComGaussRifle
    | 813 -> XlAutogunSubcomponent
    | 814 -> KePenetrator
    | 815 -> HypCoilGun
    | 816 -> ImpKePenetrator
    | 817 -> EnhCoilGun
    | 818 -> ComCoilGun
    | 819 -> Railgun
    | 820 -> AdvKePenetrator
    | 821 -> LinkedAutogun
    | 822 -> Awsgauss
    | 823 -> HypRailgun
    | 824 -> HelicalRailgun
    | 825 -> ComRailgun
    | 826 -> XlAutogunArray
    | 827 -> AshsBoomstick
    | 828 -> BrawnsBoregun
    | 829 -> Multirail
    | 830 -> HypMultirail
    | 831 -> Shad0sSniperRifle
    | 832 -> A3sSniperRifle
    | 833 -> LgtCannon
    | 834 -> ImpLightCannon
    | 835 -> BattleCannon
    | 836 -> AssaultCannon
    | 837 -> HvyAssaultCannon
    | 838 -> FlakCannon
    | 839 -> AdvAssaultCannon
    | 840 -> GaussCannon
    | 841 -> SlugCannon
    | 842 -> MniAssaultCannon
    | 843 -> MagneticAccelerationCannon
    | 844 -> HvyFlakCannon
    | 845 -> BoreCannon
    | 846 -> AntimatterCannon
    | 847 -> MassDriver
    | 848 -> HvyMassDriver
    | 849 -> EnhGaussCannon
    | 850 -> HypGaussCannon
    | 851 -> TrirailAccelerator
    | 852 -> HardcellCannon
    | 853 -> HvyGaussCannon
    | 854 -> HypMassDriver
    | 855 -> HvyAutocannon
    | 856 -> DasCannon
    | 857 -> LgtAntimatterCannon
    | 858 -> LinearAccelerator
    | 859 -> HvyLinearAccelerator
    | 860 -> ComMassDriver
    | 861 -> HvyHardcellCannon
    | 862 -> ComLinearAccelerator
    | 863 -> HypLinearAccelerator
    | 864 -> HclLinearAccelerator
    | 865 -> GravitonCannon
    | 866 -> BlastCannon
    | 867 -> P13cesGatlingFlakker
    | 868 -> Awsautocannon
    | 869 -> Perforator
    | 870 -> OmegaCannon
    | 871 -> EmpBlaster
    | 872 -> ShockBombLauncher
    | 873 -> AdvEmpBlaster
    | 874 -> ProtonMissileLauncher
    | 875 -> ImpProtonMissileLauncher
    | 876 -> GuiEmpBlaster
    | 877 -> HvyShockBombLauncher
    | 878 -> TeslaBombLauncher
    | 879 -> HvyProtonMissileLauncher
    | 880 -> ComTeslaBombLauncher
    | 881 -> GammaBombArray
    | 882 -> EnhGammaBombArray
    | 883 -> GrenadeLauncher
    | 884 -> RocketLauncher
    | 885 -> MniGrenadeLauncher
    | 886 -> ImpGrenadeLauncher
    | 887 -> MissileLauncher
    | 888 -> ConcussiveRpg
    | 889 -> Yiuf0sDoublenader
    | 890 -> HvyRocketLauncher
    | 891 -> HvyMissileLauncher
    | 892 -> GuiMissileLauncher
    | 893 -> PrcGrenadeLauncher
    | 894 -> RocketArray
    | 895 -> LrnMissileLauncher
    | 896 -> ImpConcussiveRpg
    | 897 -> PrcRocketLauncher
    | 898 -> ScatterRocketArray
    | 899 -> SmartbombLauncher
    | 900 -> MniSmartbombLauncher
    | 901 -> TiamatMissileLauncher
    | 902 -> Thermoblaster
    | 903 -> MicronukeLauncher
    | 904 -> AdvConcussiveRpg
    | 905 -> NeutronMissileLauncher
    | 906 -> FusionBombLauncher
    | 907 -> HellfireMissileLauncher
    | 908 -> AdvMicronukeLauncher
    | 909 -> TacticalQuantumWarhead
    | 910 -> VortexCatalystActivator
    | 911 -> ChainMissileLauncher
    | 912 -> RagnarokMissileLauncher
    | 913 -> PointSingularityLauncher
    | 914 -> GuiMicronukeLauncher
    | 915 -> NinteyNineTntsNukerbomber
    | 916 -> ZbombDeliverySystem
    | 917 -> SigixTerminator
    | 918 -> SuperchargedSigixTerminator
    | 919 -> ContainmentFacilitator
    | 920 -> Detonator
    | 921 -> DirtyDatajack
    | 922 -> SpliceInjector
    | 923 -> Datajack
    | 924 -> ImpDatajack
    | 925 -> AdvDatajack
    | 926 -> RemoteDatajack
    | 927 -> ImpRemoteDatajack
    | 928 -> AdvRemoteDatajack
    | 929 -> ExpRemoteDatajack
    | 930 -> GuiRemoteDatajack
    | 931 -> MerlnsWand
    | 932 -> FieldLobotomyKit
    | 933 -> MiningLaser
    | 934 -> WeldingTorch
    | 935 -> PlasmaCutter
    | 936 -> ImpPlasmaCutter
    | 937 -> Flamer
    | 938 -> AsbFtorch
    | 939 -> EnhFlamer
    | 940 -> PlasmaFlamer
    | 941 -> AsbPtorch
    | 942 -> Run14sThrowingClaymores
    | 943 -> Run14sThrowingClaymoresV3
    | 944 -> Ad0rfsMagmablaster
    | 945 -> StasisBeam
    | 946 -> StasisProjector
    | 947 -> ExpStasisProjector
    | 948 -> MolecularDeconstructor
    | 949 -> Hammer
    | 950 -> Mace
    | 951 -> Flail
    | 952 -> Maul
    | 953 -> AsbMaul
    | 954 -> HvyHammer
    | 955 -> HvyMace
    | 956 -> HvyFlail
    | 957 -> GreatMaul
    | 958 -> PoweredHammer
    | 959 -> MakHammer
    | 960 -> PowerMaul
    | 961 -> AsbPmaul
    | 962 -> ImpactMace
    | 963 -> ShockMaul
    | 964 -> ThunderHammer
    | 965 -> Compactor
    | 966 -> GravityFlail
    | 967 -> ClanksMallet
    | 968 -> CoreStripper
    | 969 -> MiningClaw
    | 970 -> Ec_1
    | 971 -> Katana
    | 972 -> AsbBlade
    | 973 -> Scythe
    | 974 -> Axe
    | 975 -> BladeSaw
    | 976 -> Ec_3
    | 977 -> Chainsword
    | 978 -> Ripper
    | 979 -> MakAxe
    | 980 -> MakSword
    | 981 -> GreatAxe
    | 982 -> Greatsword
    | 983 -> PowerSword
    | 984 -> AsbPsword
    | 985 -> Falx
    | 986 -> CarbideSaw
    | 987 -> Segregator
    | 988 -> Tearclaws
    | 989 -> Ec_5
    | 990 -> PhasingSabre
    | 991 -> PlasmaSword
    | 992 -> IonicAxe
    | 993 -> MniTearclaws
    | 994 -> DualbladeSaw
    | 995 -> Vibroblade
    | 996 -> MolecularScythe
    | 997 -> CentriumGreatsword
    | 998 -> MasterTearclaws
    | 999 -> Longsword1
    | 1000 -> Ec_7
    | 1001 -> Nanosword
    | 1002 -> ParticleCleaver
    | 1003 -> CentriumClaws
    | 1004 -> IcutusSwordlootmaker
    | 1005 -> IcutusSwordchoppy
    | 1006 -> VortexShredder
    | 1007 -> Ec_9
    | 1008 -> SigixBroadsword
    | 1009 -> Spear
    | 1010 -> MakSpear
    | 1011 -> Cra16sPointyStick
    | 1012 -> HvyPick
    | 1013 -> Lance
    | 1014 -> KineticSpear
    | 1015 -> ForceLance
    | 1016 -> PlasmaLance
    | 1017 -> EnhForceLance
    | 1018 -> VortexLance
    | 1019 -> Cra16sBehemothSlayer
    | 1020 -> BladeTrap
    | 1021 -> SegregatorTrap
    | 1022 -> ExplosiveTrap
    | 1023 -> HeavyExplosiveTrap
    | 1024 -> TiamatBombTrap
    | 1025 -> FusionBombTrap
    | 1026 -> HellfireTrap
    | 1027 -> ArmageddonTrap
    | 1028 -> DirtyBombTrap
    | 1029 -> EmpTrap
    | 1030 -> ProtonBombTrap
    | 1031 -> TeslaBombTrap
    | 1032 -> GammaBombTrap
    | 1033 -> ShockTrap
    | 1034 -> EmSurgeTrap
    | 1035 -> FireTrap
    | 1036 -> StasisTrap
    | 1037 -> SignalGenerator
    | 1038 -> SelfdestructInterrupter
    | 1039 -> SapperCharge
    | 1040 -> Deployasentry
    | 1041 -> GalModule
    | 1042 -> PortableAfg
    | 1043 -> SgempPrototype
    | 1044 -> TerrabombDerivative
    | 1045 -> SigixContainmentPod
    | 1046 -> SigixCorpse
    | 1047 -> Meganuke
    | 1048 -> GammaRefractor
    | x -> raise (System.ArgumentException(sprintf "Invalid item id! %A" x))

type Prop =
    | ``Concrete Rubble``
    | ``Metal Rubble``
    | GENERIC_MACHINE_10
    | GENERIC_MACHINE_9
    | GENERIC_MACHINE_8
    | GENERIC_MACHINE_7
    | GENERIC_MACHINE_6
    | GENERIC_MACHINE_5
    | GENERIC_MACHINE_4
    | GENERIC_MACHINE_3
    | GENERIC_MACHINE_2
    | GENERIC_MACHINE_1
    | ``Terminal vFe01a``
    | ``Terminal vNi03a``
    | ``Terminal vCu03a``
    | ``Terminal vZn06a``
    | ``Terminal vAg06a``
    | ``Terminal vTi06n``
    | ``Terminal vCo08n``
    | ``Terminal vMn10n``
    | ``Terminal vMo07n``
    | ``Terminal vPd10n``
    | ``Terminal vCd08n``
    | ``Terminal vZr10n``
    | ``Terminal vY10n``
    | ``Terminal vW10x``
    | ``Terminal vIr12x``
    | ``Terminal vPt12x``
    | ``Terminal vAu13x``
    | ``Terminal vHg20x``
    | ``Terminal vRh10x``
    | ``Fabricator vLi07a``
    | ``Fabricator vNa07a``
    | ``Fabricator vK08a``
    | ``Fabricator vCs10n``
    | ``Fabricator vBe12n``
    | ``Fabricator vMg13n``
    | ``Fabricator vCa14x``
    | ``Fabricator vSr14x``
    | ``Fabricator vBa16x``
    | ``Fabricator vRa19x``
    | ``Repair vAl08a``
    | ``Repair vGa08a``
    | ``Repair vIn08a``
    | ``Repair vSn08n``
    | ``Repair vTl10n``
    | ``Repair vPb11n``
    | ``Repair vBi12x``
    | ``Repair vPo13x``
    | ``Recycling vH06a``
    | ``Recycling vN06a``
    | ``Recycling vO08n``
    | ``Recycling vF08n``
    | ``Recycling vP10x``
    | ``Recycling vI14x``
    | ``Scanalyzer vHe07a``
    | ``Scanalyzer vNe13n``
    | ``Scanalyzer vAr15x``
    | ``Scanalyzer vXe13x``
    | ``Garrison vCe6a``
    | ``Garrison vPr8a``
    | ``Garrison vNd9n``
    | ``Garrison vPm7n``
    | ``Garrison vSm13x``
    | ``Garrison vEu9x``
    | T1
    | ``Core Extractor``
    | Pulverizer
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
    | Megafabricator
    | ``Subcomponent Replicator``
    | ``Power Conduit``
    | ``Research Mainframe``
    | ``Antiparticle Reservoir``
    | ``Reaction Chamber``
    | ``Vacuum Chamber``
    | ``Subatomic Condenser``
    | Catalytron
    | ``Meson Extractor``
    | ``Antimatter Diverter``
    | ``Field Manipulator``
    | ``Particle Synthesizer``
    | ``Quantum Separator``
    | ``Wave Intensifier``
    | ``Proton Scatter Basin``
    | ``Ion Accelerator``
    | ``Magnetic Photon System``
    | Hypercollider
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
    | Focalizer
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
    | Anatomizer
    | ``Cloning Tubes``
    | ``Cell Assembler``
    | ``Molecular Binding Bank``
    | ``Anti-Ion Cluster``
    | ``Deuterium Array``
    | Mainframe
    | Storage
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
    | XXX_Blast_Door_Open
    | XXX_Blast_Door_Hackable
    | ACC_Door_Shootable_SUR
    | ACC_Door_Shootable_COM
    | ACC_Door_Hackable
    | ACC_Shell_Shootable
    | ``Main Access Lift``
    | STO_Door_Open
    | STO_Door_Hackable
    | STO_Shell_Shootable
    | GAR_Door_Shootable
    | GAR_Relay
    | GAR_Generator
    | SHOPSys
    | MIN_Door_Hackable_Weak
    | ``Assembled Analyzer``
    | Components
    | ``Testing Chamber Shield``
    | ``Testing Apparatus``
    | ``EX-Generator``
    | ``BIN's Workstation``
    | ``DEC's Workstation``
    | ``HEX's Workstation``
    | ``BIN's Terminal``
    | ``DEC's Terminal``
    | ``HEX's Terminal``
    | EXI_Farcom
    | ``EX-Vault Access``
    | ``EX-Prototypes Database``
    | ``EX-Message Board``
    | WARSys
    | ``Prototyping Terminal``
    | CAV_Door_Hackable
    | ``Outpost Terminal``
    | CAV_Base_Generator
    | CAV_Junk_Machine
    | CAV_Reinforcement
    | CAV_Door_Shootable
    | CAV_Door_No_Terminal
    | Private
    | CAV_Thief_Den
    | ``W-Fans Enter Here``
    | LOW_Warlord_Fan_Stuff
    | PRO_Base_Generator
    | PRO_Target_Dispatcher
    | PRO_Test_Aggregator
    | PRO_Data_Receptor
    | GAR_RIF_Installer
    | ``Matter Repository``
    | ``Twisting Tunnel``
    | DAT_Data_Conduit
    | ``ORACLE Interface``
    | ZHI_Cloak_Generator
    | ZHI_Main_Door
    | ``Zhirov's Terminal``
    | ``Quantum Analyzer``
    | ``Zhirov's Workstation``
    | WAR_Door_Hackable
    | ``Vortex Lab Terminal``
    | ``Hacking Lab Terminal``
    | ``Relay Lab Terminal``
    | ``Fabnet Lab Terminal``
    | ``Intel Room Terminal``
    | WAR_Staging_Area
    | RES_Staging_Area
    | WAR_Mainc_Tunnel
    | ZIO_Machinery
    | ``Deep Containment System``
    | ZIOWAR_Quarantine_Array
    | ZIO_Cloak_Generator
    | ZIO_Stockpile_Wall
    | ZIO_Prototype_Hold
    | ZIO_Lab_Wall
    | ZIO_Repair_Shop_Wall
    | ``Zion Terminal``
    | ZIO_Machinery_Fake
    | ``Conduit Teleporter``
    | ZIO_Memory_Banks
    | ZIO_Imprinter
    | DEE_Z_Facility
    | ``Z-Power``
    | DEE_Sigix_Wall
    | DEE_Sigix_Gate
    | DEE_Wall_Chamber
    | DEE_Survey_Way_Station
    | EXT_Door_Hackable
    | EXT_Transfer_Station
    | ``Cetus Terminal``
    | ``Cetus Manufacturing Controls``
    | CET_Door_Hackable
    | Doors
    | Bed
    | Lockers
    | Table
    | ``Lab Station``
    | ``Research Interface``
    | ``Cetus Mainframe``
    | ``Cetus Manufacturing Module``
    | ``Archive Terminal``
    | ``Archive Hub``
    | HUB_Transfer_Station
    | HUB_Network_Hub
    | ARM_Door_Hackable
    | ARM_Shell_Shootable
    | ARM_Dimension_Slip_Node
    | ``NO ENTRY``
    | LAB_Door_Hackable
    | ``Active System Cloaker``
    | ``A0 Command``
    | ``HN 3sDk7Qc``
    | ``A0 Storage 04-B``
    | ``UC xVqbSdU M7q4``
    | ``Suspension Chamber``
    | TES_Door_Hackable
    | TES_Shell_Shootable
    | ``Regeneration Lab``
    | TES_Terrabomb
    | QUA_Door_Hackable
    | QUA_Door_Hackable_Hard
    | ``Sigix Lab``
    | ``Sigix Quarantine Controls``
    | ``Sigix Quarantine Chamber``
    | ``Teleportation Lab``
    | ``Autopsy Lab``
    | ``Research Terminal``
    | SEC_Door_Hackable
    | ``L2 Monitoring Station``
    | ``Power Cell Monitoring``
    | Thrusters
    | SEC_L2_Power_Cell
    | ``Wing Frame``
    | ``FTL Facilitator``
    | ``Core Housing``
    | Hull
    | ``Armor Plating``
    | Navigation
    | ``Construction Supplies``
    | ``L2 Fabricator``
    | ``Exoskeleton Controls``
    | ``Cave Seal Controls``
    | COM_Cave_Spawn
    | COM_Shell_Shootable
    | ``Access Lift``
    | COM_Teleport_Inhibitor
    | COM_Door_Hackable
    | COM_0b10_Conduit
    | COM_Alternative_Access
    | COM_Cache_Door
    | AC0_Singularity_Gate
    | ``Gate Controls``
    | AC0_Subspace_Node
    | AC0_Subspace_Node_Mid
    | AC0_Architect_Shell
    | ``Architect Logs``
    | AC0_Abandoned_Machinery
    | AC0_Shell_Shootable
    | ``Analysis Chamber``
    | AC0_Workstation
    | SCR_Black_Space
    | SCR_New_Year_City

let getProp =
    function
    | 0 -> ``Concrete Rubble``
    | 1 -> ``Metal Rubble``
    | 2 -> GENERIC_MACHINE_10
    | 3 -> GENERIC_MACHINE_9
    | 4 -> GENERIC_MACHINE_8
    | 5 -> GENERIC_MACHINE_7
    | 6 -> GENERIC_MACHINE_6
    | 7 -> GENERIC_MACHINE_5
    | 8 -> GENERIC_MACHINE_4
    | 9 -> GENERIC_MACHINE_3
    | 10 -> GENERIC_MACHINE_2
    | 11 -> GENERIC_MACHINE_1
    | 12 -> ``Terminal vFe01a``
    | 13 -> ``Terminal vNi03a``
    | 14 -> ``Terminal vCu03a``
    | 15 -> ``Terminal vZn06a``
    | 16 -> ``Terminal vAg06a``
    | 17 -> ``Terminal vTi06n``
    | 18 -> ``Terminal vCo08n``
    | 19 -> ``Terminal vMn10n``
    | 20 -> ``Terminal vMo07n``
    | 21 -> ``Terminal vPd10n``
    | 22 -> ``Terminal vCd08n``
    | 23 -> ``Terminal vZr10n``
    | 24 -> ``Terminal vY10n``
    | 25 -> ``Terminal vW10x``
    | 26 -> ``Terminal vIr12x``
    | 27 -> ``Terminal vPt12x``
    | 28 -> ``Terminal vAu13x``
    | 29 -> ``Terminal vHg20x``
    | 30 -> ``Terminal vRh10x``
    | 31 -> ``Fabricator vLi07a``
    | 32 -> ``Fabricator vNa07a``
    | 33 -> ``Fabricator vK08a``
    | 34 -> ``Fabricator vCs10n``
    | 35 -> ``Fabricator vBe12n``
    | 36 -> ``Fabricator vMg13n``
    | 37 -> ``Fabricator vCa14x``
    | 38 -> ``Fabricator vSr14x``
    | 39 -> ``Fabricator vBa16x``
    | 40 -> ``Fabricator vRa19x``
    | 41 -> ``Repair vAl08a``
    | 42 -> ``Repair vGa08a``
    | 43 -> ``Repair vIn08a``
    | 44 -> ``Repair vSn08n``
    | 45 -> ``Repair vTl10n``
    | 46 -> ``Repair vPb11n``
    | 47 -> ``Repair vBi12x``
    | 48 -> ``Repair vPo13x``
    | 49 -> ``Recycling vH06a``
    | 50 -> ``Recycling vN06a``
    | 51 -> ``Recycling vO08n``
    | 52 -> ``Recycling vF08n``
    | 53 -> ``Recycling vP10x``
    | 54 -> ``Recycling vI14x``
    | 55 -> ``Scanalyzer vHe07a``
    | 56 -> ``Scanalyzer vNe13n``
    | 57 -> ``Scanalyzer vAr15x``
    | 58 -> ``Scanalyzer vXe13x``
    | 59 -> ``Garrison vCe6a``
    | 60 -> ``Garrison vPr8a``
    | 61 -> ``Garrison vNd9n``
    | 62 -> ``Garrison vPm7n``
    | 63 -> ``Garrison vSm13x``
    | 64 -> ``Garrison vEu9x``
    | 65 -> T1
    | 66 -> ``Core Extractor``
    | 67 -> Pulverizer
    | 68 -> ``Laser Drill``
    | 69 -> ``Plasma Injector``
    | 70 -> ``Seismic Survey Station``
    | 71 -> ``Matter Pump``
    | 72 -> ``Pressure Siphon``
    | 73 -> ``Nuclear Reactor``
    | 74 -> ``Neutrino Reactor``
    | 75 -> ``Fusion Modulator``
    | 76 -> ``Quantum Generator``
    | 77 -> ``Dark Matter Chamber``
    | 78 -> ``Hypermatter Reactor``
    | 79 -> ``Compression Vault``
    | 80 -> ``Component Storage``
    | 81 -> ``Holding Depot``
    | 82 -> ``Packing Station``
    | 83 -> ``Arsenal Racks``
    | 84 -> ``Extraspacial Lockers``
    | 85 -> ``Energy Cycler``
    | 86 -> ``Transport Mainframe``
    | 87 -> ``Transfer Shaft``
    | 88 -> ``Hadron Collector``
    | 89 -> ``Electrolysis Chamber``
    | 90 -> ``Processing Tank``
    | 91 -> ``Atomic Centrifuge``
    | 92 -> ``Purification Channel``
    | 93 -> ``Integration Channel``
    | 94 -> ``Material Processor``
    | 95 -> ``Material Compactor``
    | 96 -> ``Matter Filter``
    | 97 -> ``Manufacturing Mainframe``
    | 98 -> ``Construction Platform``
    | 99 -> ``Assembly Bed``
    | 100 -> Megafabricator
    | 101 -> ``Subcomponent Replicator``
    | 102 -> ``Power Conduit``
    | 103 -> ``Research Mainframe``
    | 104 -> ``Antiparticle Reservoir``
    | 105 -> ``Reaction Chamber``
    | 106 -> ``Vacuum Chamber``
    | 107 -> ``Subatomic Condenser``
    | 108 -> Catalytron
    | 109 -> ``Meson Extractor``
    | 110 -> ``Antimatter Diverter``
    | 111 -> ``Field Manipulator``
    | 112 -> ``Particle Synthesizer``
    | 113 -> ``Quantum Separator``
    | 114 -> ``Wave Intensifier``
    | 115 -> ``Proton Scatter Basin``
    | 116 -> ``Ion Accelerator``
    | 117 -> ``Magnetic Photon System``
    | 118 -> Hypercollider
    | 119 -> ``Graviton Restrictor``
    | 120 -> ``Potential Refractor``
    | 121 -> ``Prototyping Station``
    | 122 -> ``Engineering Station``
    | 123 -> ``Biostasis Chamber``
    | 124 -> ``Organic Neutralizer``
    | 125 -> ``Containment Shield``
    | 126 -> ``Testing Mainframe``
    | 127 -> ``Sonic Impulse Analyzer``
    | 128 -> ``Field Warper``
    | 129 -> ``Gravity Sphere``
    | 130 -> ``Quantum Transformer``
    | 131 -> Focalizer
    | 132 -> ``Phase Constrictor``
    | 133 -> ``Resonance Scanner``
    | 134 -> ``Tau Charger``
    | 135 -> ``Harmonic Fracturing Unit``
    | 136 -> ``Antiparticle Suffusor``
    | 137 -> ``Thermocompressor Array``
    | 138 -> ``Cryocooling Duct``
    | 139 -> ``Artifact Storage``
    | 140 -> ``Cryopreservation Unit``
    | 141 -> ``Biostim Tank``
    | 142 -> ``Quarantine Pod``
    | 143 -> ``Aeration Cycler``
    | 144 -> ``Deconstruction Unit``
    | 145 -> Anatomizer
    | 146 -> ``Cloning Tubes``
    | 147 -> ``Cell Assembler``
    | 148 -> ``Molecular Binding Bank``
    | 149 -> ``Anti-Ion Cluster``
    | 150 -> ``Deuterium Array``
    | 151 -> Mainframe
    | 152 -> Storage
    | 153 -> ``Retrofitting Station``
    | 154 -> ``Signal Jammer``
    | 155 -> ``Cloak Generator``
    | 156 -> ``Decryption Engine``
    | 157 -> ``Backup Mainframe``
    | 158 -> ``Archive Unit``
    | 159 -> ``Control Node``
    | 160 -> ``Operations Mainframe``
    | 161 -> ``Quantum Router``
    | 162 -> ``Hyperwave Decoder``
    | 163 -> ``Sealed Freight Elevator``
    | 164 -> ``Radio-Gravity Array``
    | 165 -> ``Anti-Orbital Battery``
    | 166 -> ``Spectral Interrupter``
    | 167 -> ``Wave Collapse Detector``
    | 168 -> ``Signal Shield``
    | 169 -> ``Longscan Aggregator``
    | 170 -> ``Blade Trap``
    | 171 -> ``Segregator Trap``
    | 172 -> ``Explosive Trap``
    | 173 -> ``Heavy Explosive Trap``
    | 174 -> ``Tiamat Bomb Trap``
    | 175 -> ``Fusion Bomb Trap``
    | 176 -> ``Hellfire Trap``
    | 177 -> ``Armageddon Trap``
    | 178 -> ``Dirty Bomb Trap``
    | 179 -> ``EMP Trap``
    | 180 -> ``Proton Bomb Trap``
    | 181 -> ``Tesla Bomb Trap``
    | 182 -> ``Gamma Bomb Trap``
    | 183 -> ``Shock Trap``
    | 184 -> ``EM Surge Trap``
    | 185 -> ``Fire Trap``
    | 186 -> ``Stasis Trap``
    | 187 -> ``Alarm Trap``
    | 188 -> ``Ambush Trap``
    | 189 -> ``Chute Trap``
    | 195 -> ``Collapsed Tunnel``
    | 213 -> ``Door Terminal``
    | 214 -> ``DSF Access``
    | 215 -> ``Broken Shaft Lining``
    | 216 -> XXX_Blast_Door_Open
    | 217 -> XXX_Blast_Door_Hackable
    | 218 -> ACC_Door_Shootable_SUR
    | 219 -> ACC_Door_Shootable_COM
    | 220 -> ACC_Door_Hackable
    | 221 -> ACC_Shell_Shootable
    | 222 -> ``Main Access Lift``
    | 224 -> STO_Door_Open
    | 225 -> STO_Door_Hackable
    | 226 -> STO_Shell_Shootable
    | 227 -> GAR_Door_Shootable
    | 228 -> GAR_Relay
    | 229 -> GAR_Generator
    | 230 -> SHOPSys
    | 231 -> MIN_Door_Hackable_Weak
    | 232 -> ``Assembled Analyzer``
    | 233 -> Components
    | 234 -> ``Testing Chamber Shield``
    | 235 -> ``Testing Apparatus``
    | 236 -> ``EX-Generator``
    | 237 -> ``BIN's Workstation``
    | 238 -> ``DEC's Workstation``
    | 239 -> ``HEX's Workstation``
    | 240 -> ``BIN's Terminal``
    | 241 -> ``DEC's Terminal``
    | 242 -> ``HEX's Terminal``
    | 243 -> EXI_Farcom
    | 244 -> ``EX-Vault Access``
    | 245 -> ``EX-Prototypes Database``
    | 246 -> ``EX-Message Board``
    | 247 -> WARSys
    | 248 -> ``Prototyping Terminal``
    | 249 -> CAV_Door_Hackable
    | 250 -> ``Outpost Terminal``
    | 251 -> CAV_Base_Generator
    | 252 -> CAV_Junk_Machine
    | 253 -> CAV_Reinforcement
    | 254 -> CAV_Door_Shootable
    | 255 -> CAV_Door_No_Terminal
    | 256 -> Private
    | 257 -> CAV_Thief_Den
    | 258 -> ``W-Fans Enter Here``
    | 259 -> LOW_Warlord_Fan_Stuff
    | 260 -> PRO_Base_Generator
    | 261 -> PRO_Target_Dispatcher
    | 262 -> PRO_Test_Aggregator
    | 263 -> PRO_Data_Receptor
    | 264 -> GAR_RIF_Installer
    | 265 -> ``Matter Repository``
    | 266 -> ``Twisting Tunnel``
    | 267 -> DAT_Data_Conduit
    | 268 -> ``ORACLE Interface``
    | 269 -> ZHI_Cloak_Generator
    | 271 -> ZHI_Main_Door
    | 272 -> ``Zhirov's Terminal``
    | 273 -> ``Quantum Analyzer``
    | 274 -> ``Zhirov's Workstation``
    | 275 -> WAR_Door_Hackable
    | 276 -> ``Vortex Lab Terminal``
    | 277 -> ``Hacking Lab Terminal``
    | 278 -> ``Relay Lab Terminal``
    | 279 -> ``Fabnet Lab Terminal``
    | 280 -> ``Intel Room Terminal``
    | 281 -> WAR_Staging_Area
    | 282 -> RES_Staging_Area
    | 283 -> WAR_Mainc_Tunnel
    | 284 -> ZIO_Machinery
    | 285 -> ``Deep Containment System``
    | 286 -> ZIOWAR_Quarantine_Array
    | 287 -> ZIO_Cloak_Generator
    | 288 -> ZIO_Stockpile_Wall
    | 289 -> ZIO_Prototype_Hold
    | 290 -> ZIO_Lab_Wall
    | 291 -> ZIO_Repair_Shop_Wall
    | 292 -> ``Zion Terminal``
    | 293 -> ZIO_Machinery_Fake
    | 294 -> ``Conduit Teleporter``
    | 295 -> ZIO_Memory_Banks
    | 296 -> ZIO_Imprinter
    | 297 -> DEE_Z_Facility
    | 298 -> ``Z-Power``
    | 300 -> DEE_Sigix_Wall
    | 301 -> DEE_Sigix_Gate
    | 302 -> DEE_Wall_Chamber
    | 303 -> DEE_Survey_Way_Station
    | 304 -> EXT_Door_Hackable
    | 306 -> EXT_Transfer_Station
    | 307 -> ``Cetus Terminal``
    | 308 -> ``Cetus Manufacturing Controls``
    | 309 -> CET_Door_Hackable
    | 310 -> Doors
    | 311 -> Bed
    | 312 -> Lockers
    | 313 -> Table
    | 314 -> ``Lab Station``
    | 315 -> ``Research Interface``
    | 316 -> ``Cetus Mainframe``
    | 317 -> ``Cetus Manufacturing Module``
    | 318 -> ``Archive Terminal``
    | 319 -> ``Archive Hub``
    | 320 -> HUB_Transfer_Station
    | 321 -> HUB_Network_Hub
    | 322 -> ARM_Door_Hackable
    | 323 -> ARM_Shell_Shootable
    | 324 -> ARM_Dimension_Slip_Node
    | 325 -> ``NO ENTRY``
    | 326 -> LAB_Door_Hackable
    | 327 -> ``Active System Cloaker``
    | 328 -> ``A0 Command``
    | 329 -> ``HN 3sDk7Qc``
    | 330 -> ``A0 Storage 04-B``
    | 331 -> ``UC xVqbSdU M7q4``
    | 332 -> ``Suspension Chamber``
    | 334 -> TES_Door_Hackable
    | 335 -> TES_Shell_Shootable
    | 336 -> ``Regeneration Lab``
    | 337 -> TES_Terrabomb
    | 338 -> QUA_Door_Hackable
    | 339 -> QUA_Door_Hackable_Hard
    | 340 -> ``Sigix Lab``
    | 341 -> ``Sigix Quarantine Controls``
    | 342 -> ``Sigix Quarantine Chamber``
    | 343 -> ``Teleportation Lab``
    | 344 -> ``Autopsy Lab``
    | 345 -> ``Research Terminal``
    | 346 -> SEC_Door_Hackable
    | 347 -> ``L2 Monitoring Station``
    | 348 -> ``Power Cell Monitoring``
    | 349 -> Thrusters
    | 350 -> SEC_L2_Power_Cell
    | 351 -> ``Wing Frame``
    | 352 -> ``FTL Facilitator``
    | 353 -> ``Core Housing``
    | 354 -> Hull
    | 355 -> ``Armor Plating``
    | 356 -> Navigation
    | 357 -> ``Construction Supplies``
    | 358 -> ``L2 Fabricator``
    | 359 -> ``Exoskeleton Controls``
    | 360 -> ``Cave Seal Controls``
    | 361 -> COM_Cave_Spawn
    | 362 -> COM_Shell_Shootable
    | 363 -> ``Access Lift``
    | 364 -> COM_Teleport_Inhibitor
    | 365 -> COM_Door_Hackable
    | 366 -> COM_0b10_Conduit
    | 367 -> COM_Alternative_Access
    | 369 -> COM_Cache_Door
    | 370 -> AC0_Singularity_Gate
    | 371 -> ``Gate Controls``
    | 373 -> AC0_Subspace_Node
    | 374 -> AC0_Subspace_Node_Mid
    | 375 -> AC0_Architect_Shell
    | 376 -> ``Architect Logs``
    | 377 -> AC0_Abandoned_Machinery
    | 378 -> AC0_Shell_Shootable
    | 379 -> ``Analysis Chamber``
    | 380 -> AC0_Workstation
    | 381 -> SCR_Black_Space
    | 382 -> SCR_New_Year_City
    | x -> raise (System.ArgumentException(sprintf "Invalid value for prop type: %A" x))

type PropOcclusion =
    | Obstructed
    | Dangerous
    | Vacant

let propToOcclusion =
    function
    | ``Concrete Rubble``
    | ``Metal Rubble`` -> Vacant
    | GENERIC_MACHINE_10
    | GENERIC_MACHINE_9
    | GENERIC_MACHINE_8
    | GENERIC_MACHINE_7
    | GENERIC_MACHINE_6
    | GENERIC_MACHINE_5
    | GENERIC_MACHINE_4
    | GENERIC_MACHINE_3
    | GENERIC_MACHINE_2
    | GENERIC_MACHINE_1
    | ``Terminal vFe01a``
    | ``Terminal vNi03a``
    | ``Terminal vCu03a``
    | ``Terminal vZn06a``
    | ``Terminal vAg06a``
    | ``Terminal vTi06n``
    | ``Terminal vCo08n``
    | ``Terminal vMn10n``
    | ``Terminal vMo07n``
    | ``Terminal vPd10n``
    | ``Terminal vCd08n``
    | ``Terminal vZr10n``
    | ``Terminal vY10n``
    | ``Terminal vW10x``
    | ``Terminal vIr12x``
    | ``Terminal vPt12x``
    | ``Terminal vAu13x``
    | ``Terminal vHg20x``
    | ``Terminal vRh10x``
    | ``Fabricator vLi07a``
    | ``Fabricator vNa07a``
    | ``Fabricator vK08a``
    | ``Fabricator vCs10n``
    | ``Fabricator vBe12n``
    | ``Fabricator vMg13n``
    | ``Fabricator vCa14x``
    | ``Fabricator vSr14x``
    | ``Fabricator vBa16x``
    | ``Fabricator vRa19x``
    | ``Repair vAl08a``
    | ``Repair vGa08a``
    | ``Repair vIn08a``
    | ``Repair vSn08n``
    | ``Repair vTl10n``
    | ``Repair vPb11n``
    | ``Repair vBi12x``
    | ``Repair vPo13x``
    | ``Recycling vH06a``
    | ``Recycling vN06a``
    | ``Recycling vO08n``
    | ``Recycling vF08n``
    | ``Recycling vP10x``
    | ``Recycling vI14x``
    | ``Scanalyzer vHe07a``
    | ``Scanalyzer vNe13n``
    | ``Scanalyzer vAr15x``
    | ``Scanalyzer vXe13x``
    | ``Garrison vCe6a``
    | ``Garrison vPr8a``
    | ``Garrison vNd9n``
    | ``Garrison vPm7n``
    | ``Garrison vSm13x``
    | ``Garrison vEu9x``
    | T1
    | ``Core Extractor``
    | Pulverizer
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
    | Megafabricator
    | ``Subcomponent Replicator``
    | ``Power Conduit``
    | ``Research Mainframe``
    | ``Antiparticle Reservoir``
    | ``Reaction Chamber``
    | ``Vacuum Chamber``
    | ``Subatomic Condenser``
    | Catalytron
    | ``Meson Extractor``
    | ``Antimatter Diverter``
    | ``Field Manipulator``
    | ``Particle Synthesizer``
    | ``Quantum Separator``
    | ``Wave Intensifier``
    | ``Proton Scatter Basin``
    | ``Ion Accelerator``
    | ``Magnetic Photon System``
    | Hypercollider
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
    | Focalizer
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
    | Anatomizer
    | ``Cloning Tubes``
    | ``Cell Assembler``
    | ``Molecular Binding Bank``
    | ``Anti-Ion Cluster``
    | ``Deuterium Array``
    | Mainframe
    | Storage
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
    | ``Longscan Aggregator`` -> Obstructed
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
    | ``Shock Trap``
    | ``EM Surge Trap``
    | ``Fire Trap``
    | ``Stasis Trap``
    | ``Alarm Trap``
    | ``Ambush Trap``
    | ``Chute Trap`` -> Dangerous
    | ``Collapsed Tunnel``
    | ``Door Terminal``
    | ``DSF Access``
    | ``Broken Shaft Lining`` -> Obstructed
    | XXX_Blast_Door_Open -> Vacant
    | XXX_Blast_Door_Hackable
    | ACC_Door_Shootable_SUR
    | ACC_Door_Shootable_COM
    | ACC_Door_Hackable
    | ACC_Shell_Shootable
    | ``Main Access Lift`` -> Obstructed
    | STO_Door_Open -> Vacant
    | STO_Door_Hackable
    | STO_Shell_Shootable
    | GAR_Door_Shootable
    | GAR_Relay
    | GAR_Generator
    | SHOPSys
    | MIN_Door_Hackable_Weak
    | ``Assembled Analyzer``
    | Components
    | ``Testing Chamber Shield``
    | ``Testing Apparatus``
    | ``EX-Generator``
    | ``BIN's Workstation``
    | ``DEC's Workstation``
    | ``HEX's Workstation``
    | ``BIN's Terminal``
    | ``DEC's Terminal``
    | ``HEX's Terminal``
    | EXI_Farcom
    | ``EX-Vault Access``
    | ``EX-Prototypes Database``
    | ``EX-Message Board``
    | WARSys
    | ``Prototyping Terminal``
    | CAV_Door_Hackable
    | ``Outpost Terminal``
    | CAV_Base_Generator
    | CAV_Junk_Machine
    | CAV_Reinforcement
    | CAV_Door_Shootable
    | CAV_Door_No_Terminal
    | Private
    | CAV_Thief_Den
    | ``W-Fans Enter Here``
    | LOW_Warlord_Fan_Stuff
    | PRO_Base_Generator
    | PRO_Target_Dispatcher
    | PRO_Test_Aggregator
    | PRO_Data_Receptor
    | GAR_RIF_Installer
    | ``Matter Repository``
    | ``Twisting Tunnel``
    | DAT_Data_Conduit
    | ``ORACLE Interface``
    | ZHI_Cloak_Generator
    | ZHI_Main_Door
    | ``Zhirov's Terminal``
    | ``Quantum Analyzer``
    | ``Zhirov's Workstation``
    | WAR_Door_Hackable
    | ``Vortex Lab Terminal``
    | ``Hacking Lab Terminal``
    | ``Relay Lab Terminal``
    | ``Fabnet Lab Terminal``
    | ``Intel Room Terminal``
    | WAR_Staging_Area
    | RES_Staging_Area
    | WAR_Mainc_Tunnel
    | ZIO_Machinery
    | ``Deep Containment System``
    | ZIOWAR_Quarantine_Array
    | ZIO_Cloak_Generator
    | ZIO_Stockpile_Wall
    | ZIO_Prototype_Hold
    | ZIO_Lab_Wall
    | ZIO_Repair_Shop_Wall
    | ``Zion Terminal``
    | ZIO_Machinery_Fake
    | ``Conduit Teleporter``
    | ZIO_Memory_Banks
    | ZIO_Imprinter
    | DEE_Z_Facility
    | ``Z-Power``
    | DEE_Sigix_Wall
    | DEE_Sigix_Gate
    | DEE_Wall_Chamber
    | DEE_Survey_Way_Station
    | EXT_Door_Hackable
    | EXT_Transfer_Station
    | ``Cetus Terminal``
    | ``Cetus Manufacturing Controls``
    | CET_Door_Hackable
    | Doors
    | Bed
    | Lockers
    | Table
    | ``Lab Station``
    | ``Research Interface``
    | ``Cetus Mainframe``
    | ``Cetus Manufacturing Module``
    | ``Archive Terminal``
    | ``Archive Hub``
    | HUB_Transfer_Station
    | HUB_Network_Hub
    | ARM_Door_Hackable
    | ARM_Shell_Shootable
    | ARM_Dimension_Slip_Node
    | ``NO ENTRY``
    | LAB_Door_Hackable
    | ``Active System Cloaker``
    | ``A0 Command``
    | ``HN 3sDk7Qc``
    | ``A0 Storage 04-B``
    | ``UC xVqbSdU M7q4``
    | ``Suspension Chamber``
    | TES_Door_Hackable
    | TES_Shell_Shootable
    | ``Regeneration Lab``
    | TES_Terrabomb
    | QUA_Door_Hackable
    | QUA_Door_Hackable_Hard
    | ``Sigix Lab``
    | ``Sigix Quarantine Controls``
    | ``Sigix Quarantine Chamber``
    | ``Teleportation Lab``
    | ``Autopsy Lab``
    | ``Research Terminal``
    | SEC_Door_Hackable
    | ``L2 Monitoring Station``
    | ``Power Cell Monitoring``
    | Thrusters
    | SEC_L2_Power_Cell
    | ``Wing Frame``
    | ``FTL Facilitator``
    | ``Core Housing``
    | Hull
    | ``Armor Plating``
    | Navigation
    | ``Construction Supplies``
    | ``L2 Fabricator``
    | ``Exoskeleton Controls``
    | ``Cave Seal Controls``
    | COM_Cave_Spawn
    | COM_Shell_Shootable
    | ``Access Lift``
    | COM_Teleport_Inhibitor
    | COM_Door_Hackable
    | COM_0b10_Conduit
    | COM_Alternative_Access
    | COM_Cache_Door
    | AC0_Singularity_Gate
    | ``Gate Controls``
    | AC0_Subspace_Node
    | AC0_Subspace_Node_Mid
    | AC0_Architect_Shell
    | ``Architect Logs``
    | AC0_Abandoned_Machinery
    | AC0_Shell_Shootable
    | ``Analysis Chamber``
    | AC0_Workstation
    | SCR_Black_Space
    | SCR_New_Year_City -> Obstructed

type Part =
    | Component of Item
    | Weapon of Item

type entity =
    | Cogmind = 0
    | Drone = 1
    | Target_Drone = 2
    | Mini_Drone = 3
    | Mapping_Drone = 4
    | Sensor_Drone = 5
    | Hacking_Drone = 6
    | Minesniffer_Drone = 7
    | Decoy_Drone = 8
    | Splice_Drone = 9
    | Advanced_Drone = 10
    | Stealth_Drone = 11
    | Trailblazer = 12
    | Thief_Drone = 13
    | Army_Drone = 14
    | Swarm_Drone = 15
    | Combat_Drone = 16
    | Assault_Drone = 17
    | Bomb_Drone = 18
    | Wardrone = 19
    | DAS_Turret = 20
    | K01_Serf = 21
    | U05_Engineer = 22
    | T07_Excavator = 23
    | A02_Transporter = 24
    | A15_Conveyor = 25
    | A27_Freighter = 26
    | R06_Scavenger = 27
    | R10_Processor = 28
    | C30_ARC = 29
    | M14_Sweeper = 30
    | M22_Extractor = 31
    | M30_Cleanser = 32
    | M13_Machinist = 33
    | M28_Smith = 34
    | M36_Artificer = 35
    | O16_Technician = 36
    | O24_Administrator = 37
    | O32_Director = 38
    | N00_Fly = 39
    | N01_Spotter = 40
    | W16_Scout = 41
    | W25_Informer = 42
    | W44_Eye = 43
    | S10_Pest = 44
    | S27_Virus = 45
    | S43_Plague = 46
    | C17_Slicer = 47
    | C35_Carver = 48
    | C57_Dissector = 49
    | E15_Imp = 50
    | G34_Mercenary = 51
    | G47_Trooper = 52
    | G50_Soldier = 53
    | G67_Veteran = 54
    | G73_Enforcer = 55
    | B36_Bruiser = 56
    | B48_Gladiator = 57
    | B60_Warrior = 58
    | B74_Champion = 59
    | L31_Rogue = 60
    | L41_Fighter = 61
    | L61_Swordsman = 62
    | I25_Savior = 63
    | I36_Angel = 64
    | I47_Archangel = 65
    | C55_Analyst = 66
    | C65_Expert = 67
    | Y45_Defender = 68
    | Y54_Guardian = 69
    | Y64_Sentinel = 70
    | Y72_Warden = 71
    | D53_Grenadier = 72
    | D63_Destroyer = 73
    | D83_Annihilator = 74
    | X57_Shotgunner = 75
    | X62_Marksman = 76
    | X67_Chaingunner = 77
    | X72_Disruptor = 78
    | X77_Beamer = 79
    | X82_Rainmaker = 80
    | X87_Electro = 81
    | H55_Commando = 82
    | H66_Slayer = 83
    | H77_Assassin = 84
    | H88_Terminator = 85
    | P60_Hacker = 86
    | P70_Sage = 87
    | P80_Master = 88
    | H61_Shepherd = 89
    | H71_Marshal = 90
    | H81_Overseer = 91
    | QSeries = 92
    | B75_Beast = 93
    | B86_Titan = 94
    | B90_Cyclops = 95
    | B99_Colossus = 96
    | C40_Crusher = 97
    | Cetus_Guard = 98
    | Quarantine_Guard = 99
    | S7_Guard = 100
    | M_Guard = 101
    | M_Shell_Atk = 102
    | M_Shell_Def = 103
    | Enhanced_Grunt = 104
    | Enhanced_Sentry = 105
    | Enhanced_Demolisher = 106
    | Enhanced_Hunter = 107
    | Enhanced_Programmer = 108
    | Enhanced_QSeries = 109
    | Lightning = 110
    | Tracker = 111
    | Combat_Programmer = 112
    | Investigator = 113
    | Striker = 114
    | Executioner = 115
    | Superbehemoth = 116
    | Alpha_7 = 117
    | Fortress = 118
    | LRCV4 = 119
    | LRCV5 = 120
    | LRCV6 = 121
    | P_Grunt = 122
    | P_Duelist = 123
    | P_Sentry = 124
    | P_Demolisher = 125
    | P_Specialist = 126
    | P_Hunter = 127
    | P_Programmer = 128
    | Zionite = 129
    | ZTechnician = 130
    | Z_Courier = 131
    | Z_Recon = 132
    | Z_Light_5 = 133
    | Z_Light_7 = 134
    | Z_Light_9 = 135
    | Z_Heavy_5 = 136
    | Z_Heavy_7 = 137
    | Z_Heavy_9 = 138
    | Z_Experiment_8 = 139
    | Z_Experiment_10 = 140
    | Decomposer = 141
    | Packrat = 142
    | Samaritan = 143
    | Tinkerer = 144
    | Demented = 145
    | Furnace = 146
    | Parasite = 147
    | Thief_5 = 148
    | Thief_7 = 149
    | Assembler = 150
    | Assembled_4 = 151
    | Assembled_7 = 152
    | Golem_8 = 153
    | Golem_0 = 154
    | Surgeon_4 = 155
    | Surgeon_6 = 156
    | Wasp_5 = 157
    | Wasp_7 = 158
    | Thug_5 = 159
    | Thug_7 = 160
    | Savage_5 = 161
    | Savage_7 = 162
    | Butcher_5 = 163
    | Butcher_7 = 164
    | Bouncer_7 = 165
    | Martyr_5 = 166
    | Martyr_7 = 167
    | Guerilla_5 = 168
    | Guerilla_7 = 169
    | Wizard_5 = 170
    | Wizard_7 = 171
    | Marauder_6 = 172
    | Marauder_8 = 173
    | Fireman_5 = 174
    | Fireman_7 = 175
    | Mutant_5 = 176
    | Mutant_6 = 177
    | Mutant_7 = 178
    | Mutant_8 = 179
    | Sapper = 180
    | Commander = 181
    | Knight = 182
    | Troll = 183
    | Dragon = 184
    | Hydra = 185
    | Borebot = 186
    | Revision = 187
    | Anomaly = 188
    | Lesser_Abomination = 189
    | Minor_Abomination = 190
    | Greater_Abomination = 191
    | Major_Abomination = 192
    | Ultimate_Abomination = 193
    | Final_Abomination = 194
    | Player = 195
    | Player_2 = 196
    | Sauler = 197
    | Elf = 198
    | YIUF0 = 199
    | O1MTF = 200
    | Warlord_Statue = 201
    | Warbot = 202
    | SHAD0 = 203
    | Surveybot_24 = 204
    | BRAWN = 205
    | EXBIN = 206
    | EXDEC = 207
    | EXHEX = 208
    | Zion_Hero_01 = 209
    | Zion_Hero_02 = 210
    | Zion_Hero_03 = 211
    | Zion_Hero_04 = 212
    | Zion_Hero_05 = 213
    | Zion_Hero_06 = 214
    | Zion_Hero_07 = 215
    | Zion_Hero_08 = 216
    | Zion_Hero_09 = 217
    | Revision_17 = 218
    | Revision_17pp = 219
    | Imprinter = 220
    | ZImprinter = 221
    | A8 = 222
    | A7 = 223
    | A6 = 224
    | A5 = 225
    | A4 = 226
    | A3 = 227
    | A2 = 228
    | Zhirov = 229
    | Perun = 230
    | Svarog = 231
    | Data_Miner = 232
    | Fake_God_Mode = 233
    | God_Mode = 234
    | Warlord = 235
    | Warlord_B = 236
    | Warlord_AMPH4 = 237
    | Warlord_MG163 = 238
    | Warlord_HL1SK = 239
    | Warlord_SHK8T = 240
    | Warlord_D3CKR = 241
    | Warlord_4ZXS3 = 242
    | Warlord_KYZ71 = 243
    | Sigix_Containment_Pod = 244
    | Sigix_Exoskeleton = 245
    | Sigix_Warrior = 246
    | MAINC_A = 247
    | MAINC_B = 248
    | Architect = 249

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
    
let liftMapType  =
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
