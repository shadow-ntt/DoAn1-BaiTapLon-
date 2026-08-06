using System;
using System.Drawing;
using System.Windows.Forms;

namespace DoAn1.Forms
{
    /// <summary>
    /// Tag dữ liệu gắn vào mỗi TreeNode dùng để điều hướng và phân quyền.
    /// </summary>
    public class NavNodeTag
    {
        public string Key { get; set; } = string.Empty;
        public bool IsAuthorized { get; set; } = false;
        public string[] AllowedPositions { get; set; } = Array.Empty<string>();
    }
}
