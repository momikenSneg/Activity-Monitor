�
tC:\Users\Anton\Downloads\THE REAL SCIENCE\УППРПО\Activity-Monitor\Activity-Monitor\ActivityMonitor.PMT\APMT.cs
	namespace 	
ActivityMonitor
 
. 
PMT 
{ 
public 

	interface 
APMT 
{ 
string 
[ 
] 
GetProjects 
( 
) 
; 
Task 
< 
string 
[ 
] 
> 
GetUsers 
(  
string  &
project' .
). /
;/ 0
} 
} �	
�C:\Users\Anton\Downloads\THE REAL SCIENCE\УППРПО\Activity-Monitor\Activity-Monitor\ActivityMonitor.PMT\obj\Debug\netstandard2.0\SpecFlow.Plus.Runner.AssemblyHooks.cs
public 
class ?
3ActivityMonitor_PMT_SpecFlowPlusRunnerAssemblyHooks @
{ 
[ 
global 
:: 
TechTalk 
. 
SpecRun 
. 
AssemblyInitialize 0
]0 1
public 

static 
void 
AssemblyInitialize )
() *
)* +
{ 
TestRunnerManager 
. 
GetTestRunner '
(' (
)( )
.) *
OnTestRunStart* 8
(8 9
)9 :
;: ;
}		 
[ 
global 
:: 
TechTalk 
. 
SpecRun 
. 
AssemblyCleanup -
]- .
public 

static 
void 
AssemblyCleanup &
(& '
)' (
{ 
TestRunnerManager 
. 
OnTestRunEnd &
(& '
)' (
;( )
} 
} 