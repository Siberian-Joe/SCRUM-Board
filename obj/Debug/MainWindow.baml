   M S B A M L   `   `   `  ����N  JScrumBoardNewDesign, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ScrumBoardNewDesignScrumBoardNewDesign  5   	   $    ScrumBoardNewDesign.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:ScrumBoardNewDesign     5   	   -   5          � Title$  SCRUM board��5   	   $	��700��6   $	��990��6*    � AllowsTransparency . 
������  � WindowStyle$
 None=�5
   	    � 
ResizeMode$ NoResize=�6   .��5      �� -   5         ��Name$ 
mainBorder��5       �� CornerRadius$ 10��6!   $��2��63   ��5   
   �� 5       �� Color$ #101828��6   ._�5   
   �  � ColumnDefinitions 5      �� 5      $	��200 �6#   �� 5       � RowDefinitions 5      �� 5      $��53 �6    �� 5      .+�5      �� -   5        $ loadingBorder��5      $��2��6,   $��2��6=   
�������	 J� Opacity$		 0.5Q�6d   $ 10��6r   
 K� ZIndex$
 1��6�   $y�	Collapsed=�6�   �� 5      -   5        $ 
leftBorder��5      $��2��6)   ���#1C263B$ 10��6P   ���#101828$��
0, 0, 1, 0q�6w   �� 5       -   5        $ rightBorder��5       $��2��6*   $��1��6;   $ 10��6K   ���#121A2B6]   �� 5"      -   5         ��Name$ 
exitButton��5"      $��23��6)   $��23��64   $��×��6@   $��0, 15, 15, 0q�6f   $��Normal"�6|   $	��Top=�6�   $��Right=�6�   $��16(�6�   $��1��6�   �� 5#      $��SCRUM board��6   $��Center=�6+   $��Center=�6F   
�������$��22(�6v   $��	Helvetica)�6�   $��Light"�6�   �� 5$      $��1��6   .+�5%      #   ScrumBoardNewDesign.UserPanel  -   5          Name$ 	userPanel��5%   "   �� 5&      -   5        $ addTaskButton��5&      $��Add Task��60   $��50��6C   $��14(�6O   $��10, 10, 10, 0q�6]   6t   �� 5'      -	   5        $ saveTaskButton��5'      $
��Save��61   $��50��6@   $��14(�6L   $��10, 10, 10, 0q�6Z   6q   �� 5(      -
   5        $ refreshTaskButton��5(      $��Refresh��64   $��50��6F   $��14(�6R   $��10, 10, 10, 0q�6`   6w   5)      �� 5*      -   5        $ themeButton��5*      $��1��6*   $��Bottom=�67   $��
Dark Theme��6R   $��50��6g   $��14(�6s   $��10q�6�   6�   �� 5+      $��1��6   $��1��6(   $
��Auto=�68   $
��Auto=�6[   .��5,      � -   5         �Name$ mainGrid��5,      $
��Left=�6)   $	��Top=�6D    5-      �� 5.       50      �� 51      53      54      �� 55      -   5        $ 
backButton��55      $��23��6)   $��23��64   $	��←��6@   $��	0,15,45,0q�6f   $��Normal"�6y   $	��Top=�6�   $��Right=�6�   $��16(�6�   $��1��6�   56      57      58      