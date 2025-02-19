Welcome to ***my own operating system project***  
**Discord Server: https://discord.gg/GxwmAK7aRE**  
~~**UEFI one available! check out https://github.com/nifanfa/Solution1/tree/uefi**~~  
C# operating system demo, using Native AOT (Core RT) boot via multiboot  
| Screenshot |
| ------ |
| ![image](https://github.com/nifanfa/Moos/blob/master/VirtualBox_NativeAOT_23_04_2022_16_35_34.png) |

| Items | Implemented | Working On Real Hardware (Tested on Supermicro X9DRI-LN4F+) | Note |
| ----- | ----------- | ----------------------------------------------------------- | ----- |
| Applications(.exe) | ✅ | ✅ |
| Error Throwing / Catching | ❌ | ❌ | 
| GC | ⚠️ | ❓ | Not safe |
| Multithreading(Single Core) | ✅ | ✅ |
| PS2 Keyboard/Mouse(USB Compatible) | ✅ | ✅ |
| Nintendo Family Computer Emulator | ✅ | ✅ |
| Intel® Gigabit Ethernet Network | ✅ | ✅ |
| Realtek RTL8139 | ✅ | ❓ |
| ExFAT | ✅ | ✅ |
| FAT32 | ❓ | ❓ |
| FAT16 | ❓ | ❓ |
| FAT12 | ❓ | ❓ |
| I/O APIC | ⚠️ | ✅ | Cause triple fault on some PC |
| Local APIC | ⚠️ | ✅ | Cause triple fault on some PC |
| SATA | ⚠️ | ❌ | Can't read more than one sec at once, Can't detect sata controller on real hardware |
| IDE | ✅ | ✅ |
| SMBIOS | ✅ | ✅ |
| ACPI | ✅ | ✅ |
| IPv4 | ✅ | ✅ |
| IPv6 | ❌ | ❌ |
| TCP(WIP) | ⚠️ | ❓ | Can't receive large package |
| UDP | ✅ | ❓ |
| Lan | ✅ | ✅ |
| Wan | ✅ | ❓ 
