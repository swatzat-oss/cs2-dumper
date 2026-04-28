// Generated using https://github.com/a2x/cs2-dumper
// 2026-04-28 19:24:25.266387700 UTC

namespace CS2Dumper.Schemas {
    // Module: vphysics2.dll
    // Class count: 0
    // Enum count: 5
    public static class Vphysics2Dll {
        // Alignment: 4
        // Member count: 3
        public enum JointMotion_t : uint {
            JOINT_MOTION_FREE = 0x0,
            JOINT_MOTION_LOCKED = 0x1,
            JOINT_MOTION_COUNT = 0x2
        }
        // Alignment: 4
        // Member count: 4
        public enum JointAxis_t : uint {
            JOINT_AXIS_X = 0x0,
            JOINT_AXIS_Y = 0x1,
            JOINT_AXIS_Z = 0x2,
            JOINT_AXIS_COUNT = 0x3
        }
        // Alignment: 1
        // Member count: 3
        public enum DynamicContinuousContactBehavior_t : byte {
            DYNAMIC_CONTINUOUS_ALLOW_IF_REQUESTED_BY_OTHER_BODY = 0x0,
            DYNAMIC_CONTINUOUS_ALWAYS = 0x1,
            DYNAMIC_CONTINUOUS_NEVER = 0x2
        }
        // Alignment: 4
        // Member count: 8
        public enum PhysInterfaceId_t : uint {
            PIID_UNKNOWN = 0x0,
            PIID_IPHYSICSBODY = 0x1,
            PIID_IPHYSAGGREGATE = 0x2,
            PIID_IPHYSICSJOINT = 0x3,
            PIID_IPHYSICSMOTIONCONTROLLER = 0x4,
            PIID_IPHYSICSPARTICLEROPE = 0x5,
            PIID_IPHYSICSRAGDOLLCONTROL = 0x6,
            PIID_NUM_TYPES = 0x7
        }
        // Alignment: 1
        // Member count: 5
        public enum PhysGenericShapeType_t : byte {
            GENERIC_SHAPE_POINT = 0x0,
            GENERIC_SHAPE_SPHERE = 0x1,
            GENERIC_SHAPE_AABB = 0x2,
            GENERIC_SHAPE_CAPSULE = 0x3,
            GENERIC_SHAPE_HULL = 0x4
        }
    }
}
