   M S B A M L   `   `   `  ���� G  CVideoRecoder, Version=1.0.0.1, Culture=neutral, PublicKeyToken=null+clr-namespace:VideoRecoderVideoRecoder      VideoRecoder.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ,localclr-namespace:VideoRecoder       � Title$  
MainWindow��$	��450��$	��800��.��� $	��407��$��0,0,10,0q�.+��� $��Center=�$��0,10,0,0q�$��Vedio Recoder��$
��Wrap=�$	��Top=�$��70��$	��337��$��52(��� $
��Left=�$��
10,154,0,0q�$��input video: ��$
��Wrap=�$	��Top=�$��18(��� -    ��Name$ inputFilePath��$��Center=�$��	0,146,0,0q�$��input path here�� �� TextWrapping$
 Wrap=�$	��Top=�$	��522��$��40�����	#FFDEDEDE�� -    ��Name$ inputBrowseButton��$��Browse��$��Right=�$��
0,146,19,0q�$	��Top=�$��98��$��40�����	#FF66CCFF
�������$��18(��� $
��Left=�$��
10,258,0,0q�$��output Video: ��$
��Wrap=�$	��Top=�$��18(��� -    ��Name$ 	videoType��$
��Left=�$��124,258,0,0q�$	��Top=�$	��120��$��24��$ �� IsSynchronizedWithCurrentItem$
 TrueY� �� 
IsEditable$
 True���� -   $ outputFilePath��$��Right=�$��0,250,134,0q�$��output path here��$
 Wrap=�$	��Top=�$	��385��$��40�����	#FFD4D4D4�� -   $ outputBrowseButton��$��Browse��$��Right=�$��
0,0,19,117q�$��98��$��18(����	#FF66CCFF
�������$��40��$��Bottom=��� -   $ startButton��$��Start��$��Center=�$��	0,335,0,0q�$	��180��
����������	#FF03E3B3$��24(�$��54��$	��Top=�