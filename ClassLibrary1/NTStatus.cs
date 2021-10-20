﻿//  Copyright 2016 Google Inc. All Rights Reserved.
//
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//  http://www.apache.org/licenses/LICENSE-2.0
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.


namespace Styletronix
{
    public partial class CloudFilterApi
    {


#pragma warning disable 1591
        /// <summary>
        /// NT status values
        /// </summary>
        public enum NtStatus : uint
        {
            STATUS_SUCCESS = 0x00000000,
            STATUS_CLOUD_FILE_PROPERTY_BLOB_CHECKSUM_MISMATCH = 0x8000CF00,
            STATUS_UNSUCCESSFUL = 0xC0000001,
            STATUS_CLOUD_FILE_SYNC_ROOT_METADATA_CORRUPT = 0xC000CF00,
            STATUS_CLOUD_FILE_PROVIDER_NOT_RUNNING = 0xC000CF01,
            STATUS_CLOUD_FILE_METADATA_CORRUPT = 0xC000CF02,
            STATUS_CLOUD_FILE_METADATA_TOO_LARGE = 0xC000CF03,
            STATUS_CLOUD_FILE_PROPERTY_BLOB_TOO_LARGE = 0x8000CF04,
            STATUS_CLOUD_FILE_TOO_MANY_PROPERTY_BLOBS = 0x8000CF05,
            STATUS_CLOUD_FILE_PROPERTY_VERSION_NOT_SUPPORTED = 0xC000CF06,
            STATUS_NOT_A_CLOUD_FILE = 0xC000CF07,
            STATUS_CLOUD_FILE_NOT_IN_SYNC = 0xC000CF08,
            STATUS_CLOUD_FILE_ALREADY_CONNECTED = 0xC000CF09,
            STATUS_CLOUD_FILE_NOT_SUPPORTED = 0xC000CF0A,
            STATUS_CLOUD_FILE_INVALID_REQUEST = 0xC000CF0B,
            STATUS_CLOUD_FILE_READ_ONLY_VOLUME = 0xC000CF0C,
            STATUS_CLOUD_FILE_CONNECTED_PROVIDER_ONLY = 0xC000CF0D,
            STATUS_CLOUD_FILE_VALIDATION_FAILED = 0xC000CF0E,
            STATUS_CLOUD_FILE_AUTHENTICATION_FAILED = 0xC000CF0F,
            STATUS_CLOUD_FILE_INSUFFICIENT_RESOURCES = 0xC000CF10,
            STATUS_CLOUD_FILE_NETWORK_UNAVAILABLE = 0xC000CF11,
            STATUS_CLOUD_FILE_UNSUCCESSFUL = 0xC000CF12,
            STATUS_CLOUD_FILE_NOT_UNDER_SYNC_ROOT = 0xC000CF13,
            STATUS_CLOUD_FILE_IN_USE = 0xC000CF14,
            STATUS_CLOUD_FILE_PINNED = 0xC000CF15,
            STATUS_CLOUD_FILE_REQUEST_ABORTED = 0xC000CF16,
            STATUS_CLOUD_FILE_PROPERTY_CORRUPT = 0xC000CF17,
            STATUS_CLOUD_FILE_ACCESS_DENIED = 0xC000CF18,
            STATUS_CLOUD_FILE_INCOMPATIBLE_HARDLINKS = 0xC000CF19,
            STATUS_CLOUD_FILE_PROPERTY_LOCK_CONFLICT = 0xC000CF1A,
            STATUS_CLOUD_FILE_REQUEST_CANCELED = 0xC000CF1B,
            STATUS_CLOUD_FILE_PROVIDER_TERMINATED = 0xC000CF1D,
            STATUS_NOT_A_CLOUD_SYNC_ROOT = 0xC000CF1E
        }

        public enum NtStatusFacility
        {
            FACILITY_DEFAULT = 0x0,
            FACILITY_DEBUGGER = 0x1,
            FACILITY_RPC_RUNTIME = 0x2,
            FACILITY_RPC_STUBS = 0x3,
            FACILITY_IO_ERROR_CODE = 0x4,
            FACILITY_CODCLASS_ERROR_CODE = 0x6,
            FACILITY_NTWIN32 = 0x7,
            FACILITY_NTCERT = 0x8,
            FACILITY_NTSSPI = 0x9,
            FACILITY_TERMINAL_SERVER = 0xA,
            FACILTIY_MUI_ERROR_CODE = 0xB,
            FACILITY_USB_ERROR_CODE = 0x10,
            FACILITY_HID_ERROR_CODE = 0x11,
            FACILITY_FIREWIRE_ERROR_CODE = 0x12,
            FACILITY_CLUSTER_ERROR_CODE = 0x13,
            FACILITY_ACPI_ERROR_CODE = 0x14,
            FACILITY_SXS_ERROR_CODE = 0x15,
            FACILITY_TRANSACTION = 0x19,
            FACILITY_COMMONLOG = 0x1A,
            FACILITY_VIDEO = 0x1B,
            FACILITY_FILTER_MANAGER = 0x1C,
            FACILITY_MONITOR = 0x1D,
            FACILITY_GRAPHICS_KERNEL = 0x1E,
            FACILITY_DRIVER_FRAMEWORK = 0x20,
            FACILITY_FVE_ERROR_CODE = 0x21,
            FACILITY_FWP_ERROR_CODE = 0x22,
            FACILITY_NDIS_ERROR_CODE = 0x23,
            FACILITY_TPM = 0x29,
            FACILITY_RTPM = 0x2A,
            FACILITY_HYPERVISOR = 0x35,
            FACILITY_IPSEC = 0x36,
            FACILITY_VIRTUALIZATION = 0x37,
            FACILITY_VOLMGR = 0x38,
            FACILITY_BCD_ERROR_CODE = 0x39,
            FACILITY_WIN32K_NTUSER = 0x3E,
            FACILITY_WIN32K_NTGDI = 0x3F,
            FACILITY_RESUME_KEY_FILTER = 0x40,
            FACILITY_RDBSS = 0x41,
            FACILITY_BTH_ATT = 0x42,
            FACILITY_SECUREBOOT = 0x43,
            FACILITY_AUDIO_KERNEL = 0x44,
            FACILITY_VSM = 0x45,
            FACILITY_VOLSNAP = 0x50,
            FACILITY_SDBUS = 0x51,
            FACILITY_SHARED_VHDX = 0x5C,
            FACILITY_SMB = 0x5D,
            FACILITY_VISUALCPP = 0x6D,
            FACILITY_INTERIX = 0x99,
            FACILITY_SPACES = 0xE7,
            FACILITY_SECURITY_CORE = 0xE8,
            FACILITY_SYSTEM_INTEGRITY = 0xE9,
            FACILITY_LICENSING = 0xEA,
            FACILITY_PLATFORM_MANIFEST = 0xEB,
            FACILITY_APP_EXEC = 0xEC,
        }

        public enum NtStatusSeverity
        {
            STATUS_SEVERITY_SUCCESS = 0x0,
            STATUS_SEVERITY_INFORMATIONAL = 0x1,
            STATUS_SEVERITY_WARNING = 0x2,
            STATUS_SEVERITY_ERROR = 0x3,
        }
    }
}