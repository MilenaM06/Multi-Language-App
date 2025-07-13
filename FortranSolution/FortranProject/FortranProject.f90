!  FortranProject.f90 
!
!  FUNCTIONS/SUBROUTINES exported from FortranProject.dll:
!  FortranProject - subroutine 
!
    
subroutine hello(buf, buflen) bind(C, name="hello")
    !DEC$ ATTRIBUTES DLLEXPORT :: hello
    use iso_c_binding
    implicit none

    character(kind=c_char), intent(out) :: buf(*)
    integer(c_int), value :: buflen

    integer :: i
    character(len=27), parameter :: msg = "Hello from Fortran Project!"

    ! Clear buffer                                                 
    do i = 1, buflen
       buf(i) = c_null_char
    end do

    ! Copy message chars to buf (up to buflen-1 to leave space for null terminator)
    do i = 1, min(len_trim(msg), buflen-1)
       buf(i) = msg(i:i)
    end do
end subroutine hello
