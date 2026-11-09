using System.Windows.Forms;

namespace REMS.UI.Base
{
    /// <summary>
    /// فورم أساسي بيجمع الشغلات المشتركة بين فورمات المشروع
    /// (عرض الرسائل وفتح الـ Dialog). الفورمات بترث منه بدل ما تكرر الكود.
    /// </summary>
    public class BaseForm : Form
    {
        // عرض النص عربي من اليمين لليسار داخل الـ MessageBox.
        private const MessageBoxOptions RtlOptions =
            MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign;

        protected void ShowInfo(string message) =>
            ShowMessage(message, "تم", MessageBoxIcon.Information);

        protected void ShowWarning(string message) =>
            ShowMessage(message, "تنبيه", MessageBoxIcon.Warning);

        protected void ShowError(string message) =>
            ShowMessage(message, "خطأ", MessageBoxIcon.Error);

        /// <summary>
        /// يسأل المستخدم سؤال نعم/لا. مفيد لأزرار الحذف.
        /// </summary>
        protected bool Confirm(string message, string title = "تأكيد") =>
            ShowMessage(message, title, MessageBoxIcon.Question, MessageBoxButtons.YesNo)
                == DialogResult.Yes;

        /// <summary>
        /// يعرض الفورم كـ Dialog فوق هذا الفورم، وبعد الإغلاق بيعمله Dispose.
        /// </summary>
        protected void ShowDialogAndDispose(Form form)
        {
            using (form)
                form.ShowDialog(this);
        }

        private DialogResult ShowMessage(
            string message,
            string title,
            MessageBoxIcon icon,
            MessageBoxButtons buttons = MessageBoxButtons.OK)
        {
            return MessageBox.Show(
                this, message, title, buttons, icon,
                MessageBoxDefaultButton.Button1, RtlOptions);
        }
    }
}