// Decompiled with JetBrains decompiler
// Type: hpdPatchMHP2G.Program
// Assembly: MonsterHunter2G KorPatch, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E2D0E602-1310-4EBF-B2D7-D651B15B3CDC
// Assembly location: E:\Game\PSP\MHP2ndG_Hangulnal_v1.11\MHP2G_Hangulnal.exe

using System;
using System.Windows.Forms;

namespace hpdPatchMHP2G
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new Form1());
    }
  }
}
