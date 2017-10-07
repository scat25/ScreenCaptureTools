using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;

namespace ScreenCaptureTools
{
   //https://stackoverflow.com/questions/918990/c-sharp-capturing-the-mouse-cursor-image
   public class ScreenCapture
   {
      [StructLayout(LayoutKind.Sequential)]
      private struct CURSORINFO
      {
         public Int32 cbSize;
         public Int32 flags;
         public IntPtr hCursor;
         public POINTAPI ptScreenPos;
      }

      [StructLayout(LayoutKind.Sequential)]
      private struct ICONINFO
      {
         public bool fIcon;
         public Int32 xHotspot;
         public Int32 yHotspot;
         public IntPtr hbmMask;
         public IntPtr hbmColor;
      }

      [StructLayout(LayoutKind.Sequential)]
      private struct POINTAPI
      {
         public int x;
         public int y;
      }

      [DllImport("user32.dll")]
      private static extern bool GetCursorInfo(out CURSORINFO pci);

      [DllImport("user32.dll")]
      private static extern bool GetIconInfo(IntPtr hIcon, out ICONINFO piconinfo);

      [DllImport("user32.dll")]
      private static extern IntPtr CopyIcon(IntPtr hIcon);

      private const Int32 CURSOR_SHOWING = 0x0001;

      private static Bitmap CaptureCursor(CURSORINFO cursorInfo, ref Point position)
      {
         IntPtr hicon = CopyIcon(cursorInfo.hCursor);
         if (hicon == IntPtr.Zero)
            return null;

         ICONINFO iconInfo;
         if (!GetIconInfo(hicon, out iconInfo))
            return null;

         position.X = cursorInfo.ptScreenPos.x - iconInfo.xHotspot;
         position.Y = cursorInfo.ptScreenPos.y - iconInfo.yHotspot;

         using (Bitmap maskBitmap = Bitmap.FromHbitmap(iconInfo.hbmMask))
         {
            // check for monochrome cursor
            if (maskBitmap.Height == maskBitmap.Width * 2)
            {
               Bitmap cursor = new Bitmap(32, 32, PixelFormat.Format32bppArgb);
               Color BLACK = Color.FromArgb(255, 0, 0, 0); //cannot compare Color.Black because of different names
               Color WHITE = Color.FromArgb(255, 255, 255, 255); //cannot compare Color.White because of different names
               for (int y = 0; y < 32; y++)
               {
                  for (int x = 0; x < 32; x++)
                  {
                     Color maskPixel = maskBitmap.GetPixel(x, y);
                     Color cursorPixel = maskBitmap.GetPixel(x, y + 32);
                     if (maskPixel == WHITE && cursorPixel == BLACK)
                     {
                        cursor.SetPixel(x, y, Color.Transparent);
                     }
                     else if (maskPixel == BLACK)
                     {
                        cursor.SetPixel(x, y, cursorPixel);
                     }
                     else
                     {
                        cursor.SetPixel(x, y, cursorPixel == BLACK ? WHITE : BLACK);
                     }
                  }
               }
               return cursor;
            }
         }

         Icon icon = Icon.FromHandle(hicon);
         return icon.ToBitmap();
      }

      public static Bitmap Capture(Rectangle bounds, bool captureMouse, bool highlightCursor)
      {
         Bitmap result = new Bitmap(bounds.Width, bounds.Height);

         try
         {
            using (Graphics g = Graphics.FromImage(result))
            {
               g.CopyFromScreen(bounds.Location, Point.Empty, bounds.Size);

               if (captureMouse)
               {
                  CURSORINFO cursorInfo;
                  cursorInfo.cbSize = Marshal.SizeOf(typeof(CURSORINFO));

                  if (GetCursorInfo(out cursorInfo))
                  {
                     if (cursorInfo.flags == CURSOR_SHOWING)
                     {
                        Point p = new Point();
                        Bitmap cursor = CaptureCursor(cursorInfo, ref p);
                        p.X = p.X - bounds.X;
                        p.Y = p.Y - bounds.Y;
                        if (highlightCursor && p.X < bounds.Width && p.Y < bounds.Height)
                        {
                           g.FillEllipse(new SolidBrush(Color.FromArgb(160, Color.Yellow)), p.X - 16, p.Y - 12, 40, 40);
                        }
                        g.DrawImage(cursor, p);
                     }
                  }
               }
            }
         }
         catch
         {
            result = null;
         }

         return result;
      }
   }
}
