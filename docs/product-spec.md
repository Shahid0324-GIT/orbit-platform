# Orbit — Product Specification

## 1. Vision

Orbit is a collaborative project and task management platform that will evolve from a simple full-stack monolith into a production-style distributed system.

The product is both a usable application and a hands-on engineering laboratory for learning backend development, frontend performance, system design, distributed systems, and production engineering.

## 2. Target Users

- Individuals managing their own work.
- Small teams collaborating on projects.
- Project managers tracking progress and deadlines.

## 3. Core Domain

- **User:** An authenticated person using Orbit.
- **Organization:** A workspace containing members and projects.
- **Membership:** A user's relationship with an organization and their role.
- **Project:** A collection of related tasks.
- **Task:** A unit of work with an assignee, status, priority, and optional due date.
- **Comment:** A discussion attached to a task.

## 4. Initial Scope — V0

### User access

- Register and log in.
- View the current user's profile.
- Protect authenticated application routes.

### Projects

- Create, view, edit, and delete projects.
- List projects belonging to the user's organization.
- View project details and progress.

### Tasks

- Create, view, edit, and delete tasks.
- Assign tasks to users.
- Set status, priority, and due date.
- Filter and sort tasks.

### Dashboard

- Display project summaries.
- Show task counts by status.
- Identify overdue and completed tasks.

### Frontend experience

- Responsive layout.
- Reusable components.
- Form validation.
- Loading, empty, and error states.
- Accessible interactions.

## 5. Initial Technical Constraints

- Frontend: Next.js, React, TypeScript.
- Backend: C# and ASP.NET Core.
- Database: PostgreSQL.
- Architecture: Modular monolith.
- Communication: REST API over HTTP.
- Version control: Git with feature branches.
- Development environment: Windows and PowerShell.

Redis, RabbitMQ, Node.js, FastAPI, and additional infrastructure are intentionally excluded from V0.

## 6. Engineering Principles

1. Keep the application runnable at every milestone.
2. Keep business rules in the C# backend.
3. Treat PostgreSQL as the durable source of truth.
4. Measure performance before optimizing.
5. Introduce infrastructure only when there is a clear reason.
6. Test important behavior and failure scenarios.
7. Record significant architecture decisions.
8. Prefer understandable code over premature abstraction.

## 7. Definition of Done — V0

- Users can authenticate.
- Users can create and manage projects.
- Users can create and manage tasks within projects.
- Authorization prevents access to another organization's data.
- The frontend communicates with the backend through documented API contracts.
- Database migrations work from a clean database.
- Critical business rules have automated tests.
- Loading, validation, and error states are handled.
- Setup instructions allow another developer to run the application locally.
- Changes are committed through the agreed Git workflow.

## 8. Future Evolution

V0: Full-stack monolith.

V1: Production-quality APIs, authorization, testing, and observability.

V2: Database and frontend performance engineering.

V3: Redis caching and rate limiting.

V4: RabbitMQ and asynchronous workers.

V5: FastAPI AI service.

V6: Node.js real-time collaboration service.

V7: Horizontal scaling and distributed-system experiments.

V8: Advanced observability, reliability, and failure engineering.

Future milestones are conditional on learning goals and demonstrated needs, not fixed deadlines.
