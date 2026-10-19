using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.Type;
namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Class
{
    /// <summary>
    /// Unity 6000.x (IL2CPP metadata 108) Il2CppClass layout.
    ///
    /// Every offset below was recovered from the shipping GameAssembly.dll of a Unity 6000.6.3f1
    /// title, by decoding the il2cpp_class_* accessor exports (each one is a single
    /// "mov reg,[rcx+disp]; ret", so the displacement IS the field offset) and by cross-checking
    /// the values against a live process:
    ///   il2cpp_class_get_name          -> mov rax,[rcx+0x10]   ("Object")
    ///   il2cpp_class_get_namespace     -> mov rax,[rcx+0x18]   ("System")
    ///   il2cpp_class_get_type          -> lea rax,[rcx+0x20]   (byval_arg)
    ///   il2cpp_class_get_image         -> mov rax,[rcx+0x00]
    ///   il2cpp_class_get_element_class -> mov rax,[rcx+0x40]
    ///   il2cpp_class_get_declaring_type-> mov rax,[rcx+0x50]
    ///   il2cpp_class_get_parent        -> mov rax,[rcx+0x58]
    ///   il2cpp_class_is_inflated       -> cmp qword [rcx+0x60],0
    ///   il2cpp_class_get_fields        -> mov rbx,[rcx+0x80]
    ///   il2cpp_class_get_methods       -> mov rcx,[rcx+0x88], movzx edx,word [rcx+0x118]
    ///   il2cpp_class_get_interfaces    -> klass+0x90 (verified at runtime)
    ///   il2cpp_class_get_static_field_data -> mov rax,[rcx+0x98]
    ///   il2cpp_class_has_parent        -> mov rdi,[rcx+0xA8]
    ///   il2cpp_class_set_userdata      -> mov [rcx+0xC8],rdx
    ///   il2cpp_class_instance_size     -> mov eax,[rcx+0xF0]
    ///   il2cpp_class_get_flags         -> mov eax,[rcx+0x110]
    ///   il2cpp_class_get_type_token    -> mov eax,[rcx+0x114]
    ///   il2cpp_class_num_fields        -> movzx eax,word [rcx+0x11C]
    ///   il2cpp_class_get_rank          -> movzx eax,byte [rcx+0x12A]
    ///   il2cpp_class_is_enum           -> movzx eax,byte [rcx+0x12D]; shr 2; and 1
    ///   il2cpp_class_is_generic        -> movzx eax,byte [rcx+0x12D]; shr 4; and 1
    ///   il2cpp_class_is_blittable      -> movzx eax,byte [rcx+0x12E]; shr 3; and 1
    /// The trailing bitfield bytes are therefore at 0x12D/0x12E and the struct ends at 0x130,
    /// which is where the vtable begins (confirmed: klass+0x130 holds the first method pointer).
    /// </summary>
    [ApplicableToUnityVersionsSince("6000.0.0")]
    public unsafe class NativeClassStructHandler_31_0 : INativeClassStructHandler
    {
        public int Size() => sizeof(Il2CppClass_31_0);
        public INativeClassStruct CreateNewStruct(int vTableSlots)
        {
            IntPtr ptr = Marshal.AllocHGlobal(Size() + sizeof(VirtualInvokeData) * vTableSlots);
            Il2CppClass_31_0* _ = (Il2CppClass_31_0*)ptr;
            *_ = default;
            return new NativeStructWrapper(ptr);
        }
        public INativeClassStruct Wrap(Il2CppClass* ptr)
        {
            if (ptr == null) return null;
            return new NativeStructWrapper((IntPtr)ptr);
        }
        internal unsafe struct Il2CppClass_31_0
        {
            public Il2CppImage* image;                              // 0x000
            public void* gc_desc;                                   // 0x008
            public byte* name;                                      // 0x010
            public byte* namespaze;                                 // 0x018
            public NativeTypeStructHandler_27_0.Il2CppType_27_0 byval_arg;  // 0x020
            public NativeTypeStructHandler_27_0.Il2CppType_27_0 this_arg;   // 0x030
            public Il2CppClass* element_class;                      // 0x040
            public Il2CppClass* castClass;                          // 0x048
            public Il2CppClass* declaringType;                      // 0x050
            public Il2CppClass* parent;                             // 0x058
            public void* generic_class;                             // 0x060
            public Il2CppMetadataTypeHandle typeMetadataHandle;     // 0x068
            public void* interopData;                               // 0x070
            public Il2CppClass* klass;                              // 0x078
            public Il2CppFieldInfo* fields;                         // 0x080
            public Il2CppMethodInfo** methods;                      // 0x088
            public Il2CppClass** implementedInterfaces;             // 0x090
            public void* static_fields;                             // 0x098
            public Il2CppRuntimeInterfaceOffsetPair* interfaceOffsets; // 0x0A0
            public Il2CppClass** typeHierarchy;                     // 0x0A8
            public Il2CppEventInfo* events;                         // 0x0B0
            public Il2CppPropertyInfo* properties;                  // 0x0B8
            public Il2CppClass** nestedTypes;                       // 0x0C0
            public void* unity_user_data;                           // 0x0C8
            public Il2CppGCHandle initializationExceptionGCHandle;  // 0x0D0
            public uint cctor_started;                              // 0x0D8
            public uint cctor_finished_or_no_cctor;                 // 0x0DC
            public IntPtr cctor_thread;                             // 0x0E0
            public Il2CppMetadataGenericContainerHandle genericContainerHandle; // 0x0E8
            public uint instance_size;                              // 0x0F0
            public uint stack_slot_size;                            // 0x0F4
            public uint actualSize;                                 // 0x0F8
            public uint element_size;                               // 0x0FC
            public int native_size;                                 // 0x100
            public uint static_fields_size;                         // 0x104
            public uint thread_static_fields_size;                  // 0x108
            public int thread_static_fields_offset;                 // 0x10C
            public uint flags;                                      // 0x110
            public uint token;                                      // 0x114
            public ushort method_count;                             // 0x118
            public ushort property_count;                           // 0x11A
            public ushort field_count;                              // 0x11C
            public ushort event_count;                              // 0x11E
            public ushort nested_type_count;                        // 0x120
            public ushort vtable_count;                             // 0x122
            public ushort interfaces_count;                         // 0x124
            public ushort interface_offsets_count;                  // 0x126
            public byte typeHierarchyDepth;                         // 0x128
            public byte genericRecursionDepth;                      // 0x129
            public byte rank;                                       // 0x12A
            public byte minimumAlignment;                           // 0x12B
            public byte packingSize;                                // 0x12C
            public Bitfield0 _bitfield0;                            // 0x12D
            public Bitfield1 _bitfield1;                            // 0x12E
            internal enum Bitfield0 : byte
            {
                BIT_initialized_and_no_error = 0,
                initialized_and_no_error = (1 << BIT_initialized_and_no_error),
                BIT_initialized = 1,
                initialized = (1 << BIT_initialized),
                BIT_enumtype = 2,
                enumtype = (1 << BIT_enumtype),
                BIT_nullabletype = 3,
                nullabletype = (1 << BIT_nullabletype),
                BIT_is_generic = 4,
                is_generic = (1 << BIT_is_generic),
                BIT_has_references = 5,
                has_references = (1 << BIT_has_references),
                BIT_init_pending = 6,
                init_pending = (1 << BIT_init_pending),
                BIT_size_init_pending = 7,
                size_init_pending = (1 << BIT_size_init_pending),
            }
            internal enum Bitfield1 : byte
            {
                BIT_size_inited = 0,
                size_inited = (1 << BIT_size_inited),
                BIT_has_finalize = 1,
                has_finalize = (1 << BIT_has_finalize),
                BIT_has_cctor = 2,
                has_cctor = (1 << BIT_has_cctor),
                BIT_is_blittable = 3,
                is_blittable = (1 << BIT_is_blittable),
                BIT_is_import_or_windows_runtime = 4,
                is_import_or_windows_runtime = (1 << BIT_is_import_or_windows_runtime),
                BIT_is_vtable_initialized = 5,
                is_vtable_initialized = (1 << BIT_is_vtable_initialized),
                BIT_is_byref_like = 6,
                is_byref_like = (1 << BIT_is_byref_like),
            }

        }

        internal class NativeStructWrapper : INativeClassStruct
        {
            public NativeStructWrapper(IntPtr ptr) => Pointer = ptr;
            private static int _bitfield0offset = Marshal.OffsetOf<Il2CppClass_31_0>(nameof(Il2CppClass_31_0._bitfield0)).ToInt32();
            private static int _bitfield1offset = Marshal.OffsetOf<Il2CppClass_31_0>(nameof(Il2CppClass_31_0._bitfield1)).ToInt32();
            public IntPtr Pointer { get; }
            private Il2CppClass_31_0* _ => (Il2CppClass_31_0*)Pointer;
            public IntPtr VTable => IntPtr.Add(Pointer, sizeof(Il2CppClass_31_0));
            public Il2CppClass* ClassPointer => (Il2CppClass*)Pointer;
            public INativeTypeStruct ByValArg => UnityVersionHandler.Wrap((Il2CppTypeStruct*)&_->byval_arg);
            public INativeTypeStruct ThisArg => UnityVersionHandler.Wrap((Il2CppTypeStruct*)&_->this_arg);
            public ref uint InstanceSize => ref _->instance_size;
            public ref ushort VtableCount => ref _->vtable_count;
            public ref ushort InterfaceCount => ref _->interfaces_count;
            public ref ushort InterfaceOffsetsCount => ref _->interface_offsets_count;
            public ref byte TypeHierarchyDepth => ref _->typeHierarchyDepth;
            public ref int NativeSize => ref _->native_size;
            public ref uint ActualSize => ref _->actualSize;
            public ref ushort MethodCount => ref _->method_count;
            public ref ushort FieldCount => ref _->field_count;
            public ref Il2CppClassAttributes Flags => ref *(Il2CppClassAttributes*)&_->flags;
            public ref IntPtr Name => ref *(IntPtr*)&_->name;
            public ref IntPtr Namespace => ref *(IntPtr*)&_->namespaze;
            public ref Il2CppImage* Image => ref _->image;
            public ref Il2CppClass* Parent => ref _->parent;
            public ref Il2CppClass* ElementClass => ref _->element_class;
            public ref Il2CppClass* CastClass => ref _->castClass;
            public ref Il2CppClass* DeclaringType => ref _->declaringType;
            public ref Il2CppClass* Class => ref _->klass;
            public ref Il2CppFieldInfo* Fields => ref _->fields;
            public ref Il2CppMethodInfo** Methods => ref _->methods;
            public ref Il2CppClass** ImplementedInterfaces => ref _->implementedInterfaces;
            public ref Il2CppRuntimeInterfaceOffsetPair* InterfaceOffsets => ref _->interfaceOffsets;
            public ref Il2CppClass** TypeHierarchy => ref _->typeHierarchy;
            public bool ValueType
            {
                get => ByValArg.ValueType && ThisArg.ValueType;
                set { }
            }
            public bool Initialized
            {
                get => this.CheckBit(_bitfield0offset, (int)Il2CppClass_31_0.Bitfield0.BIT_initialized);
                set => this.SetBit(_bitfield0offset, (int)Il2CppClass_31_0.Bitfield0.BIT_initialized, value);
            }
            public bool EnumType
            {
                get => this.CheckBit(_bitfield0offset, (int)Il2CppClass_31_0.Bitfield0.BIT_enumtype);
                set => this.SetBit(_bitfield0offset, (int)Il2CppClass_31_0.Bitfield0.BIT_enumtype, value);
            }
            public bool IsGeneric
            {
                get => this.CheckBit(_bitfield0offset, (int)Il2CppClass_31_0.Bitfield0.BIT_is_generic);
                set => this.SetBit(_bitfield0offset, (int)Il2CppClass_31_0.Bitfield0.BIT_is_generic, value);
            }
            public bool HasReferences
            {
                get => this.CheckBit(_bitfield0offset, (int)Il2CppClass_31_0.Bitfield0.BIT_has_references);
                set => this.SetBit(_bitfield0offset, (int)Il2CppClass_31_0.Bitfield0.BIT_has_references, value);
            }
            public bool SizeInited
            {
                get => this.CheckBit(_bitfield1offset, (int)Il2CppClass_31_0.Bitfield1.BIT_size_inited);
                set => this.SetBit(_bitfield1offset, (int)Il2CppClass_31_0.Bitfield1.BIT_size_inited, value);
            }
            public bool HasFinalize
            {
                get => this.CheckBit(_bitfield1offset, (int)Il2CppClass_31_0.Bitfield1.BIT_has_finalize);
                set => this.SetBit(_bitfield1offset, (int)Il2CppClass_31_0.Bitfield1.BIT_has_finalize, value);
            }
            public bool IsVtableInitialized
            {
                get => this.CheckBit(_bitfield1offset, (int)Il2CppClass_31_0.Bitfield1.BIT_is_vtable_initialized);
                set => this.SetBit(_bitfield1offset, (int)Il2CppClass_31_0.Bitfield1.BIT_is_vtable_initialized, value);
            }
            public bool InitializedAndNoError
            {
                get => this.CheckBit(_bitfield0offset, (int)Il2CppClass_31_0.Bitfield0.BIT_initialized_and_no_error);
                set => this.SetBit(_bitfield0offset, (int)Il2CppClass_31_0.Bitfield0.BIT_initialized_and_no_error, value);
            }
        }

    }

}
