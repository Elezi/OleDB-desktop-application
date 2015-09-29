using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MosqueCommunity.GroupBox_Control_Container
{
    public class grpbxReportMembers
    {
        public grpbxReportMembers(BaseForm ContainerForm)
        {
            ContainerForm.grpbxReportMembers = new System.Windows.Forms.GroupBox();

            ContainerForm.grpbxReportMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
          | System.Windows.Forms.AnchorStyles.Left)
          | System.Windows.Forms.AnchorStyles.Right)));
            ContainerForm.grpbxReportMembers.Location = new System.Drawing.Point(0, 1);
            ContainerForm.grpbxReportMembers.Name = "grpbxReportMembers";
            ContainerForm.grpbxReportMembers.Size = new System.Drawing.Size(722, 531);
            ContainerForm.grpbxReportMembers.TabIndex = 3;
            ContainerForm.grpbxReportMembers.TabStop = false;
            ContainerForm.grpbxReportMembers.Text = "Report Members";
            ContainerForm.Controls.Add(ContainerForm.grpbxReportMembers);
            //ContainerForm.showControls.Add(ContainerForm.trvwMainTree.Nodes.Find("ndReport", true)[0], ContainerForm.grpbxReportMembers);
        }
    }
}
