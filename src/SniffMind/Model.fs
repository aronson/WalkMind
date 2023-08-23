module WalkMind.Model

open System.Text
open WalkMind.Memory
open WalkMind.Domain

type Propulsion =
    | Flight
    | Hover
    | Wheel
    | Legs
    | Treads

type Utility =
    | Device
    | Processor
    | Armor
    | Storage

type Weapon =
    | Launcher
    | Gun
    | Cannon
    | Special
    | Melee

type ItemCategory =
    | Power
    | Propulsion of Propulsion
    | Utility of Utility
    | Weapon of Weapon
    | Misc
    | Matter

type PropOcclusion =
    | Obstructed
    | Vacant
    | Dangerous

let propToOcclusion =
    function
    | Prop.``Concrete Rubble``
    | Prop.``Metal Rubble`` -> PropOcclusion.Vacant
    | Prop.``GENERIC_MACHINE_10``
    | Prop.``GENERIC_MACHINE_9``
    | Prop.``GENERIC_MACHINE_8``
    | Prop.``GENERIC_MACHINE_7``
    | Prop.``GENERIC_MACHINE_6``
    | Prop.``GENERIC_MACHINE_5``
    | Prop.``GENERIC_MACHINE_4``
    | Prop.``GENERIC_MACHINE_3``
    | Prop.``GENERIC_MACHINE_2``
    | Prop.``GENERIC_MACHINE_1``
    | Prop.``Terminal vFe_01a``
    | Prop.``Terminal vNi_03a``
    | Prop.``Terminal vCu_03a``
    | Prop.``Terminal vZn_06a``
    | Prop.``Terminal vAg_06a``
    | Prop.``Terminal vTi_06n``
    | Prop.``Terminal vCo_08n``
    | Prop.``Terminal vMn_10n``
    | Prop.``Terminal vMo_07n``
    | Prop.``Terminal vPd_10n``
    | Prop.``Terminal vCd_08n``
    | Prop.``Terminal vZr_10n``
    | Prop.``Terminal vY_10n``
    | Prop.``Terminal vW_10x``
    | Prop.``Terminal vIr_12x``
    | Prop.``Terminal vPt_12x``
    | Prop.``Terminal vAu_13x``
    | Prop.``Terminal vHg_20x``
    | Prop.``Terminal vRh_10x``
    | Prop.``Fabricator vLi_07a``
    | Prop.``Fabricator vNa_07a``
    | Prop.``Fabricator vK_08a``
    | Prop.``Fabricator vCs_10n``
    | Prop.``Fabricator vBe_12n``
    | Prop.``Fabricator vMg_13n``
    | Prop.``Fabricator vCa_14x``
    | Prop.``Fabricator vSr_14x``
    | Prop.``Fabricator vBa_16x``
    | Prop.``Fabricator vRa_19x``
    | Prop.``Repair vAl_08a``
    | Prop.``Repair vGa_08a``
    | Prop.``Repair vIn_08a``
    | Prop.``Repair vSn_08n``
    | Prop.``Repair vTl_10n``
    | Prop.``Repair vPb_11n``
    | Prop.``Repair vBi_12x``
    | Prop.``Repair vPo_13x``
    | Prop.``Recycling vH_06a``
    | Prop.``Recycling vN_06a``
    | Prop.``Recycling vO_08n``
    | Prop.``Recycling vF_08n``
    | Prop.``Recycling vP_10x``
    | Prop.``Recycling vI_14x``
    | Prop.``Scanalyzer vHe_07a``
    | Prop.``Scanalyzer vNe_13n``
    | Prop.``Scanalyzer vAr_15x``
    | Prop.``Scanalyzer vXe_13x``
    | Prop.``Garrison vCe_6a``
    | Prop.``Garrison vPr_8a``
    | Prop.``Garrison vNd_9n``
    | Prop.``Garrison vPm_7n``
    | Prop.``Garrison vSm_13x``
    | Prop.``Garrison vEu_9x``
    | Prop.``T1``
    | Prop.``Core Extractor``
    | Prop.``Pulverizer``
    | Prop.``Laser Drill``
    | Prop.``Plasma Injector``
    | Prop.``Seismic Survey Station``
    | Prop.``Matter Pump``
    | Prop.``Pressure Siphon``
    | Prop.``Nuclear Reactor``
    | Prop.``Neutrino Reactor``
    | Prop.``Fusion Modulator``
    | Prop.``Quantum Generator``
    | Prop.``Dark Matter Chamber``
    | Prop.``Hypermatter Reactor``
    | Prop.``Compression Vault``
    | Prop.``Component Storage``
    | Prop.``Holding Depot``
    | Prop.``Packing Station``
    | Prop.``Arsenal Racks``
    | Prop.``Extraspacial Lockers``
    | Prop.``Energy Cycler``
    | Prop.``Transport Mainframe``
    | Prop.``Transfer Shaft``
    | Prop.``Hadron Collector``
    | Prop.``Electrolysis Chamber``
    | Prop.``Processing Tank``
    | Prop.``Atomic Centrifuge``
    | Prop.``Purification Channel``
    | Prop.``Integration Channel``
    | Prop.``Material Processor``
    | Prop.``Material Compactor``
    | Prop.``Matter Filter``
    | Prop.``Manufacturing Mainframe``
    | Prop.``Construction Platform``
    | Prop.``Assembly Bed``
    | Prop.``Megafabricator``
    | Prop.``Subcomponent Replicator``
    | Prop.``Power Conduit``
    | Prop.``Research Mainframe``
    | Prop.``Antiparticle Reservoir``
    | Prop.``Reaction Chamber``
    | Prop.``Vacuum Chamber``
    | Prop.``Subatomic Condenser``
    | Prop.``Catalytron``
    | Prop.``Meson Extractor``
    | Prop.``Antimatter Diverter``
    | Prop.``Field Manipulator``
    | Prop.``Particle Synthesizer``
    | Prop.``Quantum Separator``
    | Prop.``Wave Intensifier``
    | Prop.``Proton Scatter Basin``
    | Prop.``Ion Accelerator``
    | Prop.``Magnetic Photon System``
    | Prop.``Hypercollider``
    | Prop.``Graviton Restrictor``
    | Prop.``Potential Refractor``
    | Prop.``Prototyping Station``
    | Prop.``Engineering Station``
    | Prop.``Biostasis Chamber``
    | Prop.``Organic Neutralizer``
    | Prop.``Containment Shield``
    | Prop.``Testing Mainframe``
    | Prop.``Sonic Impulse Analyzer``
    | Prop.``Field Warper``
    | Prop.``Gravity Sphere``
    | Prop.``Quantum Transformer``
    | Prop.``Focalizer``
    | Prop.``Phase Constrictor``
    | Prop.``Resonance Scanner``
    | Prop.``Tau Charger``
    | Prop.``Harmonic Fracturing Unit``
    | Prop.``Antiparticle Suffusor``
    | Prop.``Thermocompressor Array``
    | Prop.``Cryocooling Duct``
    | Prop.``Artifact Storage``
    | Prop.``Cryopreservation Unit``
    | Prop.``Biostim Tank``
    | Prop.``Quarantine Pod``
    | Prop.``Aeration Cycler``
    | Prop.``Deconstruction Unit``
    | Prop.``Anatomizer``
    | Prop.``Cloning Tubes``
    | Prop.``Cell Assembler``
    | Prop.``Molecular Binding Bank``
    | Prop.``Anti-Ion Cluster``
    | Prop.``Deuterium Array``
    | Prop.``Mainframe``
    | Prop.``Storage``
    | Prop.``Retrofitting Station``
    | Prop.``Signal Jammer``
    | Prop.``Cloak Generator``
    | Prop.``Decryption Engine``
    | Prop.``Backup Mainframe``
    | Prop.``Archive Unit``
    | Prop.``Control Node``
    | Prop.``Operations Mainframe``
    | Prop.``Quantum Router``
    | Prop.``Hyperwave Decoder``
    | Prop.``Sealed Freight Elevator``
    | Prop.``Radio-Gravity Array``
    | Prop.``Anti-Orbital Battery``
    | Prop.``Spectral Interrupter``
    | Prop.``Wave Collapse Detector``
    | Prop.``Signal Shield``
    | Prop.``Longscan Aggregator`` -> PropOcclusion.Obstructed
    | Prop.``Blade Trap``
    | Prop.``Segregator Trap``
    | Prop.``Explosive Trap``
    | Prop.``Heavy Explosive Trap``
    | Prop.``Tiamat Bomb Trap``
    | Prop.``Fusion Bomb Trap``
    | Prop.``Hellfire Trap``
    | Prop.``Armageddon Trap``
    | Prop.``Dirty Bomb Trap``
    | Prop.``EMP Trap``
    | Prop.``Proton Bomb Trap``
    | Prop.``Tesla Bomb Trap``
    | Prop.``Gamma Bomb Trap``
    | Prop.``Shrapnel Trap``
    | Prop.``Piercing Trap``
    | Prop.``Shock Trap``
    | Prop.``EM Surge Trap``
    | Prop.``Fire Trap``
    | Prop.``Stasis Trap``
    | Prop.``Alarm Trap``
    | Prop.``Ambush Trap``
    | Prop.``Chute Trap`` -> Dangerous
    | Prop.``Collapsed Tunnel``
    | Prop.``Door Terminal``
    | Prop.``DSF Access``
    | Prop.``Broken Shaft Lining``
    | Prop.``XXX_Blast_Door_Open``
    | Prop.``XXX_Blast_Door_Hackable``
    | Prop.``ACC_Door_Shootable_SUR``
    | Prop.``ACC_Door_Shootable_COM``
    | Prop.``ACC_Door_Hackable``
    | Prop.``ACC_Shell_Shootable`` -> PropOcclusion.Obstructed
    | Prop.``Main Access Lift`` -> PropOcclusion.Vacant
    | Prop.``STO_Door_Open``
    | Prop.``STO_Door_Hackable``
    | Prop.``STO_Shell_Shootable``
    | Prop.``GAR_Door_Shootable``
    | Prop.``GAR_Relay``
    | Prop.``GAR_Generator``
    | Prop.``GAR_RIF_Installer``
    | Prop.``Garrison Terminal``
    | Prop.``GAR_Heavy_Assembler``
    | Prop.``GAR_QS_Assembler``
    | Prop.``SHOP_Sys``
    | Prop.``MIN_Door_Hackable_Weak``
    | Prop.``Assembled Analyzer``
    | Prop.``Components``
    | Prop.``Testing Chamber Shield``
    | Prop.``Testing Apparatus``
    | Prop.``EX-Generator``
    | Prop.``BIN's Workstation``
    | Prop.``DEC's Workstation``
    | Prop.``HEX's Workstation``
    | Prop.``BIN's Terminal``
    | Prop.``DEC's Terminal``
    | Prop.``HEX's Terminal``
    | Prop.``EXI_Farcom``
    | Prop.``EX-Vault Access``
    | Prop.``EX-Prototypes Database``
    | Prop.``EX-Message Board``
    | Prop.``Repaired_Machine_T``
    | Prop.``Repaired_Machine_F``
    | Prop.``Repaired_Machine_R``
    | Prop.``Repaired_Machine_Y``
    | Prop.``Repaired_Machine_S``
    | Prop.``Testing Chamber``
    | Prop.``4L-MR0's Prototype Logs``
    | Prop.``SUB_Autodoor``
    | Prop.``Clippyterm``
    | Prop.``Triangle-emblazoned Door``
    | Prop.``WAR_Sys``
    | Prop.``Prototyping Terminal``
    | Prop.``CAV_Door_Hackable``
    | Prop.``Outpost Terminal``
    | Prop.``CAV_Base_Generator``
    | Prop.``CAV_Junk_Machine``
    | Prop.``CAV_Reinforcement``
    | Prop.``CAV_Door_Shootable``
    | Prop.``CAV_Door_No_Terminal``
    | Prop.``Private``
    | Prop.``CAV_Thief_Den``
    | Prop.``W-Fans Enter Here``
    | Prop.``LOW_Warlord_Fan_Stuff``
    | Prop.``PRO_Base_Generator``
    | Prop.``PRO_Target_Dispatcher``
    | Prop.``PRO_Test_Aggregator``
    | Prop.``PRO_Data_Receptor``
    | Prop.``Matter Repository``
    | Prop.``Twisting Tunnel``
    | Prop.``DAT_Data_Conduit``
    | Prop.``ORACLE Interface``
    | Prop.``ZHI_Cloak_Generator``
    | Prop.``ZHI_Main_Door``
    | Prop.``Zhirov's Terminal``
    | Prop.``Quantum Analyzer``
    | Prop.``Zhirov's Workstation``
    | Prop.``WAR_Door_Hackable``
    | Prop.``Vortex Lab Terminal``
    | Prop.``Hacking Lab Terminal``
    | Prop.``Relay Lab Terminal``
    | Prop.``Fabnet Lab Terminal``
    | Prop.``Intel Room Terminal``
    | Prop.``WAR_Staging_Area``
    | Prop.``RES_Staging_Area``
    | Prop.``WAR_Mainc_Tunnel``
    | Prop.``ZIO_Machinery``
    | Prop.``Deep Containment System``
    | Prop.``ZIOWAR_Quarantine_Array``
    | Prop.``ZIO_Cloak_Generator``
    | Prop.``ZIO_Stockpile_Wall``
    | Prop.``ZIO_Prototype_Hold``
    | Prop.``ZIO_Lab_Wall``
    | Prop.``ZIO_Repair_Shop_Wall``
    | Prop.``Zion Terminal``
    | Prop.``ZIO_Machinery_Fake``
    | Prop.``Conduit Teleporter``
    | Prop.``ZIO_Memory_Banks``
    | Prop.``ZIO_Imprinter``
    | Prop.``DEE_Z_Facility``
    | Prop.``Z-Power``
    | Prop.``DEE_Sigix_Wall``
    | Prop.``DEE_Sigix_Gate``
    | Prop.``DEE_Wall_Chamber``
    | Prop.``DEE_Survey_Way_Station``
    | Prop.``EXT_Door_Hackable``
    | Prop.``EXT_Transfer_Station``
    | Prop.``Cetus Terminal``
    | Prop.``Cetus Manufacturing Controls``
    | Prop.``CET_Door_Hackable``
    | Prop.``Doors``
    | Prop.``Bed``
    | Prop.``Lockers``
    | Prop.``Table``
    | Prop.``Lab Station``
    | Prop.``Research Interface``
    | Prop.``Cetus Mainframe``
    | Prop.``Cetus Manufacturing Module``
    | Prop.``Archive Terminal``
    | Prop.``Archive Hub``
    | Prop.``HUB_Transfer_Station``
    | Prop.``HUB_Network_Hub``
    | Prop.``ARM_Door_Hackable``
    | Prop.``ARM_Shell_Shootable``
    | Prop.``ARM_Dimension_Slip_Node``
    | Prop.``NO ENTRY``
    | Prop.``LAB_Door_Hackable``
    | Prop.``Active System Cloaker``
    | Prop.``A0 Command``
    | Prop.``hN 3sDk7Qc``
    | Prop.``A0 Storage 04-B``
    | Prop.``UC xVqbSdU M7q4``
    | Prop.``Suspension Chamber``
    | Prop.``TES_Door_Hackable``
    | Prop.``TES_Shell_Shootable``
    | Prop.``Regeneration Lab``
    | Prop.``TES_Terrabomb``
    | Prop.``QUA_Door_Hackable``
    | Prop.``QUA_Door_Hackable_Hard``
    | Prop.``Sigix Lab``
    | Prop.``Sigix Quarantine Controls``
    | Prop.``Sigix Quarantine Chamber``
    | Prop.``Teleportation Lab``
    | Prop.``Autopsy Lab``
    | Prop.``Research Terminal``
    | Prop.``SEC_Door_Hackable``
    | Prop.``L2 Monitoring Station``
    | Prop.``Power Cell Monitoring``
    | Prop.``Thrusters``
    | Prop.``SEC_L2_Power_Cell``
    | Prop.``Wing Frame``
    | Prop.``FTL Facilitator``
    | Prop.``Core Housing``
    | Prop.``Hull``
    | Prop.``Armor Plating``
    | Prop.``Navigation``
    | Prop.``Construction Supplies``
    | Prop.``L2 Fabricator``
    | Prop.``Exoskeleton Controls``
    | Prop.``Cave Seal Controls``
    | Prop.``COM_Cave_Spawn``
    | Prop.``COM_Shell_Shootable``
    | Prop.``Access Lift``
    | Prop.``COM_Teleport_Inhibitor``
    | Prop.``COM_Door_Hackable``
    | Prop.``COM_0b10_Conduit``
    | Prop.``COM_Alternative_Access``
    | Prop.``COM_Cache_Door``
    | Prop.``AC0_Singularity_Gate``
    | Prop.``Gate Controls``
    | Prop.``AC0_Subspace_Node``
    | Prop.``AC0_Subspace_Node_Mid``
    | Prop.``AC0_Architect_Shell``
    | Prop.``Architect Logs``
    | Prop.``AC0_Abandoned_Machinery``
    | Prop.``AC0_Shell_Shootable``
    | Prop.``Analysis Chamber``
    | Prop.``AC0_Workstation``
    | Prop.``JUN_Black_Space``
    | Prop.``JUN_New_Year_City`` -> PropOcclusion.Obstructed

let itemToCategory (item: Item) : ItemCategory =
    match item with
    | Item.``Matter`` -> Matter
    | Item.``Data Core``
    | Item.``Derelict Log``
    | Item.``Schematic Archive``
    | Item.``Imprinter Data Core``
    | Item.``A2 Data Core``
    | Item.``A7 Data Core``
    | Item.``MAIN_C Data Core``
    | Item.``Architect Data Core``
    | Item.``Scrap`` -> Misc
    | Item.``Protomatter`` -> Matter
    | Item.``Ion Engine``
    | Item.``Lgt_ Ion Engine``
    | Item.``Backup Power I``
    | Item.``Imp_ Ion Engine``
    | Item.``Rnf_ Ion Engine``
    | Item.``Hvy_ Ion Engine``
    | Item.``Cld_ Ion Engine``
    | Item.``Sub_ Power Source``
    | Item.``Deuterium Engine``
    | Item.``Lgt_ Deuterium Engine``
    | Item.``Backup Power III``
    | Item.``Nuclear Core``
    | Item.``Lgt_ Nuclear Core``
    | Item.``Imp_ Deuterium Engine``
    | Item.``Rnf_ Deuterium Engine``
    | Item.``Hyb_ Deuterium Engine``
    | Item.``Hvy_ Deuterium Engine``
    | Item.``Cld_ Deuterium Engine``
    | Item.``Enh_ Nuclear Core``
    | Item.``Mic_ Nuclear Core``
    | Item.``Mak_ Power Source``
    | Item.``Angular Momentum Engine``
    | Item.``Lgt_ Angular Momentum Engine``
    | Item.``F-cell Engine``
    | Item.``Fission Core``
    | Item.``Lgt_ Fission Core``
    | Item.``Hyb_ Fission Core``
    | Item.``Fusion Compressor``
    | Item.``Cold Fusion Reactor``
    | Item.``Neutrino Core``
    | Item.``Lgt_ Neutrino Core``
    | Item.``Rnf_ Fission Core``
    | Item.``Enh_ Fission Core``
    | Item.``Cld_ Fission Core``
    | Item.``Mic_ Fission Core``
    | Item.``Fusion Reactor``
    | Item.``Antimatter Reactor``
    | Item.``Lgt_ Antimatter Reactor``
    | Item.``Rnf_ Antimatter Reactor``
    | Item.``Hyb_ Antimatter Reactor``
    | Item.``Backup Power VII``
    | Item.``Hvy_ Antimatter Reactor``
    | Item.``Mni_ Fusion Reactor``
    | Item.``Imp_ Fusion Compressor``
    | Item.``Mic_ Neutrino Core``
    | Item.``Zio_ Light DM Reactor``
    | Item.``Zio_ Heavy DM Reactor``
    | Item.``Particle Reactor``
    | Item.``Lgt_ Particle Reactor``
    | Item.``Mic_ Antimatter Reactor``
    | Item.``Com_ Particle Reactor``
    | Item.``Cld_ Antimatter Reactor``
    | Item.``Graviton Reactor``
    | Item.``Asb_ Flux Generator``
    | Item.``Quantum Reactor``
    | Item.``Lgt_ Quantum Reactor``
    | Item.``Rnf_ Quantum Reactor``
    | Item.``Imp_ Quantum Reactor``
    | Item.``Zero-point Reactor``
    | Item.``Vortex Chain Reactor``
    | Item.``Singularity Reactor`` -> Power
    | Item.``Matter Drive``
    | Item.``Meta Core``
    | Item.``SE_PO1`` -> Utility Device
    | Item.``Lgt_ Treads``
    | Item.``Imp_ Treads``
    | Item.``Spk_ Treads``
    | Item.``Arm_ Treads``
    | Item.``Adv_ Treads``
    | Item.``Med_ Treads``
    | Item.``Imp_ Medium Treads``
    | Item.``Spk_ Medium Treads``
    | Item.``Arm_ Medium Treads``
    | Item.``Hvy_ Treads``
    | Item.``Adv_ Medium Treads``
    | Item.``Enh_ Armored Medium Treads``
    | Item.``Imp_ Heavy Treads``
    | Item.``Hvy_ Siege Treads``
    | Item.``Spk_ Heavy Treads``
    | Item.``Biometal Medium Treads``
    | Item.``Arm_ Heavy Treads``
    | Item.``Adv_ Heavy Treads``
    | Item.``Imp_ Heavy Siege Treads``
    | Item.``Centrium Heavy Treads``
    | Item.``Megatreads``
    | Item.``Biometal Heavy Treads``
    | Item.``Exp_ Biometal Heavy Treads``
    | Item.``Enh_ Armored Heavy Treads``
    | Item.``Adv_ Heavy Siege Treads``
    | Item.``Hdn_ Centrium Heavy Treads``
    | Item.``Exp_ Biometal Medium Treads`` -> Propulsion Treads
    | Item.``Aluminum Leg``
    | Item.``Imp_ Aluminum Leg``
    | Item.``Carbon-fiber Leg``
    | Item.``Titanium Leg``
    | Item.``VSS Leg``
    | Item.``Imp_ Carbon-fiber Leg``
    | Item.``Imp_ Titanium Leg``
    | Item.``Lgt_ Armored Exoskeleton``
    | Item.``Mak_ Leg``
    | Item.``Flexi-carbon Leg``
    | Item.``Arm_ Leg``
    | Item.``Imp_ VSS Leg``
    | Item.``Zio_ Composite Leg I``
    | Item.``Med_ Armored Exoskeleton``
    | Item.``Enh_ Flexi-carbon Leg``
    | Item.``Enh_ Armored Leg``
    | Item.``Arachnoskeleton``
    | Item.``Myomer Leg``
    | Item.``Adv_ VSS Leg``
    | Item.``Adv_ Myomer Leg``
    | Item.``Exp_ Flexi-carbon Leg``
    | Item.``Zio_ Composite Leg II``
    | Item.``Cargo Legs``
    | Item.``Etherial Tendrils``
    | Item.``Biometal Leg``
    | Item.``Hvy_ Armored Exoskeleton``
    | Item.``Enh_ Biometal Leg``
    | Item.``Exp_ Myomer Leg``
    | Item.``Tripod Weapons Platform``
    | Item.``T_R_O_L_L_ Exoskeleton``
    | Item.``Asb_ Alloy Leg``
    | Item.``Centrium Leg``
    | Item.``Hdn_ Centrium Leg``
    | Item.``Exp_ Biometal Leg``
    | Item.``Sigix Exoskeleton``
    | Item.``Zio_ Supercomposite Leg``
    | Item.``Potential Leg``
    | Item.``Myomer Exoskeleton``
    | Item.``SE_PR1`` -> Propulsion Legs
    | Item.``Wheel``
    | Item.``Com_ Wheel``
    | Item.``Arm_ Wheel``
    | Item.``Sub_ Monowheel``
    | Item.``Arm_ Huge Wheel``
    | Item.``Centrium Wheel``
    | Item.``Hdn_ Centrium Wheel`` -> Propulsion Wheel
    | Item.``Hover Unit``
    | Item.``Backup Propulsion I``
    | Item.``Imp_ Hover Unit``
    | Item.``Airjet``
    | Item.``Aerolev Unit``
    | Item.``Asb_ Hover Unit``
    | Item.``Backup Propulsion III``
    | Item.``Gravmag System``
    | Item.``Asb_ Hover System``
    | Item.``Imp_ Airjet``
    | Item.``Cld_ Airjet``
    | Item.``Imp_ Gravmag System``
    | Item.``Cld_ Aerolev Unit``
    | Item.``Cmb_ Airjet``
    | Item.``Gravmag Array``
    | Item.``Mak_ Hover Unit``
    | Item.``Zio_ Glidesys I``
    | Item.``Antigrav System``
    | Item.``Gyrokinetic Inverter``
    | Item.``Linear Gravjet``
    | Item.``Cld_ Gravmag System``
    | Item.``Cmb_ Gravmag System``
    | Item.``Imp_ Antigrav System``
    | Item.``Imp_ Gyrokinetic Inverter``
    | Item.``Imp_ Linear Gravjet``
    | Item.``Backup Propulsion VII``
    | Item.``Zio_ Glidesys II``
    | Item.``Cld_ Antigrav System``
    | Item.``Cmb_ Antigrav System``
    | Item.``Antigrav Array``
    | Item.``Exp_ Gyrokinetic Inverter``
    | Item.``Cld_ Linear Gravjet``
    | Item.``Cmb_ Linear Gravjet`` -> Propulsion Hover
    | Item.``Flight Unit``
    | Item.``VTOL Module``
    | Item.``Imp_ Flight Unit``
    | Item.``Cesium-ion Thruster``
    | Item.``Surge Thruster``
    | Item.``Imp_ VTOL Module``
    | Item.``Xenon Bombardment Thruster``
    | Item.``Imp_ Cesium-ion Thruster``
    | Item.``Cld_ VTOL Module``
    | Item.``Mak_ Flight Unit``
    | Item.``Nuclear Pulse Thruster``
    | Item.``Imp_ Surge Thruster``
    | Item.``Mni_ Nuclear Pulse Thruster``
    | Item.``Cld_ Cesium-ion Thruster``
    | Item.``Biomechanical Wings``
    | Item.``Field Propulsion Drive``
    | Item.``Cld_ Nuclear Pulse Thruster``
    | Item.``Exp_ Cesium-ion Thruster``
    | Item.``Nuclear Pulse Array``
    | Item.``Mak_ Microthruster``
    | Item.``Impulse Thruster``
    | Item.``Adv_ Surge Thruster``
    | Item.``Cld_ Field Propulsion Drive``
    | Item.``Field Propulsion Array``
    | Item.``Diametric Drive``
    | Item.``Flying Fortress v7``
    | Item.``T-thruster``
    | Item.``Integrated Tracker Drive``
    | Item.``Etherial Propulsion``
    | Item.``Q-thruster``
    | Item.``Electron Diverter``
    | Item.``Imp_ Diametric Drive``
    | Item.``Cld_ Impulse Thruster``
    | Item.``Impulse Thruster Array``
    | Item.``Flightbrick``
    | Item.``Imp_ Q-thruster``
    | Item.``Cld_ Q-thruster``
    | Item.``Exp_ Q-thruster`` -> Propulsion Flight
    | Item.``Scrap Engine``
    | Item.``Arm_ Scrap Engine``
    | Item.``Desublimator``
    | Item.``Power Amplifier``
    | Item.``Adv_ Power Amplifier``
    | Item.``Exp_ Power Amplifier``
    | Item.``Thermal Generator``
    | Item.``Imp_ Thermal Generator``
    | Item.``Adv_ Thermal Generator``
    | Item.``Exp_ Thermal Generator``
    | Item.``Cryofiber Web``
    | Item.``Imp_ Cryofiber Web``
    | Item.``Adv_ Cryofiber Web``
    | Item.``Exp_ Cryofiber Web``
    | Item.``Heat Sink``
    | Item.``Imp_ Heat Sink``
    | Item.``Adv_ Heat Sink``
    | Item.``Exp_ Heat Sink``
    | Item.``Cooling System``
    | Item.``Imp_ Cooling System``
    | Item.``Adv_ Cooling System``
    | Item.``Exp_ Cooling System``
    | Item.``Coolant Network``
    | Item.``Asb_ Nanovents``
    | Item.``2N-1CE's Frost Array``
    | Item.``Disposable Heat Sink``
    | Item.``Coolant Injector``
    | Item.``Imp_ Coolant Injector``
    | Item.``Adv_ Coolant Injector``
    | Item.``Exp_ Coolant Injector``
    | Item.``Sml_ Storage Unit``
    | Item.``Med_ Storage Unit``
    | Item.``Lrg_ Storage Unit``
    | Item.``Hcp_ Storage Unit``
    | Item.``Huge Storage Unit``
    | Item.``Cargo Storage Unit``
    | Item.``Humpback``
    | Item.``Lightpack 2_0``
    | Item.``Sml_ Battery``
    | Item.``Med_ Battery``
    | Item.``Lrg_ Battery``
    | Item.``Hcp_ Battery``
    | Item.``Com_ Battery``
    | Item.``Energy Well``
    | Item.``Imp_ Energy Well``
    | Item.``Adv_ Energy Well``
    | Item.``Exp_ Energy Well``
    | Item.``Zio_ Biocell``
    | Item.``Asb_ Biocell Array``
    | Item.``Zio_ Biocell Array``
    | Item.``Superbattery``
    | Item.``Sml_ Matter Pod``
    | Item.``Med_ Matter Pod``
    | Item.``Lrg_ Matter Pod``
    | Item.``Hcp_ Matter Pod``
    | Item.``Com_ Matter Pod``
    | Item.``Matter Compressor``
    | Item.``Imp_ Matter Compressor``
    | Item.``Adv_ Matter Compressor``
    | Item.``Exp_ Matter Compressor``
    | Item.``YI-UF0's Bottomless Matter Pit``
    | Item.``Weight Redist_ System``
    | Item.``Adv_ Weight Redist_ System``
    | Item.``Gravity Neutralizer``
    | Item.``Adv_ Gravity Neutralizer``
    | Item.``Quantum Shading Machine``
    | Item.``Asb_ Suspension Frame``
    | Item.``Adv_ Quantum Shading Machine``
    | Item.``Asb_ Metafiber Network``
    | Item.``Zio_ Metafield Generator``
    | Item.``ST Field Compressor``
    | Item.``Structural Scanner``
    | Item.``Trap Scanner``
    | Item.``Imp_ Trap Scanner``
    | Item.``Mak_ Trap Scanner``
    | Item.``Adv_ Trap Scanner``
    | Item.``Machine Analyzer``
    | Item.``Triangulator``
    | Item.``Visual Processing Unit``
    | Item.``Sub_ Optics``
    | Item.``Adv_ Visual Processing Unit``
    | Item.``Enh_ Optical Array``
    | Item.``Exp_ Optical Array``
    | Item.``Spectral Analyzer``
    | Item.``Sensor Array``
    | Item.``Imp_ Sensor Array``
    | Item.``Adv_ Sensor Array``
    | Item.``Lrn_ Sensor Array``
    | Item.``Mak_ Sensor Array``
    | Item.``Exp_ Sensor Array``
    | Item.``Signal Interpreter``
    | Item.``Imp_ Signal Interpreter``
    | Item.``Adv_ Signal Interpreter``
    | Item.``Exp_ Signal Interpreter``
    | Item.``Active Sensor Suite``
    | Item.``Terrain Scanner``
    | Item.``Imp_ Terrain Scanner``
    | Item.``Adv_ Terrain Scanner``
    | Item.``Mak_ Terrain Scanner``
    | Item.``Lrn_ Terrain Scanner``
    | Item.``Exp_ Terrain Scanner``
    | Item.``Surveybot 24 Scanner``
    | Item.``Terrain Scan Processor``
    | Item.``Imp_ Terrain Scan Processor``
    | Item.``Mak_ Terrain Scan Processor``
    | Item.``Adv_ Terrain Scan Processor``
    | Item.``Exp_ Terrain Scan Processor``
    | Item.``Surveybot 24 Chip``
    | Item.``Seismic Detector``
    | Item.``Transport Network Coupler``
    | Item.``Modified TNC``
    | Item.``Encrypted Comm Array``
    | Item.``0b10 Decoder Chip _Generic_``
    | Item.``0b10 Decoder Chip _Looter_``
    | Item.``0b10 Decoder Chip _Scout_``
    | Item.``0b10 Decoder Chip _Skirmisher_``
    | Item.``0b10 Alert Chip``
    | Item.``Salvage Targeting Computer``
    | Item.``Imp_ Salvage Targeting Computer``
    | Item.``Mak_ Salvage Targeting Computer``
    | Item.``Adv_ Salvage Targeting Computer``
    | Item.``Asb_ Combat Suite``
    | Item.``Targeting Computer``
    | Item.``Imp_ Targeting Computer``
    | Item.``Adv_ Targeting Computer``
    | Item.``Exp_ Targeting Computer``
    | Item.``Multitargeting Array``
    | Item.``Tactical Coordination Suite``
    | Item.``Melee Analysis Suite``
    | Item.``Imp_ Melee Analysis Suite``
    | Item.``Adv_ Melee Analysis Suite``
    | Item.``Exp_ Melee Analysis Suite``
    | Item.``Launcher Guidance Computer``
    | Item.``Imp_ Launcher Guidance Computer``
    | Item.``Adv_ Launcher Guidance Computer``
    | Item.``Weapon Mount``
    | Item.``Target Analyzer``
    | Item.``Imp_ Target Analyzer``
    | Item.``Adv_ Target Analyzer``
    | Item.``Exp_ Target Analyzer``
    | Item.``Core Analyzer``
    | Item.``Exp_ Core Analyzer``
    | Item.``Armor Integrity Analyzer``
    | Item.``Imp_ Armor Integrity Analyzer``
    | Item.``Exp_ Armor Integrity Analyzer``
    | Item.``Recoil Stabilizer``
    | Item.``Recoil Nullifier``
    | Item.``Matter Filter``
    | Item.``Prc_ Matter Filter``
    | Item.``Energy Filter``
    | Item.``Prc_ Energy Filter``
    | Item.``Particle Charger``
    | Item.``Imp_ Particle Charger``
    | Item.``Adv_ Particle Charger``
    | Item.``Particle Accelerator``
    | Item.``Imp_ Particle Accelerator``
    | Item.``Adv_ Particle Accelerator``
    | Item.``Kinecellerator``
    | Item.``Imp_ Kinecellerator``
    | Item.``Adv_ Kinecellerator``
    | Item.``Heavy Servo Lattice``
    | Item.``VL-GR5's Timing Chip``
    | Item.``Launcher Loader``
    | Item.``Quantum Capacitor``
    | Item.``Weapon Cycler``
    | Item.``Imp_ Weapon Cycler``
    | Item.``Adv_ Weapon Cycler``
    | Item.``Exp_ Weapon Cycler``
    | Item.``Microactuators``
    | Item.``Nanoactuators``
    | Item.``Femtoactuators``
    | Item.``Actuator Array``
    | Item.``Imp_ Actuator Array``
    | Item.``Adv_ Actuator Array``
    | Item.``Exp_ Actuator Array``
    | Item.``Force Booster``
    | Item.``Imp_ Force Booster``
    | Item.``Adv_ Force Booster``
    | Item.``Stasis Canceller``
    | Item.``Transmission Jammer``
    | Item.``Mak_ Transmission Jammer``
    | Item.``Imp_ Transmission Jammer``
    | Item.``Adv_ Transmission Jammer``
    | Item.``Exp_ Transmission Jammer``
    | Item.``ECM Suite``
    | Item.``Mak_ ECM Suite``
    | Item.``Adv_ ECM Suite``
    | Item.``Exp_ ECM Suite``
    | Item.``Active Sensor Spoofer``
    | Item.``Reaction Control System``
    | Item.``Imp_ Reaction Control System``
    | Item.``Adv_ Reaction Control System``
    | Item.``Exp_ Reaction Control System``
    | Item.``Phase Shifter``
    | Item.``Imp_ Phase Shifter``
    | Item.``Adv_ Phase Shifter``
    | Item.``Exp_ Phase Shifter``
    | Item.``Cloaking Device``
    | Item.``Mak_ Cloaking Device``
    | Item.``Imp_ Cloaking Device``
    | Item.``Adv_ Cloaking Device``
    | Item.``Exp_ Cloaking Device``
    | Item.``Cloak of Protection``
    | Item.``5H-AD0's Cloak``
    | Item.``Core Shielding``
    | Item.``Imp_ Core Shielding``
    | Item.``Exp_ Core Shielding``
    | Item.``Power Shielding``
    | Item.``Imp_ Power Shielding``
    | Item.``Exp_ Power Shielding``
    | Item.``Propulsion Shielding``
    | Item.``Imp_ Propulsion Shielding``
    | Item.``Exp_ Propulsion Shielding``
    | Item.``Utility Shielding``
    | Item.``Imp_ Utility Shielding``
    | Item.``Exp_ Utility Shielding``
    | Item.``Weapon Shielding``
    | Item.``Imp_ Weapon Shielding``
    | Item.``Exp_ Weapon Shielding``
    | Item.``Zio_ Weapon Casing``
    | Item.``Backup Plating I``
    | Item.``Backup Plating III``
    | Item.``Backup Plating VII``
    | Item.``Lgt_ Armor Plating``
    | Item.``Med_ Armor Plating``
    | Item.``Hvy_ Armor Plating``
    | Item.``Zio_ Light Carapace``
    | Item.``Zio_ Heavy Carapace``
    | Item.``Hrd_ Light Armor Plating``
    | Item.``Hrd_ Medium Armor Plating``
    | Item.``Hrd_ Heavy Armor Plating``
    | Item.``Imp_ Light Armor Plating``
    | Item.``Imp_ Medium Armor Plating``
    | Item.``Imp_ Heavy Armor Plating``
    | Item.``Lyr_ Light Armor Plating``
    | Item.``Mak_ Armor Plating``
    | Item.``Lyr_ Medium Armor Plating``
    | Item.``Lyr_ Heavy Armor Plating``
    | Item.``Gun Armor``
    | Item.``Centrium Light Armor Plating``
    | Item.``Centrium Medium Armor Plating``
    | Item.``Centrium Heavy Armor Plating``
    | Item.``Centrium Linked Plating``
    | Item.``Reactive Plating``
    | Item.``Med_ Reactive Plating``
    | Item.``Mak_ Kinetic Plating``
    | Item.``Hvy_ Reactive Plating``
    | Item.``Reflective Plating``
    | Item.``Med_ Reflective Plating``
    | Item.``Mak_ Thermal Plating``
    | Item.``Hvy_ Reflective Plating``
    | Item.``8R-AWN's Armor_TH``
    | Item.``8R-AWN's Armor_EX``
    | Item.``Insulated Plating``
    | Item.``Med_ Insulated Plating``
    | Item.``Hvy_ Insulated Plating``
    | Item.``Damper Plating``
    | Item.``Zio_ Shade Carapace``
    | Item.``Zio_ Shade Armor``
    | Item.``Asb_ Alloy Armor``
    | Item.``Mak_ Ablative Armor``
    | Item.``Active Cooling Armor``
    | Item.``Scrap Shield``
    | Item.``Powered Armor``
    | Item.``Imp_ Powered Armor``
    | Item.``Adv_ Powered Armor``
    | Item.``Exp_ Powered Armor``
    | Item.``1C-UTU's Buckler``
    | Item.``Lgt_ Regenerative Plating``
    | Item.``Med_ Regenerative Plating``
    | Item.``Hvy_ Regenerative Plating``
    | Item.``SHELL Armor``
    | Item.``Phase Armor``
    | Item.``Graphene Brace``
    | Item.``Focal Shield``
    | Item.``Imp_ Focal Shield``
    | Item.``Adv_ Focal Shield``
    | Item.``Exp_ Focal Shield``
    | Item.``Thermal Shield``
    | Item.``Imp_ Thermal Shield``
    | Item.``Adv_ Thermal Shield``
    | Item.``Exp_ Thermal Shield``
    | Item.``Thermal Barrier``
    | Item.``Beam Splitter``
    | Item.``Thermal Defense Suite``
    | Item.``Imp_ Thermal Defense Suite``
    | Item.``Adv_ Thermal Defense Suite``
    | Item.``Exp_ Thermal Defense Suite``
    | Item.``Shock Absorption System``
    | Item.``Imp_ Shock Absorption System``
    | Item.``Exp_ Shock Absorption System``
    | Item.``EM Disruption Field``
    | Item.``Adv_ EM Disruption Field``
    | Item.``Exp_ EM Disruption Field``
    | Item.``ME-RLN's Chromatic Screen``
    | Item.``Hardlight Generator``
    | Item.``Imp_ Hardlight Generator``
    | Item.``Adv_ Hardlight Generator``
    | Item.``Exp_ Hardlight Generator``
    | Item.``Shield Generator``
    | Item.``Imp_ Shield Generator``
    | Item.``Adv_ Shield Generator``
    | Item.``Exp_ Shield Generator``
    | Item.``Force Field``
    | Item.``Imp_ Force Field``
    | Item.``Adv_ Force Field``
    | Item.``Exp_ Force Field``
    | Item.``7V-RTL's Ultimate Field``
    | Item.``Vortex Field Projector``
    | Item.``Remote Shield``
    | Item.``Imp_ Remote Shield``
    | Item.``Adv_ Remote Shield``
    | Item.``Remote Force Field``
    | Item.``Imp_ Remote Force Field``
    | Item.``Energy Mantle``
    | Item.``Imp_ Energy Mantle``
    | Item.``AEGIS Remote Shield``
    | Item.``Phase Redirector``
    | Item.``Point Defense System``
    | Item.``Point Defense Array``
    | Item.``Antimissile System``
    | Item.``EX Chip 1``
    | Item.``Hacking Suite``
    | Item.``Mak_ Hacking Suite``
    | Item.``Imp_ Hacking Suite``
    | Item.``Adv_ Hacking Suite``
    | Item.``Exp_ Hacking Suite``
    | Item.``System Mapper``
    | Item.``Deep Network Scanner``
    | Item.``Architect God Chip A``
    | Item.``EX Chip 2``
    | Item.``System Shield``
    | Item.``Mak_ System Shield``
    | Item.``Imp_ System Shield``
    | Item.``Adv_ System Shield``
    | Item.``Exp_ System Shield``
    | Item.``Ghost Barrier``
    | Item.``Quantum Router``
    | Item.``Architect God Chip D``
    | Item.``Authchip _R_NC_``
    | Item.``Authchip _R_Combat_``
    | Item.``Authchip _Power_``
    | Item.``Authchip _Propulsion_``
    | Item.``Authchip _Device_``
    | Item.``Authchip _Storage_``
    | Item.``Authchip _Processor_``
    | Item.``Authchip _Armor_``
    | Item.``Authchip _Weapon_``
    | Item.``Relay Coupler _NC_``
    | Item.``Relay Coupler _C_``
    | Item.``Relay Coupler _Swarmer_``
    | Item.``Relay Coupler _Cutter_``
    | Item.``Relay Coupler _Grunt_``
    | Item.``Relay Coupler _Brawler_``
    | Item.``Relay Coupler _Duelist_``
    | Item.``Relay Coupler _Sentry_``
    | Item.``Relay Coupler _Demolisher_``
    | Item.``Relay Coupler _Specialist_``
    | Item.``Relay Coupler _Hunter_``
    | Item.``Relay Coupler _Heavy_``
    | Item.``Relay Coupler _Behemoth_``
    | Item.``Relay Coupler _Programmer_``
    | Item.``Relay Coupler _Proto_``
    | Item.``Skeleton Box``
    | Item.``01-MTF's Autohacker``
    | Item.``Component Analysis Suite``
    | Item.``Imp_ Component Analysis Suite``
    | Item.``Adv_ Component Analysis Suite``
    | Item.``Dynamic Insulation System``
    | Item.``Imp_ Dynamic Insulation System``
    | Item.``Adv_ Dynamic Insulation System``
    | Item.``System Guard``
    | Item.``Imp_ System Guard``
    | Item.``Exp_ System Guard``
    | Item.``Corruption Screen``
    | Item.``Imp_ Corruption Screen``
    | Item.``Adv_ Corruption Screen``
    | Item.``System Restoration Module``
    | Item.``Mak_ System Restoration Module``
    | Item.``Imp_ System Restoration Module``
    | Item.``Adv_ System Restoration Module``
    | Item.``System Purifier``
    | Item.``Exp_ System Purifier``
    | Item.``Tractor Beam``
    | Item.``Hpw_ Tractor Beam``
    | Item.``Lrn_ Tractor Beam``
    | Item.``Mobile Refinery Mk_ CCLXVII``
    | Item.``Trap Extractor``
    | Item.``Imp_ Trap Extractor``
    | Item.``Adv_ Trap Extractor``
    | Item.``Trap Reconfigurator``
    | Item.``Recalibrator``
    | Item.``Imp_ Recalibrator``
    | Item.``Adv_ Recalibrator``
    | Item.``Field Recycling Unit``
    | Item.``Imp_ Field Recycling Unit``
    | Item.``Adv_ Field Recycling Unit``
    | Item.``Exp_ Field Recycling Unit``
    | Item.``Drone Bay``
    | Item.``Z-Drone Bay``
    | Item.``Mni_ Drone Bay``
    | Item.``Mapping Drone Bay``
    | Item.``Adv_ Drone Bay``
    | Item.``Bomb Drone Bay``
    | Item.``Thief Drone Bay``
    | Item.``Decoy Drone Bay``
    | Item.``Splice Drone Bay``
    | Item.``Combat Drone Bay``
    | Item.``Assault Drone Bay``
    | Item.``Stealth Drone Bay``
    | Item.``Swarm Drone Bay``
    | Item.``Supersonic Drone Bay``
    | Item.``Sensor Drone Bay``
    | Item.``Hacking Drone Bay``
    | Item.``Minesniffer Drone Bay``
    | Item.``Army-in-a-Box``
    | Item.``Wardrone Bay``
    | Item.``Cobbler Unit``
    | Item.``Bomb Factory No_ 2``
    | Item.``Mobile Assembly Unit``
    | Item.``Heart of Steel``
    | Item.``GOLEM Unit``
    | Item.``PSU Rigger``
    | Item.``Phasing AFG``
    | Item.``AS-neutralizer No_ 17b``
    | Item.``V3-11A's Pendant``
    | Item.``Chronowheel``
    | Item.``Power Bank``
    | Item.``Rainbow Chip``
    | Item.``VL-GR5's Exoskeleton _Deathgrip_``
    | Item.``Dimensional Node Initializer``
    | Item.``Transdimensional Reconstructor``
    | Item.``Hpw_ Transdimensional Reconstructor``
    | Item.``Supercharged TR``
    | Item.``Core Expander``
    | Item.``Core Regenerator``
    | Item.``Integrity Redistributor``
    | Item.``Integrated Dissipator``
    | Item.``Supercharged Integrated Dissipator``
    | Item.``Integrated Thermoelectric Network``
    | Item.``Integrated Reactor``
    | Item.``Supercharged Integrated Reactor``
    | Item.``Integrated Mediator``
    | Item.``Core Membrane``
    | Item.``Navigation Efficiency Matrix``
    | Item.``Core Reset Matrix``
    | Item.``Subatomic Replicator``
    | Item.``Terrabomb``
    | Item.``Core Physics Calibrator``
    | Item.``Spacefold Activator``
    | Item.``Microwarp Drive``
    | Item.``LC Capacitor``
    | Item.``LRC Armor``
    | Item.``LRC Storage``
    | Item.``LRC Energy Well``
    | Item.``LRC Matter Compressor``
    | Item.``LRC Boosters``
    | Item.``LRC Insulator`` -> Utility Device
    | Item.``EM Pulse Gun``
    | Item.``Hvy_ EM Pulse Gun``
    | Item.``EM Shotgun``
    | Item.``Imp_ EM Shotgun``
    | Item.``Shock Rifle``
    | Item.``Riot Gun``
    | Item.``Hvy_ EM Shotgun``
    | Item.``Lightning Gun``
    | Item.``Hvy_ Riot Gun``
    | Item.``Arc Projector``
    | Item.``Prc_ Shock Rifle``
    | Item.``Hpw_ Shock Rifle``
    | Item.``Arc Thrower``
    | Item.``Imp_ Lightning Gun``
    | Item.``Tesla Rifle``
    | Item.``Imp_ Arc Projector``
    | Item.``Hvy_ Tesla Rifle``
    | Item.``Hyp_ EM Gauss Rifle``
    | Item.``Imp_ Arc Thrower``
    | Item.``01-MTF's Shockpuncher``
    | Item.``Gamma Rifle``
    | Item.``Tachyon Dispersion Ray``
    | Item.``Immobilizer``
    | Item.``Modified EM Gauss Rifle``
    | Item.``AWS_EX-DEC``
    | Item.``Enh_ Gamma Rifle``
    | Item.``Med_ Laser``
    | Item.``Sml_ Laser``
    | Item.``Backup Laser I``
    | Item.``Beam Rifle``
    | Item.``Particle Gun``
    | Item.``Spread Laser``
    | Item.``Imp_ Medium Laser``
    | Item.``Sub_ Laser``
    | Item.``Autobeam``
    | Item.``Field Laser``
    | Item.``Pulse Rifle``
    | Item.``Backup Laser III``
    | Item.``Hvy_ Particle Gun``
    | Item.``Prc_ Beam Rifle``
    | Item.``Adv_ Beam Rifle``
    | Item.``Hvy_ Laser``
    | Item.``Gatling Laser``
    | Item.``Cld_ Pulse Rifle``
    | Item.``Hpw_ Field Laser``
    | Item.``Imp_ Spread Laser``
    | Item.``Mak_ Laser``
    | Item.``Plasma Rifle``
    | Item.``Thermic Laser``
    | Item.``Beamcaster``
    | Item.``Force Rifle``
    | Item.``Imp_ Heavy Laser``
    | Item.``Storm Laser``
    | Item.``Zio_ Laser-S``
    | Item.``Wave Gun``
    | Item.``Variable Charge Gun``
    | Item.``Hvy_ Beamcaster``
    | Item.``Cld_ Plasma Rifle``
    | Item.``Enh_ Force Rifle``
    | Item.``Hvy_ Gatling Laser``
    | Item.``Zio_ Phaser-S``
    | Item.``Phase Gun``
    | Item.``Dispersion Rifle``
    | Item.``Backup Laser VII``
    | Item.``Plasma Storm``
    | Item.``Adv_ Plasma Rifle``
    | Item.``Hvy_ Wave Gun``
    | Item.``Adv_ Variable Charge Gun``
    | Item.``Cld_ Phase Gun``
    | Item.``Lrn_ Gatling Laser``
    | Item.``Warp Gun``
    | Item.``Vortex Rifle``
    | Item.``Zio_ Laser-M``
    | Item.``AWS_Thermal``
    | Item.``PD Laser``
    | Item.``Quantum Rifle``
    | Item.``Prc_ Phase Gun``
    | Item.``Hvy_ Dispersion Rifle``
    | Item.``Vortex Shotgun``
    | Item.``Vortex Rail``
    | Item.``Zio_ Phaser-M``
    | Item.``Enh_ Quantum Rifle``
    | Item.``Zio_ Laser-H``
    | Item.``Hvy_ Quantum Rifle``
    | Item.``Zio_ Phaser-H``
    | Item.``Gatling Beam``
    | Item.``Sigix Sheargun``
    | Item.``Modified Sigix Sheargun`` -> Weapon Gun
    | Item.``Lgt_ EM Pulse Cannon``
    | Item.``EM Pulse Cannon``
    | Item.``Imp_ EM Pulse Cannon``
    | Item.``Proton Cannon``
    | Item.``Lrn_ Proton Cannon``
    | Item.``Disruptor Cannon``
    | Item.``Hvy_ Proton Cannon``
    | Item.``HERF Cannon``
    | Item.``Hvy_ Disruptor Cannon``
    | Item.``Cld_ Proton Cannon``
    | Item.``Proton Burst Cannon``
    | Item.``Com_ HERF Cannon``
    | Item.``Latent Energy Streamer``
    | Item.``NK-0LA's Tesla Doomcannon``
    | Item.``EMDS``
    | Item.``Hpw_ Disruptor Cannon``
    | Item.``Beam Cannon``
    | Item.``Particle Cannon``
    | Item.``Adv_ Beam Cannon``
    | Item.``Sub_ Beam Cannon``
    | Item.``Hvy_ Particle Cannon``
    | Item.``Ion Cannon``
    | Item.``Plasma Cannon``
    | Item.``Hvy_ Ion Cannon``
    | Item.``Cld_ Particle Cannon``
    | Item.``Phase Cannon``
    | Item.``Hvy_ Plasma Cannon``
    | Item.``Cld_ Plasma Cannon``
    | Item.``Com_ Ion Cannon``
    | Item.``Ion Burst Cannon``
    | Item.``Adv_ Plasma Cannon``
    | Item.``Hvy_ Phase Cannon``
    | Item.``Neutron Cannon``
    | Item.``Powered Cannon``
    | Item.``Matter Neutralizer``
    | Item.``Hvy_ Neutron Cannon``
    | Item.``Lrn_ Phase Cannon``
    | Item.``Cld_ Phase Cannon``
    | Item.``Vortex Cannon``
    | Item.``Gui_ Plasma Cannon``
    | Item.``Nova Cannon``
    | Item.``Imp_ Matter Neutralizer``
    | Item.``Exp_ Thermic Cannon``
    | Item.``Vortex Driver``
    | Item.``Zio_ Alpha Cannon``
    | Item.``Asb_ Focal Cannon``
    | Item.``Enh_ Nova Cannon``
    | Item.``Firepult``
    | Item.``YOLO Cannon``
    | Item.``Potential Cannon``
    | Item.``Warp Cannon``
    | Item.``Cld_ Nova Cannon``
    | Item.``Null Cannon``
    | Item.``Imp_ Potential Cannon``
    | Item.``Multinova Projection Cannon``
    | Item.``Disintegrator``
    | Item.``Core Cannon``
    | Item.``Sigix Shearcannon``
    | Item.``Drained L-Cannon``
    | Item.``L-Cannon``
    | Item.``Zio_ Alpha Cannon Mk_ II``
    | Item.``BFG-9k Vortex Edition`` -> Weapon Cannon
    | Item.``Assault Rifle``
    | Item.``Asb_ Rifle``
    | Item.``Lgt_ Assault Rifle``
    | Item.``Hvy_ Assault Rifle``
    | Item.``Autogun``
    | Item.``Shotgun``
    | Item.``Battle Rifle``
    | Item.``Asb_ Heavy Rifle``
    | Item.``Sub_ Machine Gun``
    | Item.``Imp_ Assault Rifle``
    | Item.``Minigun``
    | Item.``Hpw_ Shotgun``
    | Item.``Asb_ Shotgun``
    | Item.``Barrage Gun``
    | Item.``Enh_ Autogun``
    | Item.``Gauss Rifle``
    | Item.``Asb_ Gauss Rifle``
    | Item.``Flak Gun``
    | Item.``Prc_ Assault Rifle``
    | Item.``Hvy_ Battle Rifle``
    | Item.``Mak_ Shrapnel Gun``
    | Item.``Coil Gun``
    | Item.``Hyp_ Gauss Rifle``
    | Item.``Hvy_ Machine Gun``
    | Item.``Imp_ Heavy Machine Gun``
    | Item.``Com_ Gauss Rifle``
    | Item.``XL Autogun Subcomponent``
    | Item.``KE Penetrator``
    | Item.``Hyp_ Coil Gun``
    | Item.``Imp_ KE Penetrator``
    | Item.``Enh_ Coil Gun``
    | Item.``Com_ Coil Gun``
    | Item.``Railgun``
    | Item.``Adv_ KE Penetrator``
    | Item.``Linked Autogun``
    | Item.``AWS_Gauss``
    | Item.``Hyp_ Railgun``
    | Item.``Helical Railgun``
    | Item.``Com_ Railgun``
    | Item.``XL Autogun Array``
    | Item.``12-ASH's Boomstick``
    | Item.``8R-AWN's Boregun``
    | Item.``Multirail``
    | Item.``Hyp_ Multirail``
    | Item.``5H-AD0's Sniper Rifle``
    | Item.``A3's Sniper Rifle`` -> Weapon Gun
    | Item.``Lgt_ Cannon``
    | Item.``Imp_ Light Cannon``
    | Item.``Battle Cannon``
    | Item.``Assault Cannon``
    | Item.``Hvy_ Assault Cannon``
    | Item.``Flak Cannon``
    | Item.``Adv_ Assault Cannon``
    | Item.``Gauss Cannon``
    | Item.``Slug Cannon``
    | Item.``Mni_ Assault Cannon``
    | Item.``Magnetic Acceleration Cannon``
    | Item.``Hvy_ Flak Cannon``
    | Item.``Bore Cannon``
    | Item.``Antimatter Cannon``
    | Item.``Mass Driver``
    | Item.``Hvy_ Mass Driver``
    | Item.``Enh_ Gauss Cannon``
    | Item.``Hyp_ Gauss Cannon``
    | Item.``Tri-rail Accelerator``
    | Item.``Hardcell Cannon``
    | Item.``Hvy_ Gauss Cannon``
    | Item.``Hyp_ Mass Driver``
    | Item.``Hvy_ Autocannon``
    | Item.``DAS Cannon``
    | Item.``Lgt_ Antimatter Cannon``
    | Item.``Linear Accelerator``
    | Item.``Hvy_ Linear Accelerator``
    | Item.``Com_ Mass Driver``
    | Item.``Hvy_ Hardcell Cannon``
    | Item.``Com_ Linear Accelerator``
    | Item.``Hyp_ Linear Accelerator``
    | Item.``Hcl_ Linear Accelerator``
    | Item.``Graviton Cannon``
    | Item.``Blast Cannon``
    | Item.``P1-3CE's Gatling Flakker``
    | Item.``AWS_Autocannon``
    | Item.``Perforator``
    | Item.``Omega Cannon`` -> Weapon Cannon
    | Item.``EMP Blaster``
    | Item.``Shock Bomb Launcher``
    | Item.``Adv_ EMP Blaster``
    | Item.``Proton Missile Launcher``
    | Item.``Imp_ Proton Missile Launcher``
    | Item.``Gui_ EMP Blaster``
    | Item.``Hvy_ Shock Bomb Launcher``
    | Item.``Tesla Bomb Launcher``
    | Item.``Hvy_ Proton Missile Launcher``
    | Item.``Com_ Tesla Bomb Launcher``
    | Item.``Gamma Bomb Array``
    | Item.``Enh_ Gamma Bomb Array``
    | Item.``Grenade Launcher``
    | Item.``Rocket Launcher``
    | Item.``Mni_ Grenade Launcher``
    | Item.``Sub_ Shrapnel Launcher``
    | Item.``Imp_ Grenade Launcher``
    | Item.``Missile Launcher``
    | Item.``Concussive RPG``
    | Item.``YI-UF0's Doublenader``
    | Item.``Hvy_ Rocket Launcher``
    | Item.``Hvy_ Missile Launcher``
    | Item.``Gui_ Missile Launcher``
    | Item.``Prc_ Grenade Launcher``
    | Item.``Rocket Array``
    | Item.``Lrn_ Missile Launcher``
    | Item.``Imp_ Concussive RPG``
    | Item.``Prc_ Rocket Launcher``
    | Item.``Scatter Rocket Array``
    | Item.``Smartbomb Launcher``
    | Item.``Mni_ Smartbomb Launcher``
    | Item.``Tiamat Missile Launcher``
    | Item.``Thermoblaster``
    | Item.``Micro-nuke Launcher``
    | Item.``Adv_ Concussive RPG``
    | Item.``Neutron Missile Launcher``
    | Item.``Fusion Bomb Launcher``
    | Item.``Hellfire Missile Launcher``
    | Item.``Adv_ Micro-nuke Launcher``
    | Item.``Tactical Quantum Warhead``
    | Item.``Vortex Catalyst Activator``
    | Item.``Chain Missile Launcher``
    | Item.``Ragnarok Missile Launcher``
    | Item.``Point Singularity Launcher``
    | Item.``Gui_ Micro-nuke Launcher``
    | Item.``99-TNT's Nukerbomber``
    | Item.``Z-bomb Delivery System``
    | Item.``Sigix Terminator``
    | Item.``Supercharged Sigix Terminator``
    | Item.``Containment Facilitator``
    | Item.``Detonator`` -> Weapon Launcher
    | Item.``Dirty Datajack``
    | Item.``Splice Injector``
    | Item.``Datajack``
    | Item.``Imp_ Datajack``
    | Item.``Adv_ Datajack``
    | Item.``Remote Datajack``
    | Item.``Imp_ Remote Datajack``
    | Item.``Adv_ Remote Datajack``
    | Item.``Exp_ Remote Datajack``
    | Item.``Gui_ Remote Datajack``
    | Item.``ME-RLN's Wand``
    | Item.``Field Lobotomy Kit``
    | Item.``Mining Laser``
    | Item.``Welding Torch``
    | Item.``Plasma Cutter``
    | Item.``Imp_ Plasma Cutter``
    | Item.``CPS Tube``
    | Item.``Multitool``
    | Item.``Flamer``
    | Item.``Asb_ F-torch``
    | Item.``Enh_ Flamer``
    | Item.``Plasma Flamer``
    | Item.``Asb_ P-torch``
    | Item.``RU-N14's Throwing Claymores``
    | Item.``RU-N14's Throwing Claymores v3``
    | Item.``AD-0RF's Magmablaster``
    | Item.``Stasis Beam``
    | Item.``Stasis Projector``
    | Item.``Exp_ Stasis Projector``
    | Item.``Molecular Deconstructor``
    | Item.``SE_WE1``
    | Item.``SE_WE2``
    | Item.``SE_WE3``
    | Item.``SE_WE4``
    | Item.``SE_WE5`` -> Weapon Special
    | Item.``Hammer``
    | Item.``Mace``
    | Item.``Flail``
    | Item.``Maul``
    | Item.``Asb_ Maul``
    | Item.``Hvy_ Hammer``
    | Item.``Hvy_ Mace``
    | Item.``Hvy_ Flail``
    | Item.``Great Maul``
    | Item.``Powered Hammer``
    | Item.``Mak_ Hammer``
    | Item.``Power Maul``
    | Item.``Asb_ P-maul``
    | Item.``Impact Mace``
    | Item.``Shock Maul``
    | Item.``Thunder Hammer``
    | Item.``Compactor``
    | Item.``Gravity Flail``
    | Item.``CL-ANK's Mallet``
    | Item.``Core Stripper``
    | Item.``Mining Claw``
    | Item.``EC_1``
    | Item.``Katana``
    | Item.``Asb_ Blade``
    | Item.``Scythe``
    | Item.``Axe``
    | Item.``Blade Saw``
    | Item.``EC_3``
    | Item.``Chainsword``
    | Item.``Ripper``
    | Item.``Mak_ Axe``
    | Item.``Mak_ Sword``
    | Item.``Great Axe``
    | Item.``Greatsword``
    | Item.``Power Sword``
    | Item.``Asb_ P-sword``
    | Item.``Falx``
    | Item.``Carbide Saw``
    | Item.``Segregator``
    | Item.``Tearclaws``
    | Item.``EC_5``
    | Item.``Phasing Sabre``
    | Item.``Plasma Sword``
    | Item.``Ionic Axe``
    | Item.``Mni_ Tearclaws``
    | Item.``Dual-blade Saw``
    | Item.``Vibroblade``
    | Item.``Molecular Scythe``
    | Item.``Centrium Greatsword``
    | Item.``Master Tearclaws``
    | Item.``Longsword _1``
    | Item.``EC_7``
    | Item.``Nanosword``
    | Item.``Particle Cleaver``
    | Item.``Centrium Claws``
    | Item.``1C-UTU's Sword _Lootmaker_``
    | Item.``1C-UTU's Sword _Choppy_``
    | Item.``Vortex Shredder``
    | Item.``EC_9``
    | Item.``Sigix Broadsword``
    | Item.``Spear``
    | Item.``Mak_ Spear``
    | Item.``CR-A16's Pointy Stick``
    | Item.``Hvy_ Pick``
    | Item.``Lance``
    | Item.``Kinetic Spear``
    | Item.``Force Lance``
    | Item.``Plasma Lance``
    | Item.``Enh_ Force Lance``
    | Item.``Vortex Lance``
    | Item.``CR-A16's Behemoth Slayer`` -> Weapon Melee
    | Item.``Blade Trap``
    | Item.``Segregator Trap``
    | Item.``Explosive Trap``
    | Item.``Heavy Explosive Trap``
    | Item.``Tiamat Bomb Trap``
    | Item.``Fusion Bomb Trap``
    | Item.``Hellfire Trap``
    | Item.``Armageddon Trap``
    | Item.``Dirty Bomb Trap``
    | Item.``EMP Trap``
    | Item.``Proton Bomb Trap``
    | Item.``Tesla Bomb Trap``
    | Item.``Gamma Bomb Trap``
    | Item.``Shrapnel Trap``
    | Item.``Piercing Trap``
    | Item.``Shock Trap``
    | Item.``EM Surge Trap``
    | Item.``Fire Trap``
    | Item.``Stasis Trap``
    | Item.``Scrap Shield Fragment``
    | Item.``Signal Generator``
    | Item.``Self-destruct Interrupter``
    | Item.``Sapper Charge``
    | Item.``Zhirov Special``
    | Item.``Deploy-a-Sentry``
    | Item.``GAL Module``
    | Item.``Portable AFG``
    | Item.``SGEMP Prototype``
    | Item.``Terrabomb Derivative``
    | Item.``Sigix Containment Pod``
    | Item.``Sigix Corpse``
    | Item.``Meganuke``
    | Item.``Gamma Refractor`` -> Misc

let itemToChar (item: Item) : string =
    match itemToCategory item with
    | Matter -> "%"
    | Propulsion _ -> "="
    | Power -> "*"
    | Misc -> "~"
    | Utility _ -> "!"
    | Weapon weapon ->
        match weapon with
        | Cannon -> "]"
        | Launcher -> "]"
        | Gun -> "["
        | Melee -> "/"
        | Special -> "~"

type Occupancy =
    | Obstructed
    | Vacant
    | Occupied of LuigiEntity

let mapTileOccupancy (tile: LuigiTile) =
    match tile.cell with
    | cell.NO_CELL
    | cell.SEALED_DOOR
    | cell.DOOR_SAN
    | cell.DOOR_JUN
    | cell.DOOR_MAT
    | cell.DOOR_FAC
    | cell.DOOR_RES
    | cell.DOOR_ACC
    | cell.DOOR_SUR
    | cell.DOOR_MIN
    | cell.DOOR_EXI
    | cell.DOOR_STO
    | cell.DOOR_REC
    | cell.DOOR_WAS
    | cell.DOOR_GAR
    | cell.DOOR_DSF
    | cell.DOOR_LOW
    | cell.DOOR_UPP
    | cell.DOOR_PRO
    | cell.DOOR_DEE
    | cell.DOOR_ZIO
    | cell.DOOR_DAT
    | cell.DOOR_ZHI
    | cell.DOOR_WAR
    | cell.DOOR_EXT
    | cell.DOOR_CET
    | cell.DOOR_ARC
    | cell.DOOR_HUB
    | cell.DOOR_ARM
    | cell.DOOR_LAB
    | cell.DOOR_QUA
    | cell.DOOR_TES
    | cell.DOOR_SEC
    | cell.DOOR_COM
    | cell.DOOR_AC0
    | cell.DOOR_LAI
    | cell.DOOR_TOW -> Vacant
    | cell.TEMP_WALL
    | cell.WALL_SAN
    | cell.WALL_JUN
    | cell.WALL_MAT
    | cell.WALL_FAC
    | cell.WALL_RES
    | cell.WALL_ACC
    | cell.WALL_SUR
    | cell.WALL_MIN
    | cell.WALL_EXI
    | cell.WALL_STO
    | cell.WALL_REC
    | cell.WALL_WAS
    | cell.WALL_GAR
    | cell.WALL_DSF
    | cell.WALL_LOW
    | cell.WALL_UPP
    | cell.WALL_PRO
    | cell.WALL_DEE
    | cell.WALL_ZIO
    | cell.WALL_DAT
    | cell.WALL_ZHI
    | cell.WALL_WAR
    | cell.WALL_EXT
    | cell.WALL_CET
    | cell.WALL_ARC
    | cell.WALL_HUB
    | cell.WALL_ARM
    | cell.WALL_LAB
    | cell.WALL_QUA
    | cell.WALL_TES
    | cell.WALL_SEC
    | cell.WALL_COM
    | cell.WALL_AC0
    | cell.WALL_LAI
    | cell.WALL_TOW
    | cell.EARTH
    | cell.EARTH_EXC -> Obstructed
    | cell.FLOOR_SAN
    | cell.FLOOR_JUN
    | cell.FLOOR_MAT
    | cell.FLOOR_FAC
    | cell.FLOOR_RES
    | cell.FLOOR_ACC
    | cell.FLOOR_SUR
    | cell.FLOOR_MIN
    | cell.FLOOR_EXI
    | cell.FLOOR_STO
    | cell.FLOOR_REC
    | cell.FLOOR_WAS
    | cell.FLOOR_GAR
    | cell.FLOOR_DSF
    | cell.FLOOR_LOW
    | cell.FLOOR_UPP
    | cell.FLOOR_PRO
    | cell.FLOOR_DEE
    | cell.FLOOR_ZIO
    | cell.FLOOR_DAT
    | cell.FLOOR_ZHI
    | cell.FLOOR_WAR
    | cell.FLOOR_EXT
    | cell.FLOOR_CET
    | cell.FLOOR_ARC
    | cell.FLOOR_HUB
    | cell.FLOOR_ARM
    | cell.FLOOR_LAB
    | cell.FLOOR_QUA
    | cell.FLOOR_TES
    | cell.FLOOR_SEC
    | cell.FLOOR_COM
    | cell.FLOOR_AC0
    | cell.FLOOR_LAI
    | cell.FLOOR_TOW
    | cell.GROUND -> Vacant
    | cell.STAIRS_SAN
    | cell.STAIRS_JUN
    | cell.STAIRS_MAT
    | cell.STAIRS_FAC
    | cell.STAIRS_RES
    | cell.STAIRS_SUR
    | cell.STAIRS_ACC
    | cell.STAIRS_MIN
    | cell.STAIRS_EXI
    | cell.STAIRS_STO
    | cell.STAIRS_REC
    | cell.STAIRS_WAS
    | cell.STAIRS_GAR
    | cell.STAIRS_DSF
    | cell.STAIRS_LOW
    | cell.STAIRS_UPP
    | cell.STAIRS_PRO
    | cell.STAIRS_DEE
    | cell.STAIRS_ZIO
    | cell.STAIRS_DAT
    | cell.STAIRS_ZHI
    | cell.STAIRS_WAR
    | cell.STAIRS_EXT
    | cell.STAIRS_CET
    | cell.STAIRS_ARC
    | cell.STAIRS_HUB
    | cell.STAIRS_ARM
    | cell.STAIRS_LAB
    | cell.STAIRS_QUA
    | cell.STAIRS_TES
    | cell.STAIRS_SEC
    | cell.STAIRS_COM
    | cell.STAIRS_AC0
    | cell.STAIRS_LAI
    | cell.STAIRS_TOW
    | cell.STAIRS_NOACCESS
    | cell.STAIRS_BLOCKED
    | cell.STAIRS_GAR_OPEN
    | cell.STAIRS_DSF_OPEN
    | cell.STAIRS_SHORTCUT -> Vacant
    | cell.SHORTCUT_SAN
    | cell.SHORTCUT_JUN
    | cell.SHORTCUT_MAT
    | cell.SHORTCUT_FAC
    | cell.SHORTCUT_RES
    | cell.SHORTCUT_ACC
    | cell.SHORTCUT_SUR
    | cell.SHORTCUT_MIN
    | cell.SHORTCUT_EXI
    | cell.SHORTCUT_STO
    | cell.SHORTCUT_REC
    | cell.SHORTCUT_WAS
    | cell.SHORTCUT_GAR
    | cell.SHORTCUT_DSF
    | cell.SHORTCUT_LOW
    | cell.SHORTCUT_UPP
    | cell.SHORTCUT_PRO
    | cell.SHORTCUT_DEE
    | cell.SHORTCUT_ZIO
    | cell.SHORTCUT_DAT
    | cell.SHORTCUT_ZHI
    | cell.SHORTCUT_WAR
    | cell.SHORTCUT_EXT
    | cell.SHORTCUT_CET
    | cell.SHORTCUT_ARC
    | cell.SHORTCUT_HUB
    | cell.SHORTCUT_ARM
    | cell.SHORTCUT_LAB
    | cell.SHORTCUT_QUA
    | cell.SHORTCUT_TES
    | cell.SHORTCUT_SEC
    | cell.SHORTCUT_COM
    | cell.SHORTCUT_AC0
    | cell.SHORTCUT_LAI
    | cell.SHORTCUT_TOW
    | cell.SHORTCUT_KNOWN -> Vacant
    | _ -> Obstructed // bad
    |> function
        | Occupied _ -> raise (System.Exception("invalid occupancy state of cell element"))
        | Obstructed -> Obstructed
        | Vacant ->
            // check if entity is present
            match tile.entity with
            | Some entity when entity.entity <> Entity.Cogmind -> Occupied entity
            | _ -> Vacant

    |> function
        | Vacant ->
            // check if prop is blocking
            match tile.prop with
            | Some prop ->
                match propToOcclusion prop.prop with
                | PropOcclusion.Obstructed -> Obstructed
                | _ -> Vacant
            | None -> Vacant
        | x -> x


let cellToChar (tile: LuigiTile) : string =
    match tile.cell with
    | cell.SEALED_DOOR
    | cell.DOOR_SAN
    | cell.DOOR_JUN
    | cell.DOOR_MAT
    | cell.DOOR_FAC
    | cell.DOOR_RES
    | cell.DOOR_ACC
    | cell.DOOR_SUR
    | cell.DOOR_MIN
    | cell.DOOR_EXI
    | cell.DOOR_STO
    | cell.DOOR_REC
    | cell.DOOR_WAS
    | cell.DOOR_GAR
    | cell.DOOR_DSF
    | cell.DOOR_LOW
    | cell.DOOR_UPP
    | cell.DOOR_PRO
    | cell.DOOR_DEE
    | cell.DOOR_ZIO
    | cell.DOOR_DAT
    | cell.DOOR_ZHI
    | cell.DOOR_WAR
    | cell.DOOR_EXT
    | cell.DOOR_CET
    | cell.DOOR_ARC
    | cell.DOOR_HUB
    | cell.DOOR_ARM
    | cell.DOOR_LAB
    | cell.DOOR_QUA
    | cell.DOOR_TES
    | cell.DOOR_SEC
    | cell.DOOR_COM
    | cell.DOOR_AC0
    | cell.DOOR_LAI
    | cell.DOOR_TOW -> Some "+"
    | cell.TEMP_WALL
    | cell.WALL_SAN
    | cell.WALL_JUN
    | cell.WALL_MAT
    | cell.WALL_FAC
    | cell.WALL_RES
    | cell.WALL_ACC
    | cell.WALL_SUR
    | cell.WALL_MIN
    | cell.WALL_EXI
    | cell.WALL_STO
    | cell.WALL_REC
    | cell.WALL_WAS
    | cell.WALL_GAR
    | cell.WALL_DSF
    | cell.WALL_LOW
    | cell.WALL_UPP
    | cell.WALL_PRO
    | cell.WALL_DEE
    | cell.WALL_ZIO
    | cell.WALL_DAT
    | cell.WALL_ZHI
    | cell.WALL_WAR
    | cell.WALL_EXT
    | cell.WALL_CET
    | cell.WALL_ARC
    | cell.WALL_HUB
    | cell.WALL_ARM
    | cell.WALL_LAB
    | cell.WALL_QUA
    | cell.WALL_TES
    | cell.WALL_SEC
    | cell.WALL_COM
    | cell.WALL_AC0
    | cell.WALL_LAI
    | cell.WALL_TOW
    | cell.EARTH
    | cell.EARTH_EXC -> Some "#"
    | cell.FLOOR_SAN
    | cell.FLOOR_JUN
    | cell.FLOOR_MAT
    | cell.FLOOR_FAC
    | cell.FLOOR_RES
    | cell.FLOOR_ACC
    | cell.FLOOR_SUR
    | cell.FLOOR_MIN
    | cell.FLOOR_EXI
    | cell.FLOOR_STO
    | cell.FLOOR_REC
    | cell.FLOOR_WAS
    | cell.FLOOR_GAR
    | cell.FLOOR_DSF
    | cell.FLOOR_LOW
    | cell.FLOOR_UPP
    | cell.FLOOR_PRO
    | cell.FLOOR_DEE
    | cell.FLOOR_ZIO
    | cell.FLOOR_DAT
    | cell.FLOOR_ZHI
    | cell.FLOOR_WAR
    | cell.FLOOR_EXT
    | cell.FLOOR_CET
    | cell.FLOOR_ARC
    | cell.FLOOR_HUB
    | cell.FLOOR_ARM
    | cell.FLOOR_LAB
    | cell.FLOOR_QUA
    | cell.FLOOR_TES
    | cell.FLOOR_SEC
    | cell.FLOOR_COM
    | cell.FLOOR_AC0
    | cell.FLOOR_LAI
    | cell.FLOOR_TOW
    | cell.GROUND -> Some " "
    | cell.STAIRS_SAN
    | cell.STAIRS_JUN
    | cell.STAIRS_MAT
    | cell.STAIRS_FAC
    | cell.STAIRS_RES
    | cell.STAIRS_SUR
    | cell.STAIRS_ACC
    | cell.STAIRS_MIN
    | cell.STAIRS_EXI
    | cell.STAIRS_STO
    | cell.STAIRS_REC
    | cell.STAIRS_WAS
    | cell.STAIRS_GAR
    | cell.STAIRS_DSF
    | cell.STAIRS_LOW
    | cell.STAIRS_UPP
    | cell.STAIRS_PRO
    | cell.STAIRS_DEE
    | cell.STAIRS_ZIO
    | cell.STAIRS_DAT
    | cell.STAIRS_ZHI
    | cell.STAIRS_WAR
    | cell.STAIRS_EXT
    | cell.STAIRS_CET
    | cell.STAIRS_ARC
    | cell.STAIRS_HUB
    | cell.STAIRS_ARM
    | cell.STAIRS_LAB
    | cell.STAIRS_QUA
    | cell.STAIRS_TES
    | cell.STAIRS_SEC
    | cell.STAIRS_COM
    | cell.STAIRS_AC0
    | cell.STAIRS_LAI
    | cell.STAIRS_TOW
    | cell.STAIRS_NOACCESS
    | cell.STAIRS_BLOCKED
    | cell.STAIRS_GAR_OPEN
    | cell.STAIRS_DSF_OPEN
    | cell.STAIRS_SHORTCUT -> Some ">"
    | cell.SHORTCUT_SAN
    | cell.SHORTCUT_JUN
    | cell.SHORTCUT_MAT
    | cell.SHORTCUT_FAC
    | cell.SHORTCUT_RES
    | cell.SHORTCUT_ACC
    | cell.SHORTCUT_SUR
    | cell.SHORTCUT_MIN
    | cell.SHORTCUT_EXI
    | cell.SHORTCUT_STO
    | cell.SHORTCUT_REC
    | cell.SHORTCUT_WAS
    | cell.SHORTCUT_GAR
    | cell.SHORTCUT_DSF
    | cell.SHORTCUT_LOW
    | cell.SHORTCUT_UPP
    | cell.SHORTCUT_PRO
    | cell.SHORTCUT_DEE
    | cell.SHORTCUT_ZIO
    | cell.SHORTCUT_DAT
    | cell.SHORTCUT_ZHI
    | cell.SHORTCUT_WAR
    | cell.SHORTCUT_EXT
    | cell.SHORTCUT_CET
    | cell.SHORTCUT_ARC
    | cell.SHORTCUT_HUB
    | cell.SHORTCUT_ARM
    | cell.SHORTCUT_LAB
    | cell.SHORTCUT_QUA
    | cell.SHORTCUT_TES
    | cell.SHORTCUT_SEC
    | cell.SHORTCUT_COM
    | cell.SHORTCUT_AC0
    | cell.SHORTCUT_LAI
    | cell.SHORTCUT_TOW
    | cell.SHORTCUT_KNOWN -> Some "<"
    | _ -> None
    |> function
        | Some char ->
            match char with
            | " " ->
                match tile.item with
                | Some item -> itemToChar item.item
                | None ->
                    match tile.entity with
                    | Some entity when entity.entity = Entity.Cogmind -> "@"
                    | Some _ -> "r"
                    | None -> " "
            | _ -> char
        | None -> "?"
    |> function
        | " " ->
            match tile.prop with
            | Some _ -> "X"
            | None -> " "
        | char -> char

let printMap (mapWidth, mapHeight) (tiles: LuigiTile list) =
    let sb = StringBuilder()

    for col in 0 .. mapWidth - 1 do
        for row in 0 .. mapHeight - 1 do
            let tile = tiles.[row * mapHeight + col]
            sb.Append(sprintf "%s" (cellToChar tile)) |> ignore

        sb.Append("\n") |> ignore

    sb.ToString()

let printPath path goal (mapWidth, mapHeight) (tiles: LuigiTile list) =
    for col in 0 .. mapWidth - 1 do
        for row in 0 .. mapHeight - 1 do
            let tile = tiles.[row * mapHeight + col]

            if List.contains tile path then
                match tile.entity with
                | Some entity when entity.entity = Entity.Cogmind -> printf "@"
                | _ when tile = goal -> printf "@"
                | _ -> printf "+"
            else
                printf "%s" (cellToChar tile)

        printfn ""

let playerTile tiles =
    tiles
    |> List.find (fun tile ->
        match tile.entity with
        | Some entity when entity.entity = Entity.Cogmind -> true
        | _ -> false)

let mobs tiles =
    tiles
    |> List.find (fun tile ->
        match tile.entity with
        | Some entity when entity.entity <> Entity.Cogmind -> true
        | _ -> false)
