using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MosqueCommunity.GroupBox_Control_Container
{
    public class grpbxRegisterMembers
    {
          public grpbxRegisterMembers(BaseForm ContainerForm)
        {
            ContainerForm.grpbxRegisterMembers = new System.Windows.Forms.GroupBox();

            ContainerForm.grpbxReportMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
          | System.Windows.Forms.AnchorStyles.Left)
          | System.Windows.Forms.AnchorStyles.Right)));
            ContainerForm.grpbxRegisterMembers.Location = new System.Drawing.Point(0, 1);
            ContainerForm.grpbxRegisterMembers.Name = "grpbxRegisterMembers";
            ContainerForm.grpbxRegisterMembers.Size = new System.Drawing.Size(722, 531);
            ContainerForm.grpbxRegisterMembers.TabIndex = 3;
            ContainerForm.grpbxRegisterMembers.TabStop = false;
            ContainerForm.grpbxRegisterMembers.Text = "Register Members";
            ContainerForm.Controls.Add(ContainerForm.grpbxRegisterMembers);
            //ContainerForm.showControls.Add(ContainerForm.trvwMainTree.Nodes.Find("ndReport", true)[0], ContainerForm.grpbxReportMembers);
        }
    }
}
