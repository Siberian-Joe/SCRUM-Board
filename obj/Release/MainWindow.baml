   M S B A M L   `   `   `  ���� N  JScrumBoardNewDesign, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ScrumBoardNewDesignScrumBoardNewDesign  $    ScrumBoardNewDesign.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     3local!clr-namespace:ScrumBoardNewDesign     -     � Title$  
MainWindow��$	��700��$
��1075�� � AllowsTransparency . 
������  � WindowStyle$
 None=� � 
ResizeMode$ NoResize=�.����  �� CornerRadius$ 10��$��2������ .���  � Color$ #7be9f6�� � Offset$	 0.0Q�� $ #f083da��$ 1Q�._��  � ColumnDefinitions �� $	��200 ���  � RowDefinitions �� $��53 ��� .+��� -   	 ��Name$	 loadingBorder��$��2��$��2��
�������
 J� Opacity$	
 0.5Q�$ 10�� K� ZIndex$ 1��$y�	Collapsed=��� -    ��Name$ 
exitButton��$��23��$��23��$��×��$��0, 15, 15, 0q�$��Normal"�$	��Top=�$��Right=�$��16(�$��1���� $��SCRUM board��$��Center=�$��Center=�
�������$��22(�$��	Helvetica)�$��Light"��� $��1��.+��� -   $ addTaskButton��$��Add Task��$��50��$��14(�$��10, 10, 10, 0q��� -   $ saveTaskButton��$
��Save��$��50��$��14(�$��10, 10, 10, 0q��� -   $ refreshTaskButton��$��Refresh��$��50��$��14(�$��10, 10, 10, 0q��� $��1��$��1��$
��Auto=�$
��Auto=�.��� -    �Name$ mainGrid��$
��Left=�$	��Top=� ��  �� 